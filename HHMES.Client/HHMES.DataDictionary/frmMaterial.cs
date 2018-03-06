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
    public partial class frmMaterial : frmBaseDataDictionary
    {
        private bllWMS_Material _BllInstance; //业务逻辑层对象引用

        public frmMaterial()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtPcode;
            _KeyEditor = txtPcode;
            _DetailGroupControl = gcDetailEditor;

            _BLL = new bllWMS_Material(); //业务逻辑实例
            _BllInstance = _BLL as bllWMS_Material; //本窗体引用

            base.InitializeForm();

            DataBinder.BindingLookupEditDataSource(txtAttr, DataDictCache.Cache.MaterialAttribute, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit1, DataDictCache.Cache.MaterialType, tb_CommonDataDict.NativeName,tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit2, DataDictCache.Cache.MaterialType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit3, DataDictCache.Cache.MaterialAttribute, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(textEdit1, DataDictCache.Cache.MaterialUnit, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit2, DataDictCache.Cache.MaterialAttribute, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit1, DataDictCache.Cache.MaterialType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

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
                DataBinder.BindingTextEdit(txtPcode, summary, tb_WMS_Material.Material_Code);
                DataBinder.BindingTextEdit(txtPname, summary, tb_WMS_Material.Material_Name);
                DataBinder.BindingTextEdit(txtBarcode, summary, tb_WMS_Material.Material_barcode);
                DataBinder.BindingTextEdit(lookUpEdit2, summary, tb_WMS_Material.Material_Type);
                DataBinder.BindingTextEdit(lookUpEdit3, summary, tb_WMS_Material.Material_Attribute);
                DataBinder.BindingCheckEdit(checkEdit1, summary, tb_WMS_Material.Material_IsStop);
                DataBinder.BindingCheckEdit(checkEdit2, summary, tb_WMS_Material.Material_IsNeedCheck);
                DataBinder.BindingTextEdit(textEdit1, summary, tb_WMS_Material.Material_Unit);
                DataBinder.BindingTextEdit(textEdit2, summary, tb_WMS_Material.Material_ActPrice);
                DataBinder.BindingTextEdit(textEdit3, summary, tb_WMS_Material.Material_PrePrice);
                DataBinder.BindingTextEdit(textEdit4, summary, tb_WMS_Material.Material_Remark);
                DataBinder.BindingTextEdit(txtWarehouseCreator, summary, tb_WMS_Material.Material_Creator);
                DataBinder.BindingTextEdit(txtWarehouseCreateTime, summary, tb_WMS_Material.Material_CreateTime);
                DataBinder.BindingTextEdit(txtWarehouseEditor, summary, tb_WMS_Material.Material_Editor);
                DataBinder.BindingTextEdit(txtWarehouseEditTime, summary, tb_WMS_Material.Material_EditTime);

            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string Sql = "";
            if (txt_Id.Text != "")
            {
                Sql += string.Format(" and Material_Code like '%{0}%' ", txt_Id.Text);
            }
            if (txt_Name.Text != "")
            {
                Sql += string.Format(" and Material_Name like '%{0}%' ", txt_Name.Text);
            }
            if (txt_Barcode.Text != "")
            {
                Sql += string.Format(" and Material_Barcode like '%{0}%' ", txt_Barcode.Text);
            }
            if (txtAttr.Text != "")
            {
                Sql += string.Format(" and Material_Type like '%{0}%' ", txtAttr.EditValue);
            }
            if (lookUpEdit1.Text != "")
            {
                Sql += string.Format(" and Material_Attribute like '%{0}%' ", lookUpEdit1.EditValue);
            }
            if (chkInUse.CheckState == CheckState.Checked)
            {
                Sql += string.Format(" and Material_IsStop = 'Y'", txt_Id.Text);
            }
            
            if (checkInCheck.CheckState == CheckState.Checked)
            {
                Sql += string.Format(" and Material_IsNeedCheck = 'Y'", txt_Id.Text);
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

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
