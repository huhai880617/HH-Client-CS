using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HHMES.Interfaces.Interfaces_Bridge;
using System.Data;
using HHMES.Core;
using HHMES.Common;
using System.ServiceModel;
using HHMES.WebServiceReference;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.Server.DataAccess.DAL_Base;
using HHMES.WebServiceReference.WCF_CommonService;

namespace HHMES.Bridge.SystemModule
{
    public class ADODirect_Log
    {
        private IBridge_EditLogHistory _DAL_Instance = null;//数据层实例

        public ADODirect_Log()
        {
            _DAL_Instance = new dalEditLogHistory(Loginer.CurrentUser);
        }

        public IBridge_EditLogHistory GetInstance()
        {
            return _DAL_Instance;
        }
    }


    public class WebService_Log : IBridge_EditLogHistory
    {
        public WebService_Log()
        {
        }

        #region IBridge_SystemLog Members

        public void WriteLog(string logID, DataTable originalData, DataTable changes, string tableName, string keyFieldName, bool isMaster)
        {
            using (CommonServiceClient client = SoapClientFactory.CreateCommonServiceClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] bsOriginal = ZipTools.CompressionDataSet(dalBase.TableToDataSet(originalData));
                byte[] bsChanges = ZipTools.CompressionDataSet(dalBase.TableToDataSet(changes));

                client.WriteLog(loginTicket, logID, bsOriginal, bsChanges, tableName, keyFieldName, isMaster);
            }
        }

        public DataSet SearchLog(string logUser, string tableName, DateTime dateFrom, DateTime dateTo)
        {
            using (CommonServiceClient client = SoapClientFactory.CreateCommonServiceClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.SearchLog(loginTicket, logUser, tableName, dateFrom, dateTo);
                return ZipTools.DecompressionDataSet(receivedData);
            }
        }

        public DataTable GetLogFieldDef(string tableName)
        {
            using (CommonServiceClient client = SoapClientFactory.CreateCommonServiceClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.GetLogFieldDef(loginTicket, tableName);
                return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            }
        }

        public string[] GetTracedFields(string tableName)
        {
            using (CommonServiceClient client = SoapClientFactory.CreateCommonServiceClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                string[] arr = client.GetTracedFields(loginTicket, tableName);
                return arr;
            }
        }

        public bool SaveFieldDef(DataTable data)
        {
            using (CommonServiceClient client = SoapClientFactory.CreateCommonServiceClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] bsData = ZipTools.CompressionDataSet(dalBase.TableToDataSet(data));
                return client.SaveFieldDef(loginTicket, bsData);
            }
        }

        #endregion
    }
}
