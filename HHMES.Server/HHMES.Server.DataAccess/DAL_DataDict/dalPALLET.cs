using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HHMES.Models;
using HHMES.Common;
using HHMES.ORM;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.Interfaces;
using HHMES.Server.DataAccess.DAL_Base;

/*==========================================
 *   程序说明: PALLET的数据访问层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-09-29 03:02:44
 *   最后修改: 2016-09-29 03:02:44
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Server.DataAccess
{
    /// <summary>
    /// dalPALLET
    /// </summary>
    public class dalPALLET : dalBaseDataDict, IBridge_PALLET
    {
         /// <summary>
         /// 构造器
         /// </summary>
         /// <param name="loginer">当前登录用户</param>
         public dalPALLET(Loginer loginer): base(loginer)
         {
             _KeyName = tb_PALLET.__KeyName; //主键字段
             _TableName = tb_PALLET.__TableName;//表名
             _ModelType = typeof(tb_PALLET);
         }

         /// <summary>
         /// 根据表名获取该表的SQL命令生成器
         /// </summary>
         /// <param name="tableName">表名</param>
         /// <returns></returns>
         protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
         {
           Type ORM = null;
           if (tableName == tb_PALLET.__TableName) ORM = typeof(tb_PALLET);
           if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");
           return new GenerateSqlCmdByTableFields(ORM);
         }

         public DataTable FuzzySearch(string content)
         {
             //SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_FuzzySearchProduct");
             //sp.AddParam("@Content", SqlDbType.NVarChar, content);
             //return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_Product.__TableName);
             string strSql = string.Format("select * from {0} where ISDELETED=0 ",this.TableName);
             if (content != "")
             {
                 strSql += content;
             }
             
             return DataProvider.Instance.GetTable(_Loginer.DBName,strSql,this.TableName);
         }
         
     }
}
