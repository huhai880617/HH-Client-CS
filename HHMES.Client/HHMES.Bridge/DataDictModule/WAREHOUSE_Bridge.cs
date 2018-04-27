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
    public class ADODirect_WAREHOUSE
    {
        private IBridge_WAREHOUSE _DAL_Instance = null;//数据层实例

        public ADODirect_WAREHOUSE()
        {
            _DAL_Instance = new dalWAREHOUSE(Loginer.CurrentUser);
        }

        public IBridge_WAREHOUSE GetInstance()
        {
            return _DAL_Instance;
        }
    }

    public class WebService_WAREHOUSE : IBridge_WAREHOUSE
    {
        public WebService_WAREHOUSE()
        {
        }

        #region IBridge_WAREHOUSE 成员

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
