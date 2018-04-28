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
    public class bllITEM : bllBaseDataDict
    {
        private IBridge_ITEM _MyBridge = null;

        public bllITEM()
        {
            _KeyFieldName = tb_ITEM.__KeyName; //主键字段
            _SummaryTableName = tb_ITEM.__TableName;//表名
            _WriteDataLog = true;//是否保存日志
            _DataDictBridge = BridgeFactory.CreateDataDictBridge(typeof(tb_ITEM));
            _MyBridge = this.CreateBridge();
        }

        private IBridge_ITEM CreateBridge()
        {
            if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                return new ADODirect_ITEM().GetInstance();

            if (BridgeFactory.BridgeType == BridgeType.WebService)
                return new WebService_ITEM();

            return null;
        }

        public DataTable FuzzySearch(string content)
        {
            return _MyBridge.FuzzySearch(content);
        }
    }
}
