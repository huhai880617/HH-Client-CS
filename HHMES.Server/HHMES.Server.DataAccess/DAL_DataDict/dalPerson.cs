using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.ORM;
using HHMES.Server.DataAccess.DAL_Base;

namespace HHMES.Server.DataAccess.DAL_DataDict
{
    /// <summary>
    /// Person的数据访问层
    /// </summary>
    [DefaultORM_UpdateMode(typeof(tb_Person), true)]
    public class dalPerson : dalBaseDataDict
    {
        public dalPerson(Loginer loginer)
            : base(loginer)
        {
            _KeyName = tb_Person.__KeyName; //主键字段
            _TableName = tb_Person.__TableName;//表名
            _ModelType = typeof(tb_Person);
        }

        protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
        {
            Type ORM = null;
            if (tableName == tb_Person.__TableName) ORM = typeof(tb_Person);
            if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");
            //return new GenerateSqlCmdByTableFields(ORM);
            return new GenerateSqlCmdByObjectClass(ORM);
        }

    }
}
