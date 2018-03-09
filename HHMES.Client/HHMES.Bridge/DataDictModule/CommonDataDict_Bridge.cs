using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HHMES.Interfaces;
using HHMES.Core;
using HHMES.Common;
using System.ServiceModel;
using System.Data;
using HHMES.WebServiceReference;
using HHMES.Server.DataAccess.DAL_DataDict;
using HHMES.WebServiceReference.WCF_DataDictService;

namespace HHMES.Bridge.DataDictModule
{
    public class ADODirect_CommonDataDict
    {
        private IBridge_CommonDataDict _DAL_Instance = null;//数据层实例

        public ADODirect_CommonDataDict()
        {
            _DAL_Instance = new dalCommonDataDict(Loginer.CurrentUser);
        }

        public IBridge_CommonDataDict GetInstance()
        {
            return _DAL_Instance;
        }
    }

    //public class WebService_CommonDataDict : IBridge_CommonDataDict
    //{

    //    public WebService_CommonDataDict()
    //    {

    //    }

    //    //#region IBridge_CommonDataDict Members

    //    //public System.Data.DataTable SearchBy(string dataType)
    //    //{
    //    //    using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
    //    //    {
    //    //        byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
    //    //        byte[] receivedData = client.SearchCommonType(loginTicket, dataType);
    //    //        return ZipTools.DecompressionDataSet(receivedData).Tables[0];
    //    //    }
    //    //}

    //    //public bool AddCommonType(string code, string name)
    //    //{
    //    //    using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
    //    //    {
    //    //        byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
    //    //        return client.AddCommonType(loginTicket, code, name);
    //    //    }
    //    //}

    //    //public bool DeleteCommonType(string code)
    //    //{
    //    //    using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
    //    //    {
    //    //        byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
    //    //        return client.DeleteCommonType(loginTicket, code);
    //    //    }
    //    //}

    //    //public bool IsExistsCommonType(string code)
    //    //{
    //    //    using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
    //    //    {
    //    //        byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
    //    //        return client.IsExistsCommonType(loginTicket, code);
    //    //    }
    //    //}

    //    //#endregion
    //}
}
