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
    public partial class frmWareHouse : HHMES.Library.frmBaseDataDictionary
    {
        private bllWMS_Warehouse _BllInstance;//业务层逻辑引用；

        public frmWareHouse()
        {
            InitializeComponent();
        }

        private void frmWareHouse_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtWarehouseId;
            _KeyEditor = txtWarehouseId;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllWMS_Warehouse(); //业务逻辑实例
            _BllInstance = _BLL as bllWMS_Warehouse; //本窗体引用

            base.InitializeForm();
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
                DataBinder.BindingTextEdit(txtWarehouseId, summary, tb_WMS_Warehouse.Warehouse_Id);
                DataBinder.BindingTextEdit(txtWarehouseName, summary, tb_WMS_Warehouse.Warehouse_Name);
                DataBinder.BindingTextEdit(txtWarehousePosition, summary, tb_WMS_Warehouse.Warehouse_Location);
                DataBinder.BindingTextEdit(txtWarehouseRemark, summary, tb_WMS_Warehouse.Warehouse_Notes);
                //DataBinder.BindingTextEdit(chkWarehouse_Status, summary, tb_WMS_Warehouse.Warehouse_Status);
                DataBinder.BindingCheckEdit(chkWarehouse_Status, summary, tb_WMS_Warehouse.Warehouse_IsUse);
                DataBinder.BindingTextEdit(txtWarehouseCreator, summary, tb_WMS_Warehouse.Warehouse_Creator);
                DataBinder.BindingTextEdit(txtWarehouseCreateTime, summary, tb_WMS_Warehouse.Warehouse_CreateTime);
                DataBinder.BindingTextEdit(txtWarehouseEditor, summary, tb_WMS_Warehouse.Warehouse_EditWho);
                DataBinder.BindingTextEdit(txtWarehouseEditTime, summary, tb_WMS_Warehouse.Warehouse_EditTime);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtWarehouseId.Text == string.Empty)
            {
                Msg.Warning("编号不能为空!");
                txtWarehouseId.Focus();
                return false;
            }

            if (txtWarehouseName.Text.Trim() == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                txtWarehouseName.Focus();
                return false;
            }


            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtWarehouseId.Text))
                {
                    Msg.Warning("编号已存在!");
                    txtWarehouseId.Focus();
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
            base.ClearContainerEditorText(panelControl3);   
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql="";
            if(txtId.Text!="")
            {
                sql+= string.Format(" and Warehouse_Id like '%{0}%' ", txtId.Text);
            }
            if(txt_Name.Text!="")
            {
                sql+= string.Format(" and Warehouse_Name like '%{0}%' ", txtId.Text);
            }
            if(txtSpec.Text!="")
            {
                sql+= string.Format(" and Warehouse_Location like '%{0}%' ", txtId.Text);
            }
            
            this.DoBindingSummaryGrid(this._BllInstance.FuzzySearch(sql)); //绑定主表的Grid
            this.ShowSummaryPage(true); //显示Summary页面. 
        }

    }
}
