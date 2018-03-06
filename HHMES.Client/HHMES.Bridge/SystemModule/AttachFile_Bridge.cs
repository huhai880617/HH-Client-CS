using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HHMES.Interfaces.Interfaces_Bridge;
using HHMES.Core;
using HHMES.Common;
using System.Data;
using System.ServiceModel;
using HHMES.WebServiceReference;
using HHMES.Server.DataAccess.DAL_System;
using HHMES.WebServiceReference.WCF_CommonService;

namespace HHMES.Bridge.SystemModule
{
    public class ADODirect_AttachFile
    {
        private IBridge_AttachFile _DAL_Instance = null;//数据层实例

        public ADODirect_AttachFile()
        {
            _DAL_Instance = new dalAttachFile(Loginer.CurrentUser);
        }

        public IBridge_AttachFile GetInstance()
        {
            return _DAL_Instance;
        }
    }

    public class WebService_AttachFile : IBridge_AttachFile
    {
        public WebService_AttachFile()
        {
        }

        #region IBridge_AttachFile Members

        public System.Data.DataTable GetData(string docID)
        {
            using (CommonServiceClient client = SoapClientFactory.CreateCommonServiceClient())
            {
                byte[] loginTicket = WebServiceSecurity.EncryptLoginer(Loginer.CurrentUser);
                byte[] receivedData = client.GetAttachedFiles(loginTicket, docID);
                return ZipTools.DecompressionDataSet(receivedData).Tables[0];
            }
        }

        #endregion
    }
}
