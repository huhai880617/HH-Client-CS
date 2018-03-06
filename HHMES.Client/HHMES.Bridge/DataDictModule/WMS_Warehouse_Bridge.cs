using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HHMES.Interfaces;
using System.Reflection;
using HHMES.Common;
using System.Data;
using HHMES.Core;
using System.ServiceModel;
using HHMES.WebServiceReference;
using HHMES.Server.DataAccess.DAL_DataDict;
using HHMES.WebServiceReference.WCF_DataDictService;
using HHMES.Server.DataAccess;

namespace HHMES.Bridge.DataDictModule
{
    public class ADODirect_WMS_Warehouse
    {
        private IBridge_WMS_Warehouse _DAL_Instance = null;//数据层实例

        public ADODirect_WMS_Warehouse()
        {
            _DAL_Instance = new dalWMS_Warehouse(Loginer.CurrentUser);
        }

        public IBridge_WMS_Warehouse GetInstance()
        {
            return _DAL_Instance;
        }
    }

    public class WebService_WMS_Warehouse : IBridge_WMS_Warehouse
    {
        public WebService_WMS_Warehouse()
        {
        }

        #region IBridge_WMS_Warehouse 成员

        public DataTable FuzzySearch(string content)
        {
            using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.FuzzySearchProduct(loginTicket, content);
                return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            }
        }

        #endregion
    }

}
