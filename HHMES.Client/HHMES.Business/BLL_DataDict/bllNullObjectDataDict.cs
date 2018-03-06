using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Business.BLL_Base;


namespace HHMES.Business
{
    /// <summary>
    /// 数据字典的空业务逻辑类．仅用于初始化实例．
    /// </summary>
    public class bllNullObjectDataDict : bllBaseDataDict
    {
        public override bool CheckNoExists(string keyValue)
        {
            return false;
        }

        public override void CreateDataBinder(System.Data.DataRow sourceRow)
        {
            //
        }

        public override bool Delete(string keyValue)
        {
            return true;
        }

        public override System.Data.DataTable GetDataByKey(string keyValue)
        {
            return new DataTable();
        }

        public override DataTable GetSummaryData(bool resetCurrent)
        {
            return new DataTable();
        }

        public override bool Update(HHMES.Common.UpdateType updateType)
        {
            return true;
        }
    }
}
