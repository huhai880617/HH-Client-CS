using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using HHMES.Library;
using HHMES.Common;
using HHMES.Business;
using HHMES.Models;
using HHMES.Interfaces;

namespace HHMES.InventoryModule
{
    public partial class frmWMSInventoryHistory : HHMES.Library.frmBaseDataDictionary
    {
        public frmWMSInventoryHistory()
        {
            InitializeComponent();
        }

        private void frmWMS_Bill_Load(object sender, EventArgs e)
        {
            InitializeForm();//自定义初始化窗体操作    
        }

        private const string sqlConst = "";
        /// <summary>
        /// 初始化窗体///
        /// </summary>
        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtCode;
            _KeyEditor = txtCode;
            _DetailGroupControl = gcDetailEditor;

            _BLL = new bllWMS_StockHistory(); //业务逻辑实例
            base.InitializeForm();

            frmGridCustomize.RegisterGrid(gvSummary);
            //frmGridCustomize.AddMenuItem(gvSummary, "创建出库任务", null, OnCreateOutClick, true);

            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板

            //DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit1, DataDictCache.Cache.StockType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

            //DataTable dt = DataDictCache.Cache.StockType.Clone();
            //DataRow dr1 = dt.NewRow();
            //dr1["DataCode"] = "3";
            //dr1["NativeName"] = "入库记录";
            //DataRow dr2 = dt.NewRow();
            //dr2["DataCode"] = "4";
            //dr2["NativeName"] = "出库记录";
            //dt.Rows.Add(dr1);
            //dt.Rows.Add(dr2);
            //DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit1, dt, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            //DataBinder.BindingLookupEditDataSource(lookUpEdit3,dt, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            //DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit2, DataDictCache.Cache.StockStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            //DataBinder.BindingLookupEditDataSource(lookUpEdit1, DataDictCache.Cache.StockStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            //DataBinder.BindingLookupEditDataSource(lookUpEdit_PalletSpec, DataDictCache.Cache.PalletSpec, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            //DataBinder.BindingLookupEditDataSource(lookUpEditInvType, dt, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

            gvSummary.DoubleClick += new EventHandler(OnGridViewDoubleClick); //主表DoubleClict;

        }

        private void OnCreateOutClick(object sender, EventArgs e)
        {
            try
            {
                string PalletId = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Stock.Stock_PalletId].ToString();
                string Stock_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_StockDtl.StockDtl_Type].ToString();
                if (Stock_Type== "3")
                {
                    string execSql = string.Format("exec Tmp_CreateAllOutTask '{0}'", PalletId);
                    DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                }
                else
                {
                    Msg.Warning("库存状态不是正式库存，你不能进行任务创建操作！！！");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }
      
        /// <summary>
        /// 搜索数据
        /// </summary> 
        protected override bool DoSearchSummary()
        {
            try
            {
                string sqlCondition = sqlConst;
                if (txt_DocNoFrom.Text != "" && txt_DocNoTo.Text != "")
                {
                    sqlCondition = sqlCondition + string.Format(" and StockDtl_BillNo between '{0}' and '{1}' ", txt_DocNoFrom.Text.Trim(), txt_DocNoTo.Text.Trim());
                }
                if ((lookUpEdit_PalletSpec.EditValue != null))
                {
                    sqlCondition = sqlCondition + string.Format(" and (Stock_PalletId in (select Pallet_No from WMS_Pallet where Pallet_Spec =  '{0}'))", lookUpEdit_PalletSpec.EditValue);
                }
                if ((lookUpEditInvType.EditValue!=null))
                {
                    sqlCondition = sqlCondition + string.Format(" and StockDtl_Type='{0}'", lookUpEditInvType.EditValue);
                }
                if (textEditWareCell.Text != "")
                { 
                    sqlCondition +=string.Format(" and Stock_PositionId like '%{0}%' ",textEditWareCell.Text.Trim());
                }
                if(textEditPallet.Text!="")
                {
                    sqlCondition += string.Format(" and Stock_PalletId like '%{0}%' ", textEditPallet.Text.Trim());
                }
                if (textEditMaterial.Text != "")
                {
                    sqlCondition += string.Format(" and (StockDtl_MaterialCode like '%{0}%' or StockDtl_MaterialName like '%{1}%' ) ", textEditMaterial.Text.Trim(), textEditMaterial.Text.Trim());
                }
                if (comboBox1.Text != "")
                {
                    sqlCondition += string.Format(" and StockDtl_IsCheck='{0}'",comboBox1.Text.Trim());
                }

                DataTable dt = (_BLL as bllWMS_StockHistory).FuzzySearch(sqlCondition);
                DoBindingSummaryGrid(dt); //绑定主表的Grid
                ShowSummaryPage(true); //显示Summary页面.                         
                return dt != null && dt.Rows.Count > 0;
            }
            catch (Exception ex) { Msg.ShowException(ex); return false; }
        }

        

        /// <summary>
        /// 绑定输入框
        /// </summary>
        /// <param name="summary"></param>
        protected override void DoBindingSummaryEditor(DataTable summary)
        {
            try
            {
                if (summary == null) return;
                DataBinder.BindingTextEdit(txtCode, summary, tb_WMS_StockDtl.IsId);
                DataBinder.BindingTextEdit(textWareCell, summary, tb_WMS_StockDtl.Stock_PositionId);
                DataBinder.BindingTextEdit(textPalletNo, summary, tb_WMS_StockDtl.StockDtl_PalletId);
                DataBinder.BindingTextEdit(textPalletNum, summary, tb_WMS_StockDtl.StockDtl_PalletIdNum);
                DataBinder.BindingTextEdit(textBillNo, summary, tb_WMS_StockDtl.StockDtl_BillNo);
                DataBinder.BindingTextEdit(textNitem, summary, tb_WMS_StockDtl.StockDtl_Item);
                DataBinder.BindingTextEdit(textMaterialCode, summary, tb_WMS_StockDtl.StockDtl_MaterialCode);
                DataBinder.BindingCheckEdit(chkInCheck, summary, tb_WMS_StockDtl.StockDtl_IsCheck);
                DataBinder.BindingCheckEdit(chkIsLock, summary, tb_WMS_StockDtl.StockDtl_IsLock);
                DataBinder.BindingTextEdit(textMaterialName, summary, tb_WMS_StockDtl.StockDtl_MaterialName);
                DataBinder.BindingTextEdit(textMaterialQty, summary, tb_WMS_StockDtl.StockDtl_MaterialQty);
                DataBinder.BindingTextEdit(lookUpEdit1, summary, tb_WMS_StockDtl.StockDtl_Status);
                DataBinder.BindingTextEdit(lookUpEdit3, summary, tb_WMS_StockDtl.StockDtl_Type);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }
    }
}
