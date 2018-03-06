using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Models;
using HHMES.Common;
using HHMES.Interfaces;
using HHMES.Core.Log;
using HHMES.Server.DataAccess;
using HHMES.Core;
using HHMES.Business.BLL_Base;
using HHMES.Bridge;
using HHMES.Interfaces.Interfaces_Bridge;
using HHMES.Bridge.DataDictModule;
/*==========================================
 *   程序说明: WMS_WareCell的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-06 11:08:15
 *   最后修改: 2016-10-06 11:08:15
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{


    public class bllWMS_WareCell : bllBaseDataDict
    {
         private IBridge_WMS_WareCell _MyBridge = null;
         public bllWMS_WareCell()
         {
             _KeyFieldName = tb_WMS_WareCell.__KeyName; //主键字段
             _SummaryTableName = tb_WMS_WareCell.__TableName;//表名
             _WriteDataLog = true;//是否保存日志
             _DataDictBridge = new dalWMS_WareCell(Loginer.CurrentUser);//数据层的实例
             _MyBridge = this.CreateBridge();
         }


         private IBridge_WMS_WareCell CreateBridge()
         {
             if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                    return new ADODirect_WMS_WareCell().GetInstance();


             if(BridgeFactory.BridgeType == BridgeType.WebService)
                    return new WebService_WMS_WareCell();
                return null;
          }

           public DataTable FuzzySearch(string content)
        {
            return _MyBridge.FuzzySearch(content);
        }
     }


}
