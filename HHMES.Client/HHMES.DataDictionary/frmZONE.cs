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
            _ActiveEditor = txtZONEId;
            _KeyEditor = txtZONEId;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllZONE(); //业务逻辑实例
            _BllInstance = _BLL as bllZONE; //本窗体引用

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
                DataBinder.BindingTextEdit(txtZONEId, summary, tb_ZONE.CODE);
                DataBinder.BindingTextEdit(txtZONEName, summary, tb_ZONE.NAME);
                DataBinder.BindingTextEdit(txtZONEPosition, summary, tb_ZONE.ADDRESS);
                
                //DataBinder.BindingTextEdit(chkZONE_Status, summary, tb_ZONE.ZONE_Status);
                DataBinder.BindingCheckEdit(chkZONE_Status, summary, tb_ZONE.ENABLE);
                DataBinder.BindingTextEdit(txtZONECreator, summary, tb_ZONE.CREATEBY);
                DataBinder.BindingTextEdit(txtZONECreateTime, summary, tb_ZONE.CREATETIME);
                DataBinder.BindingTextEdit(txtZONEEditor, summary, tb_ZONE.MODIFYBY);
                DataBinder.BindingTextEdit(txtZONEEditTime, summary, tb_ZONE.MODIFYTIME);
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtZONEId.Text == string.Empty)
            {
                Msg.Warning("编号不能为空!");
                txtZONEId.Focus();
                return false;
            }

            if (txtZONEName.Text.Trim() == string.Empty)
            {
                Msg.Warning("名称不能为空!");
                txtZONEName.Focus();
                return false;
            }


            if (_UpdateType == UpdateType.Add)
            {
                if (_BLL.CheckNoExists(txtZONEId.Text))
                {
                    Msg.Warning("编号已存在!");
                    txtZONEId.Focus();
                    return false;
                }
            }
            return true;
        }

           

        public override void DoAdd(IButtonInfo sender)
        {
            base.DoAdd(sender);
            SetEditorBindingValue(txtZONECreator, Loginer.CurrentUser.Account);
            SetEditorBindingValue(txtZONECreateTime,ConvertEx.ToCharYYYY_MM_DD_HHMMSS(DateTime.Now));
        }

        public override void DoEdit(IButtonInfo sender)
        {
           base.DoEdit(sender);
           SetEditorBindingValue(txtZONEEditor, Loginer.CurrentUser.Account);
           SetEditorBindingValue(txtZONEEditTime, ConvertEx.ToCharYYYY_MM_DD_HHMMSS(DateTime.Now));
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
