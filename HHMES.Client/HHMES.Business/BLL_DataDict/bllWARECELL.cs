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
 *   程序说明: WARECELL的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-06 11:08:15
 *   最后修改: 2016-10-06 11:08:15
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{


    public class bllWARECELL : bllBaseDataDict
    {
         private IBridge_WARECELL _MyBridge = null;
         public bllWARECELL()
         {
             _KeyFieldName = tb_WARECELL.__KeyName; //主键字段
             _SummaryTableName = tb_WARECELL.__TableName;//表名
             _WriteDataLog = true;//是否保存日志
             _DataDictBridge = new dalWARECELL(Loginer.CurrentUser);//数据层的实例
             _MyBridge = this.CreateBridge();
         }


         private IBridge_WARECELL CreateBridge()
         {
             if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                    return new ADODirect_WARECELL().GetInstance();


             if(BridgeFactory.BridgeType == BridgeType.WebService)
                    return new WebService_WARECELL();
                return null;
          }

           public DataTable FuzzySearch(string content)
        {
            return _MyBridge.FuzzySearch(content);
        }

        /// <summary>
        /// 创建托盘
        /// </summary>
        public void CreateWARECELL(string IP, string client, string user, string ZONEID, string WARECELLSPECID, int S_ROW, int S_COLUMN, int S_LAYER, int E_ROW, int E_COLUMN, int E_LAYER, out string Errmsg)
        {
            //string procedureName = "sp_WMS_CreatePallet";
            //SqlCommand sqlcmd = new SqlCommand(procedureName);   
            //sqlcmd.CommandType = CommandType.StoredProcedure;
            //sqlcmd.Parameters.Add("@Prefix",SqlDbType.NVarChar).Value=Prefix;
            //sqlcmd.Parameters.Add("@PalletSpec", SqlDbType.NVarChar).Value=palletSpec;
            //sqlcmd.Parameters.Add("@StartNo", SqlDbType.Int).Value=startNo;
            //sqlcmd.Parameters.Add("@Qty", SqlDbType.Int).Value=Qty;
            string sqlcmd = string.Format(" exec p_info_CreatePallet '{0}','{1}','{2}','{3}','{4}','{5}'", IP, client, user, ZONEID,WARECELLSPECID,S_ROW,S_COLUMN,S_LAYER,E_ROW,E_COLUMN,E_LAYER);
            DataSet ds = ExecuteProcedure(sqlcmd);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0].ToString() == "0")
                {
                    Errmsg = "操作成功";
                    return;
                }
                else
                {
                    Errmsg = ds.Tables[0].Rows[0][1].ToString();
                }
            }
            Errmsg = "操作失败";
        }
    }


}
