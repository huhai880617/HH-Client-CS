using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using HHMES.Models;
using HHMES.Common;
using HHMES.ORM;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.Interfaces;
using HHMES.Server.DataAccess.DAL_Base;

/*==========================================
 *   程序说明: WMS_BillDtl的数据访问层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-21 10:18:42
 *   最后修改: 2016-10-21 10:18:42
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Server.DataAccess
{
    /// <summary>
    /// dalWMS_BillDtl
    /// </summary>
    public class dalWMS_BillDtl : dalBaseBusiness
    {
         /// <summary>
         /// 构造器
         /// </summary>
         /// <param name="loginer">当前登录用户</param>
         public dalWMS_BillDtl(Loginer loginer): base(loginer)
         {
             _SummaryKeyName = tb_WMS_BillDtl.__KeyName; //主表的主键字段
             _SummaryTableName = tb_WMS_BillDtl.__TableName;//主表表名
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
             if (tableName == tb_WMS_BillDtl.__TableName) ORM = typeof(tb_WMS_BillDtl);
             //if (tableName == tb_WMS_BillDtls.__TableName) ORM = typeof(tb_WMS_BillDtls);
             if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");
             return new GenerateSqlCmdByTableFields(ORM);
         }

          /// <summary>
          /// 查询功能，获取主表数据
          /// </summary>
          public DataTable GetSummaryByParam(string docNoFrom, string docNoTo, DateTime docDateFrom, DateTime docDateTo)
          {
              StringBuilder sql = new StringBuilder();
              //
              //在这里生成SQL
              //
              if (sql.ToString() != "") //有查询条件
              {
                  string query = "select * from " + _SummaryTableName + " where 1=1 " + sql.ToString();
                  SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(query);
                  DataTable dt = DataProvider.Instance.GetTable(_Loginer.DBName,cmd.SqlCommand, tb_WMS_BillDtl.__TableName);
                  return dt;
              }
              else //无查询条件不返回数据
              {
                  throw new Exception("没有指定查询条件!");
                  return null;
              }
          }

          /// <summary>
          /// 获取一张业务单据的数据
          /// </summary>
          /// <param name="docNo">单据号码</param>
          /// <returns></returns>
          public System.Data.DataSet GetBusinessByKey(string docNo)
          {
              string sql1 = " select * from [tb_WMS_BillDtl]    where ["+tb_WMS_BillDtl.__KeyName+"]=@DocNo1 ";
              string sql2 = " select * from [vw_WMS_BillDtls]   where ["+tb_WMS_BillDtl.__KeyName+"]=@DocNo2 ORDER BY Queue "; //明细表排序
              SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql1 + sql2);
              cmd.AddParam("@DocNo1", SqlDbType.VarChar, docNo.Trim());
              cmd.AddParam("@DocNo2", SqlDbType.VarChar, docNo.Trim());
              DataSet ds = DataProvider.Instance.GetDataSet(_Loginer.DBName,cmd.SqlCommand);
              ds.Tables[0].TableName = tb_WMS_BillDtl.__TableName;
              //ds.Tables[1].TableName =tb_WMS_BillDtls.__TableName;//明细表
              return ds;
          }

          /// <summary>
          ///删除一张单据:只删除明细,主表金额清零!!!
          /// </summary>
          public bool Delete(string docNo)
          {
              //删除单据:只删除明细,主表金额清零!!!
              string sql1 = "UPDATE [tb_WMS_BillDtl] SET Amount=0 where ["+tb_WMS_BillDtl.__KeyName+"]=@DocNo1 ";
              string sql2 = "delete [tb_WMS_BillDtl] where ["+tb_WMS_BillDtl.__KeyName+"]=@DocNo2 ";
              SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql1 + sql2);
              cmd.AddParam("@DocNo1", SqlDbType.VarChar, docNo.Trim());
              cmd.AddParam("@DocNo2", SqlDbType.VarChar, docNo.Trim());
              int i = DataProvider.Instance.ExecuteNoQuery(_Loginer.DBName,cmd.SqlCommand);
              return i != 0;
          }

          /// <summary>
          //保存数据
          /// </summary>
          public SaveResult Update(DataSet data, bool createBusinessLog)
          {
              //其它处理...
              //调用基类的方法保存数据
              return base.Update(data);
          }

          /// <summary>
          //获取单据流水号码
          /// </summary>
          protected override string GetNumber(SqlTransaction tran)
          {
              string docNo = DocNoTool.GetNumber(tran, "WMS_BillDtl");
              return docNo;
          }

          /// <summary>
          /// 创建业务单据的版本历史记录
          /// </summary>
          /// <param name="key">单据号码</param>
          /// <param name="account">当前用户</param>
          /// <param name="newVerNo">返回新的版本号</param>
          public void CreateBusinessLog(string key, string account, out string newVerNo)
          {
              string sql = "sp_Log_WMS_BillDtl'" + key + "','" + account + "'";
              SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql);
              object o = DataProvider.Instance.ExecuteScalar(_Loginer.DBName,cmd.SqlCommand);
              newVerNo = ConvertEx.ToString(o);
          }

          /// <summary>
          /// 获取指定版本号的历史记录
          /// </summary>
          /// <param name="docNo">单据号码</param>
          /// <param name="verNo">版本号</param>
          /// <returns></returns>
          public DataSet GetBusinessLog(string docNo, string verNo)
          {
              return null;
          }

          /// <summary>
          /// 获取单据的版本历史记录
          /// </summary>
          /// <param name="docNo">单据号码</param>
          /// <returns></returns>
          public DataSet GetBusinessLog(string docNo)
          {
              return null;
          }

          /// <summary>
          /// 获取报表数据
          /// </summary>
          /// <returns></returns>
          public DataSet GetReportData(string DocNoFrom, string DocNoTo, DateTime DateFrom, DateTime DateTo)
          {
              return null;
          }

     }
}

