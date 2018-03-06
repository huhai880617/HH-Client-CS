﻿using System;
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
 *   程序说明: Product的数据访问层
 *   作者姓名: Your Name
 *   创建日期: 2011-03-27 04:04:54
 *   最后修改: 2011-03-27 04:04:54
 *   
 *   注: 本代码由ClassGenerator自动生成
 *==========================================*/

namespace HHMES.Server.DataAccess.DAL_DataDict
{
    /// <summary>
    /// Product的数据访问层
    /// </summary>
    [DefaultORM_UpdateMode(typeof(tb_WMS_Material), true)]
    public class dalWMS_Material : dalBaseDataDict, IBridge_Material
    {
        public dalWMS_Material(Loginer loginer)
            : base(loginer)
        {
            _KeyName = tb_WMS_Material.__KeyName; //主键字段
            _TableName = tb_WMS_Material.__TableName;//表名
            _ModelType = typeof(tb_WMS_Material);
        }


        protected override IGenerateSqlCommand CreateSqlGenerator(string tableName)
        {
            Type ORM = null;

            if (tableName == tb_WMS_Material.__TableName) ORM = typeof(tb_WMS_Material);

            if (ORM == null) throw new Exception(tableName + "表没有ORM模型！");

            return new GenerateSqlCmdByTableFields(ORM);
        }

        public DataTable FuzzySearch(string content)
        {
            if (content.ToLower().Contains("like"))
            {
                string sql = ("select * from WMS_Material where 1=1 ");
                if (content != "")
                {
                    sql += content;
                }
                return DataProvider.Instance.GetTable(_Loginer.DBName, sql, _TableName);

            }
            else
            {
                SqlProcedure sp = SqlBuilder.BuildSqlProcedure("sp_FuzzySearchProduct");
                sp.AddParam("@Content", SqlDbType.NVarChar, content);
                return DataProvider.Instance.GetTable(_Loginer.DBName, sp.SqlCommand, tb_WMS_Material.__TableName);
            }
            
        }
    }
}
