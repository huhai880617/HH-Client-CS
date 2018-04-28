using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HHMES.Library;
using HHMES.Business;
using HHMES.Interfaces;
using HHMES.Core;
using HHMES.Common;
using HHMES.Models;

namespace HHMES.DataDictionary
{
    /// <summary>
    /// 产品资料管理
    /// </summary>
    public partial class frmITEM : frmBaseDataDictionary
    {
        private bllITEM _BllInstance; //业务逻辑层对象引用

        public frmITEM()
        {
            InitializeComponent();
        }

        private void frmITEM_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtPcode;
            _KeyEditor = txtPcode;
            _DetailGroupControl = gcDetailEditor;

            _BLL = new bllITEM(); //业务逻辑实例
            _BllInstance = _BLL as bllITEM; //本窗体引用

            base.InitializeForm();

         
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit_W, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit_C, DataDictCache.GetCacheTableData("COMPANY"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit1_warehouse, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit1_company, DataDictCache.GetCacheTableData("COMPANY"), "NAME", "ID");

        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtPcode.Text == string.Empty)
            {
                Msg.Warning("编号不能为空!");
                txtPcode.Focus();
                return false;
            }

            if (txtPname.Text.Trim() == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                txtPname.Focus();
                return false;
            }


            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtPcode.Text))
                {
                    Msg.Warning("编号已存在!");
                    txtPcode.Focus();
                    return false;
                }
            }
            return true;
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
                DataBinder.BindingTextEdit(lookUpEdit1_warehouse, summary, tb_ITEM.WAREHOUSEID);
                DataBinder.BindingTextEdit(lookUpEdit1_company, summary, tb_ITEM.COMPANYID);
                DataBinder.BindingTextEdit(txtPname, summary, tb_ITEM.NAME);
                DataBinder.BindingTextEdit(txtPcode, summary, tb_ITEM.CODE);
                DataBinder.BindingTextEdit(txtPname, summary, tb_ITEM.NAME);
                DataBinder.BindingTextEdit(txtBarcode, summary, tb_ITEM.BARCODE);
                DataBinder.BindingTextEdit(txtClass01, summary, tb_ITEM.CLASS01);
                DataBinder.BindingCheckEdit(checkEdit1, summary, tb_ITEM.ENABLE);
                DataBinder.BindingCheckEdit(checkEdit2, summary, tb_ITEM.IQCTYPE);

                DataBinder.BindingTextEdit(textEdit1, summary, tb_ITEM.DAYSTOEXPIRE);
                DataBinder.BindingTextEdit(textEdit2, summary, tb_ITEM.EXPIRINGDAYS);
                DataBinder.BindingTextEdit(textEdit3, summary, tb_ITEM.MINSHELFLIFEDAYS);
               
                DataBinder.BindingTextEdit(txtWarehouseCreator, summary, tb_ITEM.CREATEBY);
                DataBinder.BindingTextEdit(txtWarehouseCreateTime, summary, tb_ITEM.CREATETIME);
                DataBinder.BindingTextEdit(txtWarehouseEditor, summary, tb_ITEM.MODIFYBY);
                DataBinder.BindingTextEdit(txtWarehouseEditTime, summary, tb_ITEM.MODIFYTIME);

            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string Sql = " AND ISDELETED=0 ";
            if (txt_CODE.Text != "")
            {
                Sql += string.Format(" and CODE like '%{0}%' ", txt_CODE.Text);
            }
            if (txt_Name.Text != "")
            {
                Sql += string.Format(" and NAME like '%{0}%' ", txt_Name.Text);
            }
            if (txt_Barcode.Text != "")
            {
                Sql += string.Format(" and BARCODE like '%{0}%' ", txt_Barcode.Text);
            }
            
            if (chkInUse.CheckState == CheckState.Checked)
            {
                Sql += (" and ENABLE = 1 ");
            }
            
            if (checkInCheck.CheckState == CheckState.Checked)
            {
                Sql +=(" and IQCTYPE = 1 ");
            }
            

            this.DoBindingSummaryGrid(this._BllInstance.FuzzySearch(Sql)); //绑定主表的Grid
            this.ShowSummaryPage(true); //显示Summary页面. 
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            base.ClearContainerEditorText(panelControl3); 
        }

        public override void DoAdd(IButtonInfo sender)
        {
             base.DoAdd(sender);
            SetEditorBindingValue(txtWarehouseCreator, Loginer.CurrentUser.Account);
            SetEditorBindingValue(txtWarehouseCreateTime,ConvertEx.ToCharDD_MM_YYYY_HHMMSS(DateTime.Now));
            
        }
        public override void DoEdit(IButtonInfo sender)
        {
            base.DoEdit(sender);
            SetEditorBindingValue(txtWarehouseEditor, Loginer.CurrentUser.Account);
            SetEditorBindingValue(txtWarehouseEditTime, ConvertEx.ToCharDD_MM_YYYY_HHMMSS(DateTime.Now));
        }
        
    }
}
