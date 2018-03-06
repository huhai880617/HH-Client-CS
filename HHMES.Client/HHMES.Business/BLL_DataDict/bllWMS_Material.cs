using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Common;
using HHMES.Models;

using HHMES.Bridge;
using HHMES.Interfaces;
using HHMES.Bridge.DataDictModule;
using HHMES.Business.BLL_Base;

namespace HHMES.Business
{
    public class bllWMS_Material : bllBaseDataDict
    {
        private IBridge_Material _MyBridge = null;

        public bllWMS_Material()
        {
            _KeyFieldName = tb_WMS_Material.__KeyName; //主键字段
            _SummaryTableName = tb_WMS_Material.__TableName;//表名
            _WriteDataLog = true;//是否保存日志
            _DataDictBridge = BridgeFactory.CreateDataDictBridge(typeof(tb_WMS_Material));
            _MyBridge = this.CreateBridge();
        }

        private IBridge_Material CreateBridge()
        {
            if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                return new ADODirect_Material().GetInstance();

            if (BridgeFactory.BridgeType == BridgeType.WebService)
                return new WebService_Material();

            return null;
        }

        public DataTable FuzzySearch(string content)
        {
            return _MyBridge.FuzzySearch(content);
        }
    }
}
