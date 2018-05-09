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
 *   程序说明: STACKER的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-09-29 03:02:11
 *   最后修改: 2016-09-29 03:02:11
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{
    public class bllSTACKER : bllBaseDataDict
    {
        private IBridge_STACKER _MyBridge = null;
         public bllSTACKER()
         {
             _KeyFieldName = tb_STACKER.__KeyName; //主键字段
             _SummaryTableName = tb_STACKER.__TableName;//表名
             _WriteDataLog = true;//是否保存日志
             _DataDictBridge = new dalSTACKER(Loginer.CurrentUser);//数据层的实例
             _MyBridge = this.CreateBridge();
         }

         private IBridge_STACKER CreateBridge()
         {
             if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                 return new ADODirect_STACKER().GetInstance();

             if (BridgeFactory.BridgeType == BridgeType.WebService)
                 return new WebService_STACKER();

             return null;
         }

         public DataTable FuzzySearch(string content)
         {
             return _MyBridge.FuzzySearch(content);
         }

      
     }
}
