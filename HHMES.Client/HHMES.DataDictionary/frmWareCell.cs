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
    public partial class frmWARECELL : HHMES.Library.frmBaseDataDictionary
    {
        private bllWARECELL _BllInstance ;
        public frmWARECELL()
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
            _ActiveEditor = txtCODE;
            _KeyEditor = txtCODE;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllWARECELL(); //业务逻辑实例
            _BllInstance = _BLL as bllWARECELL; //本窗体引用
            base.InitializeForm();

            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板


            DataBinder.BindingLookupEditDataSource(R_PALLETID, DataDictCache.GetCacheTableData("PALLET"), "NAME","ID");
            DataBinder.BindingLookupEditDataSource(R_ROADWAYID, DataDictCache.GetCacheTableData("ROADWAY"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(R_STATUS_CFG, DataDictCache.GetCacheConfigData("WARECELL_STATUS"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(R_WARECELLSPECID, DataDictCache.GetCacheTableData("WARECELLSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(R_ZONEID, DataDictCache.GetCacheTableData("ZONE"), "NAME", "ID");

            DataBinder.BindingLookupEditDataSource(S_PALLETID, DataDictCache.GetCacheTableData("PALLET"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(S_ROADWAYID, DataDictCache.GetCacheTableData("ROADWAY"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(S_STATUS_CFG, DataDictCache.GetCacheConfigData("WARECELL_STATUS"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(S_WARECELLSPECID, DataDictCache.GetCacheTableData("WARECELLSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(S_ZONEID, DataDictCache.GetCacheTableData("ZONE"), "NAME", "ID");

            DataBinder.BindingLookupEditDataSource(E_PALLETID, DataDictCache.GetCacheTableData("PALLET"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(E_ROADWAYID, DataDictCache.GetCacheTableData("ROADWAY"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(E_STATUS_CFG, DataDictCache.GetCacheConfigData("WARECELL_STATUS"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(E_WARECELLSPECID, DataDictCache.GetCacheTableData("WARECELLSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(E_ZONEID, DataDictCache.GetCacheTableData("ZONE"), "NAME", "ID");
            
           
            DataBinder.BindingLookupEditDataSource(P_WARECELLSPECID, DataDictCache.GetCacheTableData("WARECELLSPEC"), "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(P_ZONEID, DataDictCache.GetCacheTableData("ZONE"), "NAME", "ID");

            labelAdmin.Visible = Loginer.CurrentUser.IsAdmin();
        }

        protected override void ButtonStateChanged(UpdateType currentState)
        {
            base.ButtonStateChanged(currentState);
           
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtCODE.Text == string.Empty)
            {
                Msg.Warning("货柜编号不能为空!");
                txtCODE.Focus();
                return false;
            }

            if (E_ZONEID.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("区域为空!");
                E_ZONEID.Focus();
                return false;
            }
            if (E_WARECELLSPECID.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("货柜状态不能为空!");
                E_WARECELLSPECID.Focus();
                return false;
            }
            if (E_STATUS_CFG.EditValue.ToString() == string.Empty)
            {
                Msg.Warning("货柜状态不能为空!");
                E_STATUS_CFG.Focus();
                return false;
            }
            if (E_NROW.Text == "" || E_NCOLUMN.Text == "" || E_NLAYER.Text == "")
            {
                Msg.Warning("排列层不能为空!");
                E_NROW.Focus();
                return false;
            }

            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtCODE.Text))
                {
                    Msg.Warning("货柜编号已存在!");
                    txtCODE.Focus();
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
                DataBinder.BindingTextEdit(txtCODE, summary, tb_WARECELL.CODE);
                DataBinder.BindingTextEdit(E_ZONEID, summary, tb_WARECELL.ZONEID);
                DataBinder.BindingTextEdit(E_PALLETID, summary, tb_WARECELL.PALLETID);
                DataBinder.BindingTextEdit(E_WARECELLSPECID, summary, tb_WARECELL.WARECELLSPECID);

                DataBinder.BindingTextEdit(E_STATUS_CFG, summary, tb_WARECELL.STATUS_CFG);
                DataBinder.BindingTextEdit(E_ROADWAYID, summary, tb_WARECELL.ROADWAYID);                

                DataBinder.BindingTextEdit(E_NROW, summary, tb_WARECELL.NROW);
                DataBinder.BindingTextEdit(E_NCOLUMN, summary, tb_WARECELL.NCOLUMN);
                DataBinder.BindingTextEdit(E_NLAYER, summary, tb_WARECELL.NLAYER );

                DataBinder.BindingCheckEdit(E_ENABLE, summary, tb_WARECELL.ENABLE);
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
                sqlCondition = " ";
                if (S_CODE.Text != "")
                {
                    sqlCondition += string.Format(" And CODE like '%{0}%' ", S_CODE.Text.Trim());
                }
                if (S_ZONEID.EditValue != null && S_ZONEID.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And ZONEID = '{0}' ", S_ZONEID.EditValue.ToString());
                }
                if (S_ROADWAYID.EditValue != null && S_ROADWAYID.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And ROADWAYID = '{0}' ", S_ROADWAYID.EditValue.ToString());
                } 
                if (S_STATUS_CFG.EditValue != null && S_STATUS_CFG.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And STATUS_CFG = '{0}' ", S_STATUS_CFG.EditValue.ToString());
                }
                if (S_WARECELLSPECID.EditValue != null && S_WARECELLSPECID.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And WARECELLSPECID = '{0}' ", S_WARECELLSPECID.EditValue.ToString());
                }
                if (S_PALLETID.EditValue != null && S_PALLETID.EditValue.ToString() != string.Empty)
                {
                    sqlCondition += string.Format(" And PALLETID = '{0}' ", S_PALLETID.EditValue.ToString());
                }
                if (S_ENABLE.CheckState == CheckState.Checked)
                {
                    sqlCondition += (" And ENABLE ='1' ");
                }
                else
                {
                    sqlCondition += (" And WareCell_IsStop ='0' ");
                }

                DataTable dt = (_BLL as bllWARECELL).FuzzySearch(sqlCondition);
                DoBindingSummaryGrid(dt); //绑定主表的Grid
                ShowSummaryPage(true); //显示Summary页面.                         
                return dt != null && dt.Rows.Count > 0;
            }
            catch (Exception ex) { Msg.ShowException(ex); return false; };
        }


        private void labelAdmin_Click(object sender, EventArgs e)
        {
            if (Loginer.CurrentUser.Account.ToUpper() == ("ADMIN").ToUpper())
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string msg = "";
            try
            {
                (_BLL as bllWARECELL).CreateWARECELL(IP, client, user, P_ZONEID.EditValue.ToString(), P_WARECELLSPECID.EditValue.ToString(),
                    int.Parse(PS_NROW.Text), int.Parse(PS_NCOLUMN.Text), int.Parse(PS_NLAYER.Text),
                    int.Parse(PE_NROW.Text), int.Parse(PE_NCOLUMN.Text), int.Parse(PE_NLAYER.Text), out msg);
                Msg.ShowInformation(msg);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
            
        }
        
    }
}
