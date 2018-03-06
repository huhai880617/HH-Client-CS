using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;
using HHMES.Interfaces;
using HHMES.Core.Log;
using HHMES.Core;

using HHMES.Bridge;
using HHMES.Business.BLL_Base;


namespace HHMES.Business
{
    public class bllPerson : bllBaseDataDict
    {
        public bllPerson()
        {
            _KeyFieldName = tb_Person.__KeyName; //主键字段
            _SummaryTableName = tb_Person.__TableName;//表名
            _WriteDataLog = true;//是否保存日志

            //方式一：由ORM自动查询DAL类
            _DataDictBridge = BridgeFactory.CreateDataDictBridge(typeof(tb_Person));
        }
    }
}
