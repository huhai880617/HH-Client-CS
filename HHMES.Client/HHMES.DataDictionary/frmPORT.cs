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
    public partial class frmPORT : frmBaseDataDictionary
    {
        
        public frmPORT()
        {
            InitializeComponent();
        }

        private void frmROADWAY_Load(object sender, EventArgs e)
        {
            this.InitializeForm();//自定义初始化操作
           
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//给成员变量赋值.每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtCode;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllPORT();

            base.InitializeForm();
            
            BindingSummarySearchPanel(btnQuery, btnEmpty, panelSearch);//绑定搜索面板

            //DataBinder.BindingLookupEditDataSource(S_ROADWAYID, DataDictCache.GetCacheTableData("ROADWAY"), "NAME", "ID");
            //DataBinder.BindingLookupEditDataSource(E_ROADWAYID, DataDictCache.GetCacheTableData("ROADWAY"), "NAME", "ID");
            //DataBinder.BindingLookupEditDataSource(R_ROADWAYID, DataDictCache.GetCacheTableData("ROADWAY"), "NAME", "ID");

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
            if (txtName.Text == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                txtName.Focus();
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
                DataBinder.BindingTextEdit(txtCode, summary, tb_PORT.CODE);
                DataBinder.BindingTextEdit(txtName, summary, tb_PORT.NAME);
               
                DataBinder.BindingCheckEdit(E_ENABLE, summary, tb_PORT.ENABLE);
                DataBinder.BindingCheckEdit(E_ISINPORT, summary, tb_PORT.ISINPORT);
                DataBinder.BindingCheckEdit(E_ISOUTPORT, summary, tb_PORT.ISOUTPORT);
                DataBinder.BindingCheckEdit(E_ISCHECKPORT, summary, tb_PORT.ISCHECKPORT);
                DataBinder.BindingCheckEdit(E_ISSORTPORT, summary, tb_PORT.ISSORTPORT);
                DataBinder.BindingCheckEdit(E_ISSEEPORT, summary, tb_PORT.ISSEEPORT);
                DataBinder.BindingCheckEdit(E_ISINVENTORYPORT, summary, tb_PORT.ISINVENTORYPORT);
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
                if(txt_CODE.Text!="")
                {
                    sqlCondition += string.Format(" And CODE like '%{0}%' ",txt_CODE.Text.Trim());
                }
              
                DataTable dt = (_BLL as bllPORT).FuzzySearch(sqlCondition);
                DoBindingSummaryGrid(dt); //绑定主表的Grid
                ShowSummaryPage(true); //显示Summary页面.                         
                return dt != null && dt.Rows.Count > 0;
            }
            catch (Exception ex) { Msg.ShowException(ex); return false; };
        }

        

    }
}
