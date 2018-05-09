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
 *   程序说明: Customer的数据访问层
 *   作者姓名: Your Name
 *   创建日期: 2011-03-24 03:12:50
 *   最后修改: 2011-03-24 03:12:50
 *   
 *   注: 本代码由ClassGenerator自动生成
 *==========================================*/

namespace HHMES.Server.DataAccess.DAL_DataDict
{
    /// <summary>
    /// Customer的数据访问层
    /// </summary>
    [DefaultORM_UpdateMode(typeof(tb_SUPPLIERCUSTOMER), true)]
    public class dalSUPPLIERCUSTOMER : dalBaseDataDict, IBridge_SUPPLIERCUSTOMER
    {
        public dalSUPPLIERCUSTOMER(Loginer loginer)
            : base(loginer)
        {
            _KeyName = tb_SUPPLIERCUSTOMER.__KeyName; //主键字段
            _TableName = tb_SUPPLIERCUSTOMER.__TableName;//表名
            _ModelType = typeof(tb_SUPPLIERCUSTOMER);
        }

        protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
        {
            Type ORM = null;

            if (tableName == tb_SUPPLIERCUSTOMER.__TableName) ORM = typeof(tb_SUPPLIERCUSTOMER);

            if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");

            return new GenerateSqlCmdByTableFields(ORM);
        }


        public DataTable SearchBy(string code,  string Name, string type_CFG)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM [SUPPLIERCUSTOMER] WHERE ISDELETED=0 ");

            if (String.IsNullOrEmpty(code) == false)
                sb.Append(" AND CODE ='" + code + "'");
           

            if (String.IsNullOrEmpty(Name) == false)
                sb.Append(" AND Name LIKE '%" + Name + "%'");

            if (String.IsNullOrEmpty(type_CFG) == false)
                sb.Append(" AND type_CFG=" + type_CFG );

            sb.Append(" ORDER BY CODE ");

            SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sb.ToString());
            return DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_SUPPLIERCUSTOMER.__TableName);

        }

        public DataTable GetSUPPLIERCUSTOMERByAttributeCodes(string attributeCodes, bool nameWithCode)
        {
            SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_GetCustomerByAttributeCodes");
            sp.AddParam("@AttributeCodes", SqlDbType.VarChar, attributeCodes);
            sp.AddParam("@NameWithCode", SqlDbType.VarChar, nameWithCode ? "Y" : "N");
            return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, "tb_SUPPLIERCUSTOMER");
        }

        public DataTable FuzzySearch(string content)
        {
            SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_FuzzySearchCustomer");
            sp.AddParam("@Content", SqlDbType.VarChar, content);
            sp.AddParam("@AttributeCodes", SqlDbType.VarChar, "");
            return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_SUPPLIERCUSTOMER.__TableName);
        }

        public DataTable FuzzySearch(string attributeCodes, string content)
        {
            SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_FuzzySearchCustomer");
            sp.AddParam("@Content", SqlDbType.VarChar, content);
            sp.AddParam("@AttributeCodes", SqlDbType.VarChar, attributeCodes);
            return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_SUPPLIERCUSTOMER.__TableName);
        }
    }
}
