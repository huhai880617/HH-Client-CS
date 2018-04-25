using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HHMES.Interfaces;
using HHMES.Core;
using HHMES.Common;
using System.Data;
using System.ServiceModel;
using HHMES.WebServiceReference;
using HHMES.Server.DataAccess.DAL_DataDict;
using HHMES.WebServiceReference.WCF_DataDictService;

namespace HHMES.Bridge.DataDictModule
{
    /// <summary>
    /// 客户管理的ADO Direct桥接功能
    /// </summary>
    public class ADODirect_Customer
    {
        //数据层实例,实现桥接口IBridge_Customer
        private IBridge_Customer _DAL_Instance = null;

        //构造器
        public ADODirect_Customer()
        {
            _DAL_Instance = new dalCustomer(Loginer.CurrentUser);
        }

        //获取桥接功能实例
        public IBridge_Customer GetInstance()
        {
            return _DAL_Instance;
        }
    }

    /// <summary>
    /// 客户管理WebService桥接功能
    /// </summary>
    public class WebService_Customer : IBridge_Customer
    {

        public WebService_Customer()
        {
        }

        #region IBridge_Customer 成员

        public DataTable SearchBy(string Code,  string Name, string type_Cfg)
        {
            //using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
            //{
            //    byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
            //    byte[] receivedData = client.FuzzySearchCustomer(loginTicket,Code,  Name, type_Cfg);
            //    return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            //}
            return null;
        }

        public DataTable GetCustomerByAttributeCodes(string attributeCodes, bool nameWithCode)
        {
            using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.GetCustomerByAttributeCodes(loginTicket, attributeCodes, nameWithCode);
                return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            }
        }

        public DataTable FuzzySearch(string content)
        {
            using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.FuzzySearchCustomerByContent(loginTicket, content);
                return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            }
        }

        public DataTable FuzzySearch(string attributeCodes, string content)
        {
            using (DataDictServiceClient client = SoapClientFactory.CreateDataDictClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.FuzzySearchCustomerByAttributes(loginTicket, attributeCodes, content);
                return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            }
        }

        #endregion
    }
}
