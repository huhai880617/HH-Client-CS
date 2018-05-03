using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using HHMES.Library;
using HHMES.Common;
using HHMES.Interfaces;
using HHMES.Core;
using HHMES.Business;
using HHMES.Models;

namespace HHMES.DataDictionary
{
    /// <summary>
    /// 销售员管理(数据字典开发模板窗体)
    /// </summary>
    public partial class frmPallet : frmBaseDataDictionary
    {
        
        public frmPallet()
        {
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            this.InitializeForm();//自定义初始化操作
           
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//给成员变量赋值.每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtCode;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllPALLET();

            base.InitializeForm();
            
            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板

            DataBinder.BindingLookupEditDataSource(txt_Spec, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(rItemLookUpEdit_Spec, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit1, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(lookUpEdit8, DataDictCache.GetCacheTableData("PALLETSPEC"), "NAME", "ID");

            DataBinder.BindingLookupEditDataSource(lookUpEdit2, DataDictCache.GetCacheConfigData("PALLET_STATUS"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(txtPalletStatus, DataDictCache.GetCacheConfigData("PALLET_STATUS"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(rItemLookUpEdit_status, DataDictCache.GetCacheConfigData("PALLET_STATUS"), "NAME", "ID");
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
                Msg.Warning("编号不能为空!");
                txtCode.Focus();
                return false;
            }

            if (lookUpEdit1.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("规格不能为空!");
                lookUpEdit1.Focus();
                return false;
            }

            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtCode.Text))
                {
                    Msg.Warning("编号已存在!");
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
                DataBinder.BindingTextEdit(txtCode, summary, tb_PALLET.CODE);
                DataBinder.BindingTextEdit(txtQty, summary, tb_PALLET.PRINTCOUNT);
                DataBinder.BindingTextEdit(lookUpEdit1, summary,tb_PALLET.PALLETSPECID);
                DataBinder.BindingCheckEdit(chkInUse, summary, tb_PALLET.ENABLE);
                DataBinder.BindingTextEdit(lookUpEdit2, summary, tb_PALLET.STATUS_CFG);
                DataBinder.BindingTextEdit(textNotes, summary, tb_PALLET.REMARK);
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
                sqlCondition=" ";
                if(txt_PalletNo.Text!="")
                {
                    sqlCondition += string.Format(" And CODE like '%{0}%' ",txt_PalletNo.Text.Trim());
                }
                if (txt_Spec.EditValue!=null && txt_Spec.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And PALLETSPECID = '{0}' ", txt_Spec.EditValue.ToString());
                }
                if (txtPalletStatus.EditValue != null && txtPalletStatus.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And STATUS_CFG = '{0}' ", txtPalletStatus.EditValue.ToString());
                }

                DataTable dt = (_BLL as bllPALLET).FuzzySearch(sqlCondition);
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

        /// <summary>
        /// 批量生成托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string msg="";
           
            (_BLL as bllPALLET).CreatePallet(IP,client,user,textEdit10.Text, lookUpEdit8.EditValue.ToString(),  int.Parse(textEdit2.Text), out msg);
            Msg.ShowInformation(msg);
        }

        /// <summary>
        /// 批量删除托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string msg = "";
            (_BLL as bllPALLET).DeletePallet(IP,client,user,textEdit10.Text, lookUpEdit8.EditValue.ToString(), out msg);
            Msg.ShowInformation(msg);
        }


    }
}
