using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;

using HHMES.Bridge;
using HHMES.Interfaces;
using HHMES.Business.BLL_Base;
using HHMES.Bridge.DataDictModule;

namespace HHMES.Business
{
    /// <summary>
    /// 客户资料管理业务逻辑层
    /// </summary>
    public class bllSUPPLIERCUSTOMER : bllBaseDataDict
    {
        private IBridge_SUPPLIERCUSTOMER _MyBridge; //桥接/策略接口

        public bllSUPPLIERCUSTOMER()
        {
            _KeyFieldName = tb_SUPPLIERCUSTOMER.__KeyName; //主键字段
            _SummaryTableName = tb_SUPPLIERCUSTOMER.__TableName;//表名
            _WriteDataLog = true;//是否保存日志
            _DataDictBridge = BridgeFactory.CreateDataDictBridge(typeof(tb_SUPPLIERCUSTOMER));
            _MyBridge = this.CreateBridge();
        }

        /// <summary>
        /// 创建桥接通信通道
        /// </summary>
        /// <returns></returns>
        private IBridge_SUPPLIERCUSTOMER CreateBridge()
        {
            if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                return new ADODirect_SUPPLIERCUSTOMER().GetInstance();

            if (BridgeFactory.BridgeType == BridgeType.WebService)
                return new WebService_SUPPLIERCUSTOMER();

            return null;
        }

        public DataTable SearchBy(string code, string Name,
            string Attribute, bool resetCurrent)
        {
            DataTable data = _MyBridge.SearchBy(code,  Name, Attribute);
            if (resetCurrent) _SummaryTable = data;
            this.SetDefault(_SummaryTable);
            return data;
        }

        public DataTable GetSUPPLIERCUSTOMERByAttributeCodes(string attributeCodes, bool nameWithCode)
        {
            return _MyBridge.GetSUPPLIERCUSTOMERByAttributeCodes(attributeCodes, nameWithCode);
        }

        public DataTable FuzzySearch(string content)
        {
            return _MyBridge.FuzzySearch(content);
        }

        public DataTable FuzzySearch(string attributeCodes, string content)
        {
            return _MyBridge.FuzzySearch(attributeCodes, content);
        }
    }
}
