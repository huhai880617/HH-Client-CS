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
    public partial class frmITEM_PALLET_CAPACITY : HHMES.Library.frmBaseDataDictionary
    {
        private bllITEM_PALLET_CAPACITY _BllInstance;//业务层逻辑引用；

        public frmITEM_PALLET_CAPACITY()
        {
            InitializeComponent();
        }

        private void frmITEM_PALLET_CAPACITY_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            //_ActiveEditor = txtCODE;
            //_KeyEditor = txtCODE;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllITEM_PALLET_CAPACITY(); //业务逻辑实例
            _BllInstance = _BLL as bllITEM_PALLET_CAPACITY; //本窗体引用

            base.InitializeForm();

            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板

            DataBinder.BindingLookupEditDataSource(S_PALLETSPECID, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(E_PALLETSPECID, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(R_PALLETSPECID, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(E_ITEMID, DataDictCache.GetCacheTableData("ITEM"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(S_ITEMID, DataDictCache.GetCacheTableData("ITEM"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(R_ITEMID, DataDictCache.GetCacheTableData("ITEM"), "NAME", "ID");
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
                DataBinder.BindingTextEdit(E_CAPACITYQTY, summary, tb_ITEM_PALLET_CAPACITY.CAPACITYQTY);
                DataBinder.BindingTextEdit(E_ITEMID, summary, tb_ITEM_PALLET_CAPACITY.ITEMID);
                DataBinder.BindingTextEdit(E_PALLETSPECID, summary, tb_ITEM_PALLET_CAPACITY.PALLETSPECID);               
                DataBinder.BindingCheckEdit(E_ENABLE, summary, tb_ITEM_PALLET_CAPACITY.ENABLE);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (E_ITEMID.EditValue!=null&& E_ITEMID.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("商品不能为空!");
                E_ITEMID.Focus();
                return false;
            }

            if (E_PALLETSPECID.EditValue!=null && E_PALLETSPECID.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                E_PALLETSPECID.Focus();
                return false;
            }

            if (E_CAPACITYQTY.ToString() == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                E_CAPACITYQTY.Focus();
                return false;
            }
            //if (_UpdateType == UpdateType.Add)
            //{
            //    if (_BLL.CheckNoExists(txtCODE.Text))
            //    {
            //        Msg.Warning("编号已存在!");
            //        txtCODE.Focus();
            //        return false;
            //    }
            //}
            return true;
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            base.ClearContainerEditorText(panelSearch);   
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql=" ";
            if(S_ITEMID.EditValue!=null && S_ITEMID.EditValue.ToString()!="")
            {
                sql+= string.Format(" and ITEMID = '{0}' ", S_ITEMID.EditValue.ToString());
            }
            
            if(S_PALLETSPECID.EditValue!=null&& S_PALLETSPECID.EditValue.ToString()!="")
            {
                sql+= string.Format(" and PALLETSPECID = '{0}' ", S_PALLETSPECID.EditValue.ToString());
            }
            
            this.DoBindingSummaryGrid(this._BllInstance.FuzzySearch(sql)); //绑定主表的Grid
            this.ShowSummaryPage(true); //显示Summary页面. 
        }

    }
}
