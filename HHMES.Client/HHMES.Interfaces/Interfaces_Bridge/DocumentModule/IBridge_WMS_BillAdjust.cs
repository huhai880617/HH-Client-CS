using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HHMES.Common;
using HHMES.Core;
using HHMES.Interfaces;

namespace HHMES.Interfaces.Interfaces_Bridge
{
    public interface IBridge_WMS_BillAdjust
    {

        DataSet GetBusinessByKey(string keyValue);
       
        DataTable GetSummaryByParam(string Condition);

        SaveResult Update(System.Data.DataSet saveData);

        bool Delete(string keyValue);
        bool CheckNoExists(string keyValue);
        void ApprovalBusiness(string keyValue, string flagApp, string appUser, DateTime appDate);

    }
}
