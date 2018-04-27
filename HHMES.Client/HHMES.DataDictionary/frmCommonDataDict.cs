using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HHMES.Library;
using HHMES.Common;
using HHMES.Business;
using HHMES.Core;
using HHMES.Models;
using DevExpress.XtraEditors.Repository;
using HHMES.Interfaces;

namespace HHMES.DataDictionary
{
    /// <summary>
    /// 公共数据字典窗体 用于管理只有Code,Name的字典数据，以Type分开。
    /// </summary>
    public partial class frmCommonDataDict : frmBaseDataDictionary
    {
        private string tableName="CONFIG_DETAIL";
        public frmCommonDataDict()
        {
            InitializeComponent();
        }

        private void frmCommonDataDict_Load(object sender, EventArgs e)
        {
            this.InitializeForm();//自定义初始化操作            
        }

        protected override void InitializeForm()
        {
            _SummaryView = new DevGridView(gvSummary);//每个业务窗体必需给这个变量赋值.
            _ActiveEditor = txtNativeName;
           // _KeyEditor = txtDataCode;
            _DetailGroupControl = gcDetailEditor;
            _BLL = new bllCommonDataDict(); //业务逻辑实例

            //绑定相关缓存数据
            DataBinder.BindingLookupEditDataSource(txt_CommonType, DataDictCache._DataDictType, "NAME", "ID");
            DataBinder.BindingLookupEditDataSource(txtDataType, DataDictCache._DataDictType, "NAME", "ID");

            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEdit1 as RepositoryItemLookUpEdit,
                DataDictCache._DataDictType, "NAME", "ID");

            base.InitializeForm();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {//搜索数据    
            if (txt_CommonType.EditValue != null)
            {
                ((bllCommonDataDict)_BLL).SearchBy(txt_CommonType.EditValue.ToString(), true);
                this.DoBindingSummaryGrid(_BLL.SummaryTable); //绑定主表的Grid
                this.ShowSummaryPage(true); //显示Summary页面. 
            }
        }

        protected override void ButtonStateChanged(UpdateType currentState)
        {
            base.ButtonStateChanged(currentState);

            //当按钮状态改变时设置Add,Del按钮是否可用
            btnAddCommonType.Enabled = this.IsAddOrEditMode;
            btnDelCommonType.Enabled = this.IsAddOrEditMode;
            //this.SetEditorEnable(txtDataCode, false, true);
            this.SetEditorEnable(txtDataCode, true, true);
        }


        // 检查主表数据是否完整或合法
        protected override bool ValidatingData()
        {
            if (txtDataType.Text == string.Empty)
            {
                Msg.Warning("类型不能為空!");
                txtDataType.Focus();
                return false;
            }

            if (txtNativeName.Text.Trim() == string.Empty)
            {
                Msg.Warning("名称不能為空!");
                txtNativeName.Focus();
                return false;
            }

            if (_UpdateType == UpdateType.Add)
            {
                string sqlCondition = string.Format(" And NAME='{0}' and CODE='{1}'", txtDataType.EditValue, txtDataCode.Text);
                if (_BLL.CheckNoExists("CONFIG_HEADER",sqlCondition))
                {
                    Msg.Warning("编号已存在!");
                    txtDataCode.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 绑定输入框
        /// </summary>
        protected override void DoBindingSummaryEditor(DataTable summary)
        {
            try
            {
                if (summary == null) return;
                DataBinder.BindingTextEdit(txtDataCode, summary, "CODE");
                DataBinder.BindingTextEdit(txtDataType, summary, "CONFIG_HEADERID");
                DataBinder.BindingTextEdit(txtDescription, summary, "DESCRIPTION");
                DataBinder.BindingTextEdit(txtNativeName, summary, "NAME");
                DataBinder.BindingTextEdit(txtSequence, summary, "SEQUENCE");
            }
            catch (Exception ex)
            { Msg.ShowException(ex); }
        }

        //重写保存功能
        public override void DoSave(IButtonInfo sender)
        {
            UpdateLastControl(); //更新最后一个输入控件的数据

            if (!ValidatingData()) return; //检查输入完整性



            //调用UpdateEx扩展方法提交数据，由后台生成主键并返回到客户端。
            SaveResultEx ret = _BLL.UpdateEx(_UpdateType);//调用业务逻辑层的Update方法提交数据

            if (ret.Success)
            {
                _BLL.DataBinder.Rows[0]["ID"] = ret.PrimaryKey;//生成的主键

                this.UpdateSummaryRow(_BLL.DataBinder.Rows[0]); //刷新表格内的数据.                                    
                this._UpdateType = UpdateType.None;
                this.SetViewMode();
                this.ShowDetailPage(false);
                this.ButtonStateChanged(_UpdateType);
                Msg.ShowInformation("保存成功!");
            }
            else
                Msg.Warning("保存失败!");
        }

        public override void DoEdit(IButtonInfo sender)
        {

            base.DoEdit(sender);
        }

        /// <summary>
        /// 检查公共数据字典的类型
        /// </summary>
        /// <returns></returns>
        private bool ValidateCommonType()
        {
            //int id = 0;

            //Int32.TryParse(txtCommonTypeId.Text, out id);
            //if (id == 0)
            //{
            //    Msg.Warning("编号必须大于0!");
            //    txtCommonTypeId.Focus();
            //    return false;
            //}
            String id = txtCommonTypeId.Text;
            bool exists = ((bllCommonDataDict)_BLL).IsExistsCommonType(id);
            if (exists)
            {
                Msg.Warning("编号已存在!");
                txtCommonTypeId.Focus();
                return false;
            }

            if (txtCommonTypeName.Text.Trim() == string.Empty)
            {
                Msg.Warning("名称不能為空!");
                txtCommonTypeName.Focus();
                return false;
            }

            return true;
        }

        private void btnAddCommonType_Click(object sender, EventArgs e)
        {
            if (false == ValidateCommonType()) return;

            //增加一个字典类型
            bool success = (_BLL as bllCommonDataDict).AddCommonType(txtCommonTypeId.Text, txtCommonTypeName.Text);
            if (success)
            {
                DataDictCache.RefreshCache();
                Msg.ShowInformation("新增成功！");
            }
        }

        private void btnDelCommonType_Click(object sender, EventArgs e)
        {
            //int id = 0;

            //Int32.TryParse(txtCommonTypeId.Text, out id);
            //if (id == 0)
            //{
            //    Msg.Warning("编号必须大于0!");
            //    txtCommonTypeId.Focus();
            //    return;
            //}

            if (false == Msg.AskQuestion("确认要删除 '" + txtCommonTypeId.Text + "' 的记录!")) return;

            //删除字典类型
            bool success = (_BLL as bllCommonDataDict).DeleteCommonType(txtCommonTypeId.Text);
            if (success)
            {
                //DataDictCache.Cache.DeleteCacheRow(tb_CommDataDictType.__TableName, tb_CommDataDictType.__KeyName, txtCommonTypeId.Text);
                Msg.ShowInformation("删除成功！");
            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            base.ClearContainerEditorText(btnEmpty.Parent);
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDataCode_Leave(object sender, EventArgs e)
        {
            if (txtDataCode.Text != "")
            {
                if (_UpdateType == UpdateType.Add)
                {
                    string sqlCondition = string.Format("AND ISDELETED=0 And NAME='{0}' and Code='{1}'", txtDataType.EditValue, txtDataCode.Text);
                    if (_BLL.CheckNoExists(tableName, sqlCondition))
                    {
                        Msg.Warning("编号已存在!");
                        txtDataCode.Focus();
                    }
                }
            }
        }
    }
}
