using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Common;
using HHMES.Models;
using HHMES.Server.DataAccess.DAL_Base;

namespace HHMES.Server.DataAccess.DAL_System
{
    /// <summary>
    /// 公司资料设置
    /// </summary>
    [DefaultORM_UpdateMode(typeof(tb_CompanyInfo),true)]
    public class dalCompanyInfo : dalBaseDataDict
    {
        public dalCompanyInfo(Loginer loginer)
            : base(loginer)
        {
            _TableName = tb_CompanyInfo.__TableName;
            _KeyName = tb_CompanyInfo.__KeyName;
            _ModelType = typeof(tb_CompanyInfo);
        }
    }
}
