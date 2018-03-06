using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Business;
using HHMES.DataDictionary;
using HHMES.Interfaces;
using HHMES.Library;
using HHMES.Models;
using HHMES.Common;

namespace HHMES.DataDictionary
{
    public partial class frmWareCell : HHMES.Library.frmBaseDataDictionary
    {
        private bllWMS_WareCell _BllInstance ;
        public frmWareCell()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            this.InitializeForm();
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtCode;
            _KeyEditor = txtCode;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllWMS_WareCell(); //业务逻辑实例
            _BllInstance = _BLL as bllWMS_WareCell; //本窗体引用
            base.InitializeForm();

            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板

            
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit1, DataDictCache.Cache.Location, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit1, DataDictCache.Cache.Location, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit4, DataDictCache.Cache.Location, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit7, DataDictCache.Cache.Location, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit3, DataDictCache.Cache.WareCellSpec, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit3, DataDictCache.Cache.WareCellSpec, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit5, DataDictCache.Cache.WareCellSpec, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit8, DataDictCache.Cache.WareCellSpec, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit2, DataDictCache.Cache.WareCellStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit2, DataDictCache.Cache.WareCellStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEdit6, DataDictCache.Cache.WareCellStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

        }

        protected override void ButtonStateChanged(UpdateType currentState)
        {
            base.ButtonStateChanged(currentState);
            txtCode.Enabled = UpdateType.Add == currentState;
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtCode.Text == string.Empty)
            {
                Msg.Warning("货柜编号不能为空!");
                txtCode.Focus();
                return false;
            }

            if (lookUpEdit4.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("仓库名称为空!");
                lookUpEdit4.Focus();
                return false;
            } 
            
            if (lookUpEdit5.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("货柜规格不能为空!");
                lookUpEdit5.Focus();
                return false;
            }
            if (txtRow.Text == "" || txtColumn.Text == "" || txtLayer.Text == "")
            {
                Msg.Warning("不能为空!");
                lookUpEdit5.Focus();
                return false;
            }

            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtCode.Text))
                {
                    Msg.Warning("托盘编号已存在!");
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
                DataBinder.BindingTextEdit(txtCode, summary, tb_WMS_WareCell.WareCell_Name);
                DataBinder.BindingTextEdit(lookUpEdit4, summary, tb_WMS_WareCell.WareCell_Warehouse);
                DataBinder.BindingTextEdit(lookUpEdit5, summary, tb_WMS_WareCell.WareCell_Spec);
                DataBinder.BindingTextEdit(lookUpEdit6, summary, tb_WMS_WareCell.WareCell_State);

                DataBinder.BindingTextEdit(txtZone, summary, tb_WMS_WareCell.WareCell_Zone);
                DataBinder.BindingTextEdit(txtMaxWeight, summary, tb_WMS_WareCell.WareCell_MaxWeight);

                DataBinder.BindingCheckEdit(chkInUse, summary, tb_WMS_WareCell.WareCell_IsStop);

                DataBinder.BindingTextEdit(txtRow, summary, tb_WMS_WareCell.WareCell_Row);
                DataBinder.BindingTextEdit(txtColumn, summary, tb_WMS_WareCell.WareCell_Column);
                DataBinder.BindingTextEdit(txtLayer, summary, tb_WMS_WareCell.WareCell_Layer);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        /// <summary>
        /// 执行搜索按钮 
        /// </summary>
        private string sqlCondition = "";
        protected override bool DoSearchSummary()
        {
            try
            {
                sqlCondition = "";
                if (txt_Id.Text != "")
                {
                    sqlCondition += string.Format(" And WareCell_Name like '%{0}%' ", txt_Id.Text.Trim());
                }
                if (lookUpEdit1.EditValue != null && lookUpEdit1.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And WareCell_Warehouse like '%{0}%' ", lookUpEdit1.EditValue.ToString());
                }
                if (lookUpEdit2.EditValue != null && lookUpEdit2.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And WareCell_Spec like '%{0}%' ", lookUpEdit2.EditValue.ToString());
                } 
                if (lookUpEdit3.EditValue != null && lookUpEdit3.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And WareCell_Status like '%{0}%' ", lookUpEdit3.EditValue.ToString());
                }
                if (chkInUse.CheckState == CheckState.Checked)
                {
                    sqlCondition += (" And WareCell_IsStop ='Y' ");
                }
                else
                {
                    sqlCondition += (" And WareCell_IsStop ='N' ");
                }

                DataTable dt = (_BLL as bllWMS_Pallet).FuzzySearch(sqlCondition);
                DoBindingSummaryGrid(dt); //绑定主表的Grid
                ShowSummaryPage(true); //显示Summary页面.                         
                return dt != null && dt.Rows.Count > 0;
            }
            catch (Exception ex) { Msg.ShowException(ex); return false; };
        }


        private void labelAdmin_Click(object sender, EventArgs e)
        {
            if (Loginer.CurrentUser.Account.ToUpper() == ("Admin").ToUpper())
            {
                if (labelAdmin.Text == "批量操作>>")
                {
                    panelAdmin.Visible = true;
                    labelAdmin.Text = "批量操作<<";
                }
                else
                {
                    labelAdmin.Text = "批量操作>>";
                    panelAdmin.Visible = false;
                }
            }
            else
            {
                Msg.Warning("对不起你不能执行次操作!!!");
                labelAdmin.Text = "批量操作>>";
                panelAdmin.Visible = false;
            }
        }
    }
}
