using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Business;
using HHMES.Common;
using HHMES.Models;
using HHMES.Library;
using HHMES.Interfaces;
using HHMES.Core;

namespace HHMES.DataDictionary
{
    /// <summary>
    /// 客户管理窗体
    /// </summary>
    public partial class frmCustomer : frmBaseDataDictionary
    {
        private bllSUPPLIERCUSTOMER _BllCustomer; //业务逻辑层对象引用

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.InitializeForm();//自定义初始化操作            
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtCode;
            _KeyEditor = txtCode;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllSUPPLIERCUSTOMER(); //业务逻辑实例
            _BllCustomer = _BLL as bllSUPPLIERCUSTOMER; //本窗体引用

            base.InitializeForm();

            //绑定相关缓存数据
            //search 
            DataBinder.BindingLookupEditDataSource(txt_Attr, DataDictCache.GetCacheConfigData("COMPANYTYPE"), "NAME", "ID");

            //summary
            DataBinder.BindingLookupEditDataSource(LookUpEdit_TYPE_CFG, DataDictCache.GetCacheConfigData("COMPANYTYPE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(LookUpEdit_WAREHOUSEID, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(LookUpEdit_COMPANYID, DataDictCache.GetCacheTableData("COMPANY"), "NAME", "ID");

            //detail
            DataBinder.BindingLookupEditDataSource(lookUpEdit1_typecfg, DataDictCache.GetCacheConfigData("COMPANYTYPE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit1_warehouse, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit1_company, DataDictCache.GetCacheTableData("COMPANY"), "NAME", "ID");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {//搜索数据  
             
            this._BllCustomer.SearchBy(txt_CODE.Text, txt_Name.Text, ConvertEx.ToString(txt_Attr.EditValue), true);
            this.DoBindingSummaryGrid(_BLL.SummaryTable); //绑定主表的Grid
            this.ShowSummaryPage(true); //显示Summary页面. 
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtCode.Text == string.Empty)
            {
                Msg.Warning("客户编号不能为空!");
                txtCode.Focus();
                return false;
            }

            if (txtName.Text.Trim() == string.Empty)
            {
                Msg.Warning("客户名称不能为空!");
                txtName.Focus();
                return false;
            }

            if (lookUpEdit1_typecfg.Text == string.Empty)
            {
                Msg.Warning("公司类型不能为空!");
                lookUpEdit1_typecfg.Focus();
                return false;
            }

            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtCode.Text))
                {
                    Msg.Warning("客户编号已存在!");
                    txtCode.Focus();
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
                DataBinder.BindingTextEdit(txtCode, summary, tb_SUPPLIERCUSTOMER.CODE);
                DataBinder.BindingTextEdit(txtAddress1, summary, tb_SUPPLIERCUSTOMER.ADDRESS1);
                DataBinder.BindingTextEdit(txtAddress2, summary, tb_SUPPLIERCUSTOMER.ADDRESS2);
                DataBinder.BindingTextEdit(txtCity, summary, tb_SUPPLIERCUSTOMER.CITY);
                DataBinder.BindingTextEdit(txtAttentionTo, summary, tb_SUPPLIERCUSTOMER.ATTENTIONTO);
                DataBinder.BindingTextEdit(txtCountry, summary, tb_SUPPLIERCUSTOMER.COUNTRY);
                DataBinder.BindingTextEdit(txtEmail, summary, tb_SUPPLIERCUSTOMER.EMAIL);
                DataBinder.BindingTextEdit(txtFax, summary, tb_SUPPLIERCUSTOMER.FAXNUM);
                DataBinder.BindingTextEdit(txtName, summary, tb_SUPPLIERCUSTOMER.NAME);
                DataBinder.BindingTextEdit(txtRegion, summary, tb_SUPPLIERCUSTOMER.STATE);
                DataBinder.BindingTextEdit(txtTel, summary, tb_SUPPLIERCUSTOMER.PHONENUM);
                DataBinder.BindingTextEdit(txtZipCode, summary, tb_SUPPLIERCUSTOMER.POSTALCODE);
                DataBinder.BindingCheckEdit(chkInUse, summary, tb_SUPPLIERCUSTOMER.ENABLE);

                DataBinder.BindingTextEdit(lookUpEdit1_company, summary, tb_SUPPLIERCUSTOMER.COMPANYID);
                DataBinder.BindingTextEdit(lookUpEdit1_warehouse, summary, tb_SUPPLIERCUSTOMER.WAREHOUSEID);
                DataBinder.BindingTextEdit(lookUpEdit1_typecfg, summary, tb_SUPPLIERCUSTOMER.TYPE_CFG);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            base.ClearContainerEditorText(panelControl3);            
        }

    }
}
