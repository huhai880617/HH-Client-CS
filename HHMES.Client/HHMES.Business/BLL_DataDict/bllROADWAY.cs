using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HHMES.Models;
using HHMES.Common;
using HHMES.Interfaces;
using HHMES.Core.Log;
using HHMES.Server.DataAccess;
using HHMES.Core;
using HHMES.Business.BLL_Base;
using HHMES.Bridge;
using HHMES.Bridge.DataDictModule;
using HHMES.Interfaces.Interfaces_Bridge;

/*==========================================
 *   程序说明: ROADWAY的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-09-29 03:02:11
 *   最后修改: 2016-09-29 03:02:11
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{
    public class bllROADWAY : bllBaseDataDict
    {
        private IBridge_ROADWAY _MyBridge = null;
         public bllROADWAY()
         {
             _KeyFieldName = tb_ROADWAY.__KeyName; //主键字段
             _SummaryTableName = tb_ROADWAY.__TableName;//表名
             _WriteDataLog = true;//是否保存日志
             _DataDictBridge = new dalROADWAY(Loginer.CurrentUser);//数据层的实例
             _MyBridge = this.CreateBridge();
         }

         private IBridge_ROADWAY CreateBridge()
         {
             if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                 return new ADODirect_ROADWAY().GetInstance();

             if (BridgeFactory.BridgeType == BridgeType.WebService)
                 return new WebService_ROADWAY();

             return null;
         }

         public DataTable FuzzySearch(string content)
         {
             return _MyBridge.FuzzySearch(content);
         }

      
     }
}
