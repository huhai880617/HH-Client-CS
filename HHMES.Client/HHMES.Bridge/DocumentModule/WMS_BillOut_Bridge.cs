using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using HHMES.Interfaces;
using HHMES.Core;
using HHMES.Common;
using HHMES.WebServiceReference;
using HHMES.Server.DataAccess;
using HHMES.Interfaces.Interfaces_Bridge;

namespace HHMES.Bridge
{
    /// <summary>
    /// DAL层桥接功能
    /// </summary>
    public class ADODirect_WMS_BillOut
    {
        private IBridge_WMS_BillOut _DAL_Instance = null;//数据层实例

        public ADODirect_WMS_BillOut()
        {
            _DAL_Instance = new dalWMS_BillOut(Loginer.CurrentUser);
        }

        public IBridge_WMS_BillOut GetInstance()
        {
            return _DAL_Instance;
        }
    }



}
