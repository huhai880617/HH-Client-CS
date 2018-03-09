using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Net;
using HHMES.Models;
using HHMES.Common;
using HHMES.ORM;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.Interfaces;
using HHMES.Server.DataAccess.DAL_Base;

/*==========================================
 *   程序说明: WMS_Task的数据访问层
 *   作者姓名: HHMES.com
 *   创建日期: 2016/12/19 09:23:48
 *   最后修改: 2016/12/19 09:23:48
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Server.DataAccess
{
    /// <summary>
    /// dalWMS_Task
    /// </summary>
    public class dalWMS_Task : dalBaseBusiness,IBridge_WMS_Task
    {

        
         /// <summary>
         /// 构造器
         /// </summary>
         /// <param name="loginer">当前登录用户</param>
         public dalWMS_Task(Loginer loginer): base(loginer)
         {
             _SummaryKeyName = tb_WMS_Task.__KeyName; //主表的主键字段
             _SummaryTableName = tb_WMS_Task.__TableName;//主表表名
             _UpdateSummaryKeyMode = UpdateKeyMode.OnlyDocumentNo;//单据号码生成模式
         }

         /// <summary>
         /// 根据表名获取该表的ＳＱＬ命令生成器
         /// </summary>
         /// <param name="tableName">表名</param>
         /// <returns></returns>
         protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
         {
             Type ORM = null;
             if (tableName == tb_WMS_BillIn.__TableName) ORM = typeof(tb_WMS_BillIn);
             if (tableName == tb_WMS_BillInDtl.__TableName) ORM = typeof(tb_WMS_BillInDtl);
             if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");
             return new GenerateSqlCmdByTableFields(ORM);
         }
         /// <summary>
         /// 查询功能，获取主表数据
         /// </summary>
         public DataTable GetSummaryByParam(string Condition)
         {
             StringBuilder sql = new StringBuilder();
             //
             sql = sql.Append(Condition);
             //
             if (sql.ToString() != "") //有查询条件
             {
                 string query = "select * from " + _SummaryTableName + " where 1=1 " + sql.ToString();
                 SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(query);
                 DataTable dt = DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_WMS_BillIn.__TableName);
                 return dt;
             }
             else //无查询条件不返回数据
             {
                 throw new Exception("没有指定查询条件!");
                 //return null;
             }
         }

         /// <summary>
         /// 获取一张业务单据的数据
         /// </summary>
         /// <param name="docNo">单据号码</param>
         /// <returns></returns>
         public System.Data.DataSet GetBusinessByKey(string docNo)
         {
             string sql1 = " select * from [WMS_Task]    where [" + tb_WMS_Task.__KeyName + "]=@DocNo1 ;";
             string sql2 = " select * from [WMS_TaskDtl]   where [" + tb_WMS_Task.__KeyName + "]=@DocNo2 ORDER BY ID "; //明细表排序
             SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql1 + sql2);
             cmd.AddParam("@DocNo1", SqlDbType.VarChar, docNo.Trim());
             cmd.AddParam("@DocNo2", SqlDbType.VarChar, docNo.Trim());
             DataSet ds = DataProvider.Instance.GetDataSet(_Loginer.DBName, cmd.SqlCommand);
             ds.Tables[0].TableName = tb_WMS_Task.__TableName;
             ds.Tables[1].TableName = tb_WMS_TaskDtl.__TableName;//明细表
             return ds;
         }

         public DataTable ExecuteSQL(string execSql)
         {
             string sql = execSql;
             SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql);
             return DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_WMS_Task.__TableName);
         }

         public DataTable GetTask(string conditional)
         {
             string sql = "select * from "+tb_WMS_Task.__TableName + " Where 1=1 And " + conditional;
             SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql);
             return DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_WMS_Task.__TableName);
         }


         public DataTable GetTaskDtlByTaskId(int TaskId) 
         {
             string sql = "select * from " + tb_WMS_TaskDtl.__TableName + " where  TaskDtl_TaskId= "+TaskId;
             SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql);
             return DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_WMS_TaskDtl.__TableName);
         }


         public DataTable TaskAssign(int TaskId)
         {
             SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_Assign");
             sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
             sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
             sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
             sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
             return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
         }

         public DataTable TaskCancel(int TaskId) 
         {
             SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_Cancel");
             sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
             sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
             sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
             sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
             return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
         }

         public DataTable TaskStatusModify(int TaskId, int StatusValue)
         {
             SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_StatusModify");
             sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
             sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
             sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
             sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
             sp.AddParam("@StatusValue", SqlDbType.Int, StatusValue);
             return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
         }

         public DataTable TaskStationModify(int TaskId, int Station)
         {
             SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_StationModify");
             sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
             sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
             sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
             sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
             sp.AddParam("@Station", SqlDbType.Int, Station);
             return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
         }

          public DataTable TaskPortNumModify(int TaskId, int PortNum)
         {
             SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_PortNumModify");
             sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
             sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
             sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
             sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
             sp.AddParam("@PortNum", SqlDbType.Int, PortNum);
             return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
         }

          public DataTable TaskPriorityModify(int TaskId, int First, int Second)
          {
              SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_PriorityModify");
              sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
              sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
              sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
              sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
              sp.AddParam("@First", SqlDbType.Int,First);
              sp.AddParam("@Sencond", SqlDbType.Int, Second);
              return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
          }

          public DataTable TaskAccountByManual(int TaskId)
          {
              SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_WCS_Task_AccountByManual");
              sp.AddParam("@IP", SqlDbType.NVarChar, Globals.DEF_ClientIP());
              sp.AddParam("@Client", SqlDbType.NVarChar, Globals.DEF_ClientName());
              sp.AddParam("@Loginer", SqlDbType.NVarChar, Loginer.CurrentUser.Account);
              sp.AddParam("@TaskId", SqlDbType.Int, TaskId);
              return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Task.__TableName);
          }

     }
}

