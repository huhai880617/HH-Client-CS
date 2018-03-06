USE [master]
GO

/****** Object:  StoredProcedure [dbo].[p_BackupDB]    Script Date: 10/24/2016 08:35:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[p_BackupDB]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[p_BackupDB]
GO

USE [master]
GO

/****** Object:  StoredProcedure [dbo].[p_BackupDB]    Script Date: 10/24/2016 08:35:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

---第二步：创建3个存储过程 分别为p_BackupDB,p_RestoreDB,p_CreateJob
create PROC [dbo].[p_BackupDB]
    @DBNAME SYSNAME='',       --要备份的数据库名称,不指定则备份当前数据库
    @BKPATH NVARCHAR(260)='', --备份文件的存放目录,不指定则使用SQL默认的备份目录
    @BKFNAME NVARCHAR(260)='',--备份文件名,文件名中可以用\DBNAME\代表数据库名,\DATE\代表日期,\TIME\代表时间
    @BKTYPE NVARCHAR(10)='DB',--备份类型:'DB'备份数据库,'DF' 差异备份,'LOG' 日志备份
    @APPENDFILE BIT=1         --追加/覆盖备份文件
AS
BEGIN
    DECLARE @SQL VARCHAR(8000)
    IF ISNULL(@DBNAME,'')=''  SET @DBNAME=DB_NAME()--当前数据库
    IF ISNULL(@BKPATH,'')=''  SET @BKPATH=dbo.f_GetDBPath(NULL)
    IF ISNULL(@BKFNAME,'')='' SET @BKFNAME='\DBNAME\_\DATE\_\TIME\.BAK'
    
    SET @BKFNAME=REPLACE(REPLACE(REPLACE(@BKFNAME,'\DBNAME\',@DBNAME)
    ,'\DATE\',CONVERT(VARCHAR,GETDATE(),112))
    ,'\TIME\',REPLACE(CONVERT(VARCHAR,GETDATE(),108),':',''))
    
    SET @SQL='BACKUP '+CASE @BKTYPE WHEN 'LOG' THEN 'LOG ' ELSE 'DATABASE ' END
    +'['+@DBNAME+']'
    +' TO DISK='''+@BKPATH+@BKFNAME
    +''' WITH '+CASE @BKTYPE WHEN 'DF' THEN 'DIFFERENTIAL,' ELSE '' END
    +CASE @APPENDFILE WHEN 1 THEN 'NOINIT' ELSE 'INIT' END
    
    PRINT @SQL
    
    EXEC(@SQL)
    
    IF @@ERROR=0
    BEGIN
       PRINT '备份日志'
       INSERT INTO dbo.sys_BackupHistory(DBName,BackupFileName,BackupPath,BackupTime) VALUES
       (@DBNAME,@BKFNAME,@BKPATH+@BKFNAME,GETDATE())
    END
END
go

--=================================================================================================================--=================================================================================================================
USE [master]
GO

/****** Object:  StoredProcedure [dbo].[p_CreateJob]    Script Date: 10/24/2016 08:37:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[p_CreateJob]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[p_CreateJob]
GO

USE [master]
GO

/****** Object:  StoredProcedure [dbo].[p_CreateJob]    Script Date: 10/24/2016 08:37:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[p_CreateJob]
@jobname varchar(100), --作业名称
@sql varchar(8000), --要执行的命令
@dbname sysname='', --默认为当前的数据库名
@freqtype varchar(6)='day', --时间周期,month 月,week 周,day 日
@fsinterval int=1, --相对于每日的重复次数
@time int=170000 --开始执行时间,对于重复执行的作业,将从0点到23:59分
as
if isnull(@dbname,'')='' set @dbname=db_name()

--创建作业
exec msdb..sp_add_job @job_name=@jobname

--创建作业步骤
exec msdb..sp_add_jobstep @job_name=@jobname,
@step_name = '数据处理',
@subsystem = 'TSQL',
@database_name=@dbname,
@command = @sql,
@retry_attempts = 5, --重试次数
@retry_interval = 5 --重试间隔

--创建调度
declare @ftype int,@fstype int,@ffactor int
select @ftype=case @freqtype when 'day' then 4
when 'week' then 8
when 'month' then 16 end
,@fstype=case @fsinterval when 1 then 0 else 8 end
if @fsinterval<>1 set @time=0
set @ffactor=case @freqtype when 'day' then 0 else 1 end

EXEC msdb..sp_add_jobschedule @job_name=@jobname,
@name = '时间安排',
@freq_type=@ftype , --每天,8 每周,16 每月
@freq_interval=1, --重复执行次数
@freq_subday_type=@fstype, --是否重复执行
@freq_subday_interval=@fsinterval, --重复周期
@freq_recurrence_factor=@ffactor,
@active_start_time=@time --下午17:00:00分执行


GO
--=================================================================================================================--=================================================================================================================
USE [master]
GO

/****** Object:  StoredProcedure [dbo].[p_RestoreDB]    Script Date: 10/24/2016 08:39:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[p_RestoreDB]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[p_RestoreDB]
GO

USE [master]
GO

/****** Object:  StoredProcedure [dbo].[p_RestoreDB]    Script Date: 10/24/2016 08:39:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[p_RestoreDB]
    @BKFILE NVARCHAR(1000),   --定义要恢复的备份文件名
    @DBNAME SYSNAME,          --定义恢复后的数据库名,默认为备份的文件名
    @RETYPE NVARCHAR(10)='DB',--恢复类型:'DB'完整恢复数据库,'DBNOR' 为差异恢复,日志恢复进行完整恢复,'DF' 差异备份的恢复,'LOG' 日志恢复
    @FILENUMBER INT=1,        --恢复的文件号
    @OVEREXIST BIT=1          --是否覆盖已经存在的数据库,仅@RETYPE为 
AS
BEGIN
    DECLARE @SQL VARCHAR(8000)
    --得到恢复后的数据库名
    IF ISNULL(@DBNAME,'')=''
       SELECT @SQL=REVERSE(@BKFILE)
       ,@SQL=CASE WHEN CHARINDEX('.',@SQL)=0 THEN @SQL
       ELSE SUBSTRING(@SQL,CHARINDEX('.',@SQL)+1,1000) END
       ,@SQL=CASE WHEN CHARINDEX('\',@SQL)=0 THEN @SQL
       ELSE LEFT(@SQL,CHARINDEX('\',@SQL)-1) END
       ,@DBNAME=REVERSE(@SQL)
    --生成数据库恢复语句
    SET @SQL='RESTORE '+CASE @RETYPE WHEN 'LOG' THEN 'LOG ' ELSE 'DATABASE ' END
       +'['+@DBNAME+']'
       +' FROM DISK='''+@BKFILE+''''
       +' WITH FILE='+CAST(@FILENUMBER AS VARCHAR)
       +CASE WHEN @OVEREXIST=1 AND @RETYPE IN('DB','DBNOR') THEN ',REPLACE' ELSE '' END
       +CASE @RETYPE WHEN 'DBNOR' THEN ',NORECOVERY' ELSE ',RECOVERY' END
    --设当前数据库离线状态
    EXEC('ALTER DATABASE ['+@DBNAME+'] SET OFFLINE WITH ROLLBACK IMMEDIATE') 
    --恢复数据库
    EXEC(@SQL)
    --设当前数据库连线状态
    EXEC('ALTER DATABASE ['+@DBNAME+'] SET ONLINE')
END

GO

--=================================================================================================================
--=================================================================================================================


USE [master]
GO

/****** Object:  UserDefinedFunction [dbo].[f_splitSTR]    Script Date: 10/24/2016 08:39:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[f_splitSTR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[f_splitSTR]
GO

USE [master]
GO

/****** Object:  UserDefinedFunction [dbo].[f_splitSTR]    Script Date: 10/24/2016 08:39:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--方法1：循环截取法
CREATE FUNCTION [dbo].[f_splitSTR](
@s   varchar(8000),   --待分拆的字符串
@split varchar(10)     --数据分隔符
)RETURNS @re TABLE(col varchar(100))
AS
BEGIN
 DECLARE @splitlen int
 SET @splitlen=LEN(@split+'a')-2
 WHILE CHARINDEX(@split,@s)>0
 BEGIN
  INSERT @re VALUES(LEFT(@s,CHARINDEX(@split,@s)-1))
  SET @s=STUFF(@s,1,CHARINDEX(@split,@s)+@splitlen,'')
 END
 INSERT @re VALUES(@s)
 RETURN
END

GO

--================================================================================================================
--================================================================================================================
USE [master]
GO

/****** Object:  UserDefinedFunction [dbo].[f_getdbpath]    Script Date: 10/24/2016 08:42:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[f_getdbpath]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[f_getdbpath]
GO

USE [master]
GO

/****** Object:  UserDefinedFunction [dbo].[f_getdbpath]    Script Date: 10/24/2016 08:42:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create function [dbo].[f_getdbpath](@dbname sysname)
returns nvarchar(260)
as
begin
declare @re nvarchar(260)
---数据库名称为空或者系统不存在此数据库的名称
if @dbname is null or db_id(@dbname) is null
	--select rtrim(reverse(filename)) from master..sysdatabases where name='master'
	select @re=rtrim(reverse(filename)) from master..sysdatabases where name='master'
else
	select @re=rtrim(reverse(filename)) from master..sysdatabases where name=@dbname
---
if @dbname is null
	set @re=reverse(substring(@re,charindex('\',@re)+5,260))+'BACKUP'
else
	set @re=reverse(substring(@re,charindex('\',@re),260))
return(@re)
end

GO

















