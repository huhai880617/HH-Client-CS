using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using HHMES.Models;
using HHMES.Common;
using HHMES.Interfaces;
using HHMES.Core.Log;
using HHMES.Server.DataAccess;
using HHMES.Core;
using HHMES.Business.BLL_Business;
using HHMES.Business.BLL_Base;
using HHMES.Bridge;
using HHMES.Interfaces.Interfaces_Bridge;

/*==========================================
 *   程序说明: WMS_Bill的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-21 10:18:51
 *   最后修改: 2016-10-21 10:18:51
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{
    /// <summary>
    /// bllWMS_Bill
    /// </summary>
    public class bllWMS_BillMove : bllBaseBusiness,IFuzzySearchSupportable
    {
        private IBridge_WMS_BillMove _Bridge = null;
         /// <summary>
         /// 构造器
         /// </summary>
        public bllWMS_BillMove()
         {
             _KeyFieldName = tb_WMS_BillMove.__KeyName; //主键字段
             _SummaryTableName = tb_WMS_BillMove.__TableName;//表名
             _Bridge = this.CreateBridge();//实例化桥接功能
         }

        private IBridge_WMS_BillMove CreateBridge()
        {
            if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                {
                    return new ADODirect_WMS_BillMove().GetInstance();
                }
            //if (BridgeFactory.BridgeType == BridgeType.WebService)
            //        return new WebService_WMS_Bill();
            return null;
        }


          /// <summary>
          ///根据单据号码取业务数据
          /// </summary>
          public override DataSet GetBusinessByKey(string keyValue, bool resetCurrent)
          {
              DataSet ds = new dalWMS_BillMove(Loginer.CurrentUser).GetBusinessByKey(keyValue); 
              this.SetNumericDefaultValue(ds); //设置预设值
              if (resetCurrent) _CurrentBusiness = ds; //保存当前业务数据的对象引用
              return ds;
           }

          /// <summary>
          ///删除单据
          /// </summary>
          public override bool Delete(string keyValue)
          {
              return new dalWMS_BillMove(Loginer.CurrentUser).Delete(keyValue);
          }

          /// <summary>
          ///检查单号是否存在
          /// </summary>
          public bool CheckNoExists(string keyValue)
          {
              return new dalWMS_BillMove(Loginer.CurrentUser).CheckNoExists(keyValue);
          }

          /// <summary>
          ///保存数据
          /// </summary>
          public override SaveResult Save(DataSet saveData)
          {
              //return new dalWMS_Bill(Loginer.CurrentUser).Update(saveData, this.OnChangeVersion); //交给数据层处理
              return new dalWMS_BillMove(Loginer.CurrentUser).Update(saveData); //交给数据层处理
          }

          /// <summary>
          ///审核单据
          /// </summary>
          public override void ApprovalBusiness(DataRow summaryRow)
          {
               summaryRow[BusinessCommonFields.AppDate] = DateTime.Now;
               summaryRow[BusinessCommonFields.AppUser] = Loginer.CurrentUser.Account;
               summaryRow[BusinessCommonFields.FlagApp] = "Y";
               string key = ConvertEx.ToString(summaryRow[tb_WMS_BillMove.__KeyName]);
               new dalWMS_BillMove(Loginer.CurrentUser).ApprovalBusiness(key, "Y", Loginer.CurrentUser.Account, DateTime.Now);
          }

          public override void ClearAppInfo(DataRow summaryRow)
          {
              base.ClearAppInfo(summaryRow);
              string key = ConvertEx.ToString(summaryRow[tb_WMS_BillMove.__KeyName]);
              new dalWMS_BillMove(Loginer.CurrentUser).ClearAppInfo(key);
          }
          /// <summary>
          ///新增一张业务单据
          /// </summary>
          public override void NewBusiness()
          {
              DataTable summaryTable = _CurrentBusiness.Tables[tb_WMS_BillMove.__TableName];
              DataRow row = summaryTable.Rows.Add();
              row[tb_WMS_BillMove.__KeyName] = "*自动生成*";
              row[tb_WMS_BillMove.VerNo] = "01";
              row[tb_WMS_BillMove.CreatedBy] = Loginer.CurrentUser.Account;
              row[tb_WMS_BillMove.CreationDate] = DateTime.Now;
              row[tb_WMS_BillMove.LastUpdatedBy] = Loginer.CurrentUser.Account;
              row[tb_WMS_BillMove.LastUpdateDate] = DateTime.Now;
           }

         
          /// <summary>
          ///创建用于保存的临时数据
          /// </summary>
          public override DataSet CreateSaveData(DataSet currentBusiness, UpdateType currentType)
          {
              this.UpdateSummaryRowState(this.DataBindRow, currentType);

              //创建用于保存的临时数据,里面包含主表数据
              DataSet save = this.DoCreateTempData(currentBusiness, tb_WMS_BillMove.__TableName);
              DataTable summary = save.Tables[0];
              summary.Rows[0][BusinessCommonFields.LastUpdateDate] = DateTime.Now;
              summary.Rows[0][BusinessCommonFields.LastUpdatedBy] = Loginer.CurrentUser.Account;

              DataTable detail = currentBusiness.Tables[tb_WMS_BillMoveDtl.__TableName].Copy();
              this.UpdateDetailCommonValue(detail); //更新明细表的公共字段数据
              save.Tables.Add(detail); //加入明细数据 

              return save;
          }

          /// <summary>
          ///查询数据
          /// </summary>
          public DataTable GetSummaryByParam(string SqlCondition)
          {
              return _Bridge.GetSummaryByParam(SqlCondition);
          }

          /// <summary>
          ///获取报表数据
          /// </summary>
          public DataSet GetReportData(string DocNoFrom, string DocNoTo, DateTime DateFrom, DateTime DateTo)
          {
              return null;
          }

          #region Business Log

          /// <summary>
          /// 写入日志
          /// </summary>
          public override void WriteLog()
          {
              string key = this.DataBinder.Rows[0][tb_WMS_BillMove.__KeyName].ToString();//取单据号码
              DataSet dsOriginal = this.GetBusinessByKey(key, false); //取保存前的原始数据, 用于保存日志时匹配数据.
              DataSet dsTemplate = this.CreateSaveData(this.CurrentBusiness, UpdateType.Modify); //创建用于保存的临时数据
              this.WriteLog(dsOriginal, dsTemplate);//保存日志      
          }

          /// <summary>
          /// 写入日志
          /// </summary>
          /// <param name="original">原始数据</param>
          /// <param name="changes">修改后的数据</param>
          public override void WriteLog(DataTable original, DataTable changes) { }

          /// <summary>
          /// 写入日志
          /// </summary>
          /// <param name="original">原始数据</param>
          /// <param name="changes">修改后的数据</param>
          public override void WriteLog(DataSet original, DataSet changes)
          {  //单独处理,即使错误,不向外抛出异常
              try
              {
                  string logID = Guid.NewGuid().ToString().Replace("-", ""); //本次日志ID

                  IBridge_EditLogHistory logBridge = bllBusinessLog.CreateEditLogHistoryBridge();

                  logBridge.WriteLog(logID, original.Tables[0], changes.Tables[0], tb_WMS_BillMove.__TableName, tb_WMS_BillMove.__KeyName, true); //主表
                  logBridge.WriteLog(logID, original.Tables[1], changes.Tables[1], tb_WMS_BillMoveDtl.__TableName, tb_WMS_BillMoveDtl.__KeyName, false);//明细
              }
              catch
              {
                  Msg.Warning("写入日志发生错误！");
              }
          }

          #endregion
          #region IFuzzySearchSupportable Members

          public string FuzzySearchName
          {
              get { return "搜索产品资料"; }
          }

          public DataTable FuzzySearch(string content)
          {
              bllITEM bll = new bllITEM();
              return bll.FuzzySearch(content);
          }

          #endregion
     }
}
