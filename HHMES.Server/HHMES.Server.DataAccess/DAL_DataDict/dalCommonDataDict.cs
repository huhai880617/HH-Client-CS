using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.ORM;
using HHMES.Interfaces;
using HHMES.Server.DataAccess.DAL_Base;

/*==========================================
 *   程序说明: CommonDataDict的数据访问层
 *   作者姓名: Your Name
 *   创建日期: 2011-03-24 03:12:50
 *   最后修改: 2011-03-24 03:12:50
 *   
 *   注: 本代码由ClassGenerator自动生成
 *==========================================*/

namespace HHMES.Server.DataAccess.DAL_DataDict
{

    /// <summary>
    /// 公共数据字典数据层
    /// </summary>
    [DefaultORM_UpdateMode(typeof(tb_CONFIG_DETAIL), true)]
    public class dalCommonDataDict : dalBaseDataDict, IBridge_CommonDataDict
    {
        public dalCommonDataDict(Loginer loginer)
            : base(loginer)
        {
            _KeyName = tb_CONFIG_DETAIL.__KeyName; //主键字段
            _TableName = tb_CONFIG_DETAIL.__TableName;//表名
            _ModelType = typeof(tb_CONFIG_DETAIL);//字典表ORM
        }

        protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
        {
            Type ORM = null;

            if (tableName == tb_CONFIG_DETAIL.__TableName) ORM = typeof(tb_CONFIG_DETAIL);

            if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");

            return new GenerateSqlCmdByTableFields(ORM);
        }

        ///// <summary>
        ///// 数据字典：手动控制事务及自动生成流水号
        ///// </summary>
        ///// <param name="data">用户提交的数据</param>
        ///// <returns></returns>
        //public override SaveResultEx UpdateEx(DataSet data)
        //{
        //    SaveResultEx result = new SaveResultEx((int)ResultID.SUCCESS, "");

        //    try
        //    {
        //        this.BeginTransaction();//启动事务

        //        DataTable summary = data.Tables[tb_CommonDataDict.__TableName];//取出主表数据
        //        string dataType = ConvertEx.ToString(summary.Rows[0][tb_CommonDataDict.DataType]);//取数据类型
        //        string dataCode = DocNoTool.GetDataSN(_CurrentTrans, dataType, true);//在同一事务内取流水号
        //        summary.Rows[0][tb_CommonDataDict.DataCode] = dataCode;

        //        result = base.UpdateEx(data);//提交数据
        //        result.PrimaryKey = dataCode;//返回自动生成的主键

        //        this.CommitTransaction();//提交事务
        //    }
        //    catch
        //    {
        //        this.RollbackTransaction();//回滚
        //    }

        //    return result;
        //}

        /// <summary>
        /// 搜索指定类型的数据
        /// </summary>
        /// <param name="DataType">数据类型</param>
        /// <returns></returns>
        public DataTable SearchBy(string DataType)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM CONFIG_DETAIL WHERE 1=1 ");

            if (DataType != "")
                sb.Append("AND ISDELETED=0 AND CONFIG_HEADERID =" + DataType);

            sb.Append(" ORDER BY [SEQUENCE] ");

            SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sb.ToString());
            return DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_CONFIG_DETAIL.__TableName);

        }

        /// <summary>
        /// 增加一项数据类型
        /// </summary>
        /// <param name="code">类型编号</param>
        /// <param name="name">类型名称</param>
        /// <returns></returns>
        public bool AddCommonType(string code, string name)
        {
            string sql = "INSERT INTO CONFIG_HEADER (CODE,NAME,WAREHOUSEID,SYSTEMCREATED,CREATEBY,CREATETIME,"
              +"MODIFYBY,MODIFYTIME,ISDELETED ) VALUES ('{0}','{1}',{2},1,'{3}',getdate(),'{4}',getdate(),0);";
            string execSql = string.Format(sql, code, name, Globals.DEF_WAREHOUSECODEID, Loginer.CurrentUser.Account, Loginer.CurrentUser.Account);
            int i = DataProvider.Instance.ExecuteNoQuery(_Loginer.DBName, execSql);
            return i > 0;
        }

        /// <summary>
        /// 删除数据类型
        /// </summary>
        /// <param name="code">数据类型编号</param>
        /// <returns></returns>
        public bool DeleteCommonType(string code)
        {
            string sql =string.Format( "UPDATE CONFIG_HEADER SET ISDELETED=1 WHERE CODE='{0}'; UPDATE CONFIG_DETAIL SET ISDELETED=1 WHERE CONFIG_HEADERID=(SELECT ID FROM CONFIG_HEADER WHERE CODE='{1}')",code,code);
            int i = DataProvider.Instance.ExecuteNoQuery(_Loginer.DBName, sql);
            return i > 0;
        }

        /// <summary>
        /// 检查数据类型是否存在
        /// </summary>
        /// <param CODE="CODE">数据类型编号</param>
        /// <returns></returns>
        public bool IsExistsCommonType(string CODE)
        {
            string sql =String.Format( "SELECT COUNT(*) C FROM CONFIG_HEADER WHERE CODE='{0}' AND ISDELETED=0",CODE);
            object o = DataProvider.Instance.ExecuteScalar(_Loginer.DBName, sql);
            return ConvertEx.ToInt(o) > 0;
        }

        
    }
}
