using System;
using System.Collections.Generic;
using System.Text;
using HHMES.Models;
using System.Data;
using HHMES.ORM;
using HHMES.Common;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.Interfaces.Interfaces_Bridge;
using HHMES.Server.DataAccess.DAL_Base;

namespace HHMES.Server.DataAccess.DAL_System
{
    /// <summary>
    /// 附件管理数据层
    /// </summary>
    [DefaultORM_UpdateMode(typeof(tb_AttachFile), true)]
    public class dalAttachFile : dalBaseDataDict, IBridge_AttachFile
    {
        public dalAttachFile(Loginer loginer)
            : base(loginer)
        {
            _TableName = tb_AttachFile.__TableName;
            _KeyName = tb_AttachFile.__KeyName;
            _ModelType = typeof(tb_AttachFile);
        }

        /// <summary>
        /// 获取指定单据的附件数据
        /// </summary>
        /// <param name="docID">单据号码</param>
        /// <returns></returns>
        public DataTable GetData(string docID)
        {
            string sql = "select * from [tb_AttachFile] where [DocID]=@DocID";
            SqlCommandBase cmd = SqlBuilder.BuildSqlCommandBase(sql);
            cmd.AddParam("@docID", SqlDbType.VarChar, docID);
            DataTable dt = DataProvider.Instance.GetTable(_Loginer.DBName, cmd.SqlCommand, tb_AttachFile.__TableName);
            return dt;
        }
    }
}
