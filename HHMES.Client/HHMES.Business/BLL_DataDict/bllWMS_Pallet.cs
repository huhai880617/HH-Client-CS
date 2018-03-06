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
 *   程序说明: WMS_Pallet的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-09-29 03:02:11
 *   最后修改: 2016-09-29 03:02:11
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{
    public class bllWMS_Pallet : bllBaseDataDict
    {
        private IBridge_WMS_Pallet _MyBridge = null;
         public bllWMS_Pallet()
         {
             _KeyFieldName = tb_WMS_Pallet.__KeyName; //主键字段
             _SummaryTableName = tb_WMS_Pallet.__TableName;//表名
             _WriteDataLog = true;//是否保存日志
             _DataDictBridge = new dalWMS_Pallet(Loginer.CurrentUser);//数据层的实例
             _MyBridge = this.CreateBridge();
         }

         private IBridge_WMS_Pallet CreateBridge()
         {
             if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                 return new ADODirect_WMS_Pallet().GetInstance();

             if (BridgeFactory.BridgeType == BridgeType.WebService)
                 return new WebService_WMS_Pallet();

             return null;
         }

         public DataTable FuzzySearch(string content)
         {
             return _MyBridge.FuzzySearch(content);
         }

        /// <summary>
        /// 创建托盘
        /// </summary>
         public void CreatePallet(string Prefix,string palletSpec,int startNo,int Qty,out string Errmsg)
         {
             //string procedureName = "sp_WMS_CreatePallet";
             //SqlCommand sqlcmd = new SqlCommand(procedureName);
             //sqlcmd.CommandType = CommandType.StoredProcedure;
             //sqlcmd.Parameters.Add("@Prefix",SqlDbType.NVarChar).Value=Prefix;
             //sqlcmd.Parameters.Add("@PalletSpec", SqlDbType.NVarChar).Value=palletSpec;
             //sqlcmd.Parameters.Add("@StartNo", SqlDbType.Int).Value=startNo;
             //sqlcmd.Parameters.Add("@Qty", SqlDbType.Int).Value=Qty;
             string sqlcmd = string.Format(" exec sp_WMS_CreatePallet '{0}','{1}','{2}','{3}'", Prefix, palletSpec, startNo, Qty);
             DataSet ds= ExecuteProcedure(sqlcmd);
             if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
             {
                 if (ds.Tables[0].Rows[0][0].ToString() == "0")
                 {
                     Errmsg = "操作成功";
                     return;
                 }
                 else
                 {
                    Errmsg=ds.Tables[0].Rows[0][1].ToString();
                 }
             }
             Errmsg = "操作失败";
         }

         /// <summary>
         /// 删除托盘
         /// </summary>
         public void DeletePallet(string Prefix, string palletSpec, int startNo, int Qty,out string Errmsg)
         {
             //string procedureName="sp_WMS_DeletePallet";
             //SqlCommand sqlcmd = new SqlCommand(procedureName);
             //sqlcmd.CommandType = CommandType.StoredProcedure;
             //sqlcmd.Parameters.Add("@Prefix", SqlDbType.NVarChar).Value = Prefix;
             //sqlcmd.Parameters.Add("@PalletSpec", SqlDbType.NVarChar).Value = palletSpec;
             //sqlcmd.Parameters.Add("@StartNo", SqlDbType.Int).Value = startNo;
             //sqlcmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
             string sqlcmd = string.Format(" exec sp_WMS_CreatePallet '{0}','{1}','{2}','{3}'", Prefix, palletSpec, startNo, Qty);
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
