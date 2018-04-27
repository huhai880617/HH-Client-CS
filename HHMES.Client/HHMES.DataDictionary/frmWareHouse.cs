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
        private bllWAREHOUSE _BllInstance;//业务层逻辑引用；

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
            _BLL = new bllWAREHOUSE(); //业务逻辑实例
            _BllInstance = _BLL as bllWAREHOUSE; //本窗体引用

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
                DataBinder.BindingTextEdit(txtWarehouseId, summary, tb_WAREHOUSE.CODE);
                DataBinder.BindingTextEdit(txtWarehouseName, summary, tb_WAREHOUSE.NAME);
                DataBinder.BindingTextEdit(txtWarehousePosition, summary, tb_WAREHOUSE.ADDRESS);
                
                //DataBinder.BindingTextEdit(chkWarehouse_Status, summary, tb_WAREHOUSE.Warehouse_Status);
                DataBinder.BindingCheckEdit(chkWarehouse_Status, summary, tb_WAREHOUSE.ENABLE);
                DataBinder.BindingTextEdit(txtWarehouseCreator, summary, tb_WAREHOUSE.CREATEBY);
                DataBinder.BindingTextEdit(txtWarehouseCreateTime, summary, tb_WAREHOUSE.CREATETIME);
                DataBinder.BindingTextEdit(txtWarehouseEditor, summary, tb_WAREHOUSE.MODIFYBY);
                DataBinder.BindingTextEdit(txtWarehouseEditTime, summary, tb_WAREHOUSE.MODIFYTIME);
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
            string sql="AND ISDELETED=0 ";
            if(txtId.Text!="")
            {
                sql+= string.Format(" and CODE like '%{0}%' ", txtId.Text);
            }
            if(txt_Name.Text!="")
            {
                sql+= string.Format(" and NAME like '%{0}%' ", txtId.Text);
            }
            if(txtSpec.Text!="")
            {
                sql+= string.Format(" and ADDRESS like '%{0}%' ", txtId.Text);
            }
            
            this.DoBindingSummaryGrid(this._BllInstance.FuzzySearch(sql)); //绑定主表的Grid
            this.ShowSummaryPage(true); //显示Summary页面. 
        }

    }
}
