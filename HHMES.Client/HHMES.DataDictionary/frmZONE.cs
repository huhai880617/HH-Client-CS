using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Library;
using HHMES.Interfaces;
using HHMES.Business;
using HHMES.Common;
using HHMES.Core;
using HHMES.Models;


namespace HHMES.DataDictionary
{
    public partial class frmZONE : HHMES.Library.frmBaseDataDictionary
    {
        private bllZONE _BllInstance;//业务层逻辑引用；

        public frmZONE()
        {
            InitializeComponent();
        }

        private void frmZONE_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtCODE;
            _KeyEditor = txtCODE;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllZONE(); //业务逻辑实例
            _BllInstance = _BLL as bllZONE; //本窗体引用

            base.InitializeForm();

            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板

            DataBinder.BindingLookupEditDataSource(S_WAREHOUSEID, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit1, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit1, DataDictCache.GetCacheTableData("WAREHOUSE"), "NAME", "ID");
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
                DataBinder.BindingTextEdit(txtCODE, summary, tb_ZONE.CODE);
                DataBinder.BindingTextEdit(txtNAME, summary, tb_ZONE.NAME);
                DataBinder.BindingTextEdit(lookUpEdit1, summary, tb_ZONE.WAREHOUSEID);
               
                DataBinder.BindingTextEdit(txtWarehouseCreator, summary, tb_ZONE.CREATEBY);
                DataBinder.BindingTextEdit(txtWarehouseCreateTime, summary, tb_ZONE.CREATETIME);
                DataBinder.BindingTextEdit(txtWarehouseEditor, summary, tb_ZONE.MODIFYBY);
                DataBinder.BindingTextEdit(txtWarehouseEditTime, summary, tb_ZONE.MODIFYTIME);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtCODE.Text == string.Empty)
            {
                Msg.Warning("编号不能为空!");
                txtCODE.Focus();
                return false;
            }

            if (txtNAME.Text.Trim() == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                txtNAME.Focus();
                return false;
            }


            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtCODE.Text))
                {
                    Msg.Warning("编号已存在!");
                    txtCODE.Focus();
                    return false;
                }
            }
            return true;
        }

           

        public override void DoAdd(IButtonInfo sender)
        {
            base.DoAdd(sender);
            SetEditorBindingValue(txtWarehouseCreator, Loginer.CurrentUser.Account);
            SetEditorBindingValue(txtWarehouseCreateTime,ConvertEx.ToCharYYYY_MM_DD_HHMMSS(DateTime.Now));
        }

        public override void DoEdit(IButtonInfo sender)
        {
           base.DoEdit(sender);
           SetEditorBindingValue(txtWarehouseEditor, Loginer.CurrentUser.Account);
           SetEditorBindingValue(txtWarehouseEditTime, ConvertEx.ToCharYYYY_MM_DD_HHMMSS(DateTime.Now));
        }

       

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            base.ClearContainerEditorText(panelSearch);   
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql="AND ISDELETED=0 ";
            if(txtCODE.Text!="")
            {
                sql+= string.Format(" and CODE like '%{0}%' ", txtCODE.Text);
            }
            
            if(S_WAREHOUSEID.EditValue.ToString()!="")
            {
                sql+= string.Format(" and WAREHOUSEID = '{0}' ", S_WAREHOUSEID.EditValue.ToString());
            }
            
            this.DoBindingSummaryGrid(this._BllInstance.FuzzySearch(sql)); //绑定主表的Grid
            this.ShowSummaryPage(true); //显示Summary页面. 
        }

    }
}
