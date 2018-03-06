using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using HHMES.Core;
using HHMES.Library;
using HHMES.Common;
using HHMES.Business;
using HHMES.Models;
using HHMES.Interfaces;

namespace HHMES.TaskModule
{
    public partial class frmTaskAppendIn : HHMES.Library.frmBaseBusinessForm
    {
        public frmTaskAppendIn()
        {
            InitializeComponent();
            
        }
        private void frmTaskAllOut_Load(object sender, EventArgs e)
        {
            InitializeForm();//自定义初始化窗体操作   
        }

        private  string sqlConst = "select * from WMS_Task Where 1=1";
        /// <summary>
        /// 初始化窗体///
        /// </summary>
        protected override void InitializeForm()
        {
           // //_BLL = new bllWMS_Bill();// 业务逻辑层实例
           _BLL = new bllWMS_Task();
           _SummaryView = new DevGridView(gvSummary);
           _ActiveEditor = textTaskId;
           _DetailGroupControl = panelControl1;

           base.InitializeForm(); //这行代码放到初始化变量后最好

            frmGridCustomize.RegisterGrid(gvSummary);
            frmGridCustomize.AddMenuItem(gvSummary,"入库任务新建",null,OnTaskAllInNewClick,true);
            frmGridCustomize.AddMenuItem(gvSummary, "任务下发", null, OnTaskAssignClick2, true);
            frmGridCustomize.AddMenuItem(gvSummary, "入库口入库", null, OnTaskArrivalPort_InClick, true);
            frmGridCustomize.AddMenuItem(gvSummary, "到达入库站台", null, OnTaskArrivalStation_InClick, true);
            frmGridCustomize.AddMenuItem(gvSummary, "堆垛机接收任务", null, OnTaskScReceiveClick, true);
            frmGridCustomize.AddMenuItem(gvSummary, "堆垛机完成任务", null, OnTaskScFinishClick, true);
            frmGridCustomize.AddMenuItem(gvSummary, "达到出库站台", null, OnTaskArrivalStation_OutClick, true);
            frmGridCustomize.AddMenuItem(gvSummary, "达到出库口", null, OnTaskArrivalPort_OutClick, true);
            frmGridCustomize.AddMenuItem(gvSummary, "任务过账", null, OnTaskFinishTaskClick, true);
            #region
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskAssign"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "任务下发", null, OnTaskAssignClick, true);
            //}
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskCancel"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "任务取消", null, OnTaskCancelClick, true);
            //}
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskManualAccount"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "手动过账", null, OnTaskAccountByManualClick, true);
            //}
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskStatusModify"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "状态修改", null, OnTaskStatusModifyClick, true);
            //}
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskStationModify"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "站台修改", null, OnTaskStationModifyClick, true);
            //}
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskPortModify"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "出库口修改", null, OnTaskPortNumModifyClick, true);
            //}
            //if (SystemAuthentication.ButtonAuthorized("MenuItemTaskPriorityModify"))
            //{
            //    frmGridCustomize.AddMenuItem(gvSummary, "优先级修改", null, OnTaskPriorityModifyClick, true);
            //}
            #endregion


            DevStyle.SetGridControlLayout(gcSummary, false);//表格设置   
            DevStyle.SetGridControlLayout(gcDetail, true);//表格设置   
            DevStyle.SetSummaryGridViewLayout(gvSummary);
            DevStyle.SetDetailGridViewLayout(gvDetail);
            //主表
            BindingSummaryNavigator(controlNavigatorSummary, gcSummary); //Summary导航条.
            BindingSummarySearchPanel(btnQuery, btnEmpty, gcFindGroup);

            gvSummary.DoubleClick += new EventHandler(OnSeeTask); //主表DoubleClict
            txt_DocDateFrom.DateTime = DateTime.Today.AddDays(-7);
            txt_DocDateTo.DateTime = DateTime.Today.AddDays(1); //查询条件


            DataBinder.BindingLookupEditDataSource(lookUpEditDocType, DataDictCache.Cache.TaskType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEditDocStatus, DataDictCache.Cache.TaskStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEditDocType, DataDictCache.Cache.TaskType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEditDocStatus, DataDictCache.Cache.TaskStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

            _BLL.GetBusinessByKey("-", true);//加载一个空的业务对象.
            DoSearchSummary();
            ShowSummaryPage(true); //一切初始化完毕后显示SummaryPage        
        }


        /// <summary>
        /// 显示主表数据,绑定输入框
        /// </summary>
        protected override void DoBindingSummaryEditor(DataTable dataSource)
        {
            if (dataSource == null) return;
            DataBinder.BindingTextEdit(textTaskId, dataSource, tb_WMS_Task.Task_Id);
            DataBinder.BindingTextEdit(textPortNum, dataSource, tb_WMS_Task.Task_PortNum);
            DataBinder.BindingTextEdit(textTaskNo, dataSource, tb_WMS_Task.Task_OpcNo);
            DataBinder.BindingTextEdit(textStation, dataSource, tb_WMS_Task.Task_OptionStation);
            DataBinder.BindingTextEdit(textFromPosition, dataSource, tb_WMS_Task.Task_FromWareCell);
            DataBinder.BindingTextEdit(textToPosition, dataSource, tb_WMS_Task.Task_ToWareCell);

        }
        public override void InitButtons()
        {
            IButtonInfo[] button = base.GetSystemButtons();
            _buttons.AddRange(button);
        }
        /// <summary>
        /// 双击表格事件
        /// </summary>
        public void OnSeeTask(object sender, EventArgs e)
        {
            try
            {
                if (SystemConfig.CurrentConfig == null) return;
                if (!this.HasData()) return;

                IButtonInfo btn = _buttons.GetButtonByName("btnView");

                this.DoViewContent(btn);
                SetDetailEditorsAccessable(_DetailGroupControl, false);
                SetGridCustomButtonAccessable(gcDetail, false);
            }
            catch { }
        }
        /// <summary>
        /// 搜索数据
        /// </summary> 
        protected override bool DoSearchSummary()
        {
            try
            {
                string sqlCondition = sqlConst;
                sqlCondition += " and Task_TaskType='102' ";
               // sqlCondition += string.Format(" and CreationDate between '{0}' and '{1}' ",txt_DocDateFrom.DateTime,txt_DocDateTo.DateTime.AddDays(1));
                if (txt_DocDateFrom.Text != "" && txt_DocDateTo.Text != "")
                {
                    sqlCondition = sqlCondition + string.Format(" and Task_CreatorDate between '{0}' and '{1}' ", txt_DocDateFrom.Text.Trim(), txt_DocDateTo.Text.Trim());
                }
                //if ((lookUpEditDocType.EditValue != null)&&lookUpEditDocType.EditValue.ToString()!="")
                //{
                //    sqlCondition = sqlCondition + string.Format(" and Task_TaskType='{0}'", lookUpEditDocType.EditValue);
                //}
                if ((lookUpEditDocStatus.EditValue!=null)&&lookUpEditDocStatus.EditValue.ToString()!="")
                {
                    sqlCondition = sqlCondition + string.Format(" and Task_TaskStatus='{0}'", lookUpEditDocStatus.EditValue);
                }
                if (txt_TaskNo.Text != "")
                { 
                    sqlCondition +=string.Format(" and Task_OpcNo = '{0}'",textEditCustomer.Text.Trim());
                }
                if(txt_PalletNo.Text!="")
                {
                    sqlCondition += string.Format(" and Task_PalletId like '%{0}%' ", textEditCustomer.Text.Trim());
                }

                DataTable dt = (_BLL as bllWMS_Task).ExecuteSQL(sqlCondition);
                DoBindingSummaryGrid(dt); //绑定主表的Grid
                ShowSummaryPage(true); //显示Summary页面.                         
                return dt != null && dt.Rows.Count > 0;
            }
            catch (Exception ex) { Msg.ShowException(ex); return false; }
        }


        /// <summary>
        /// 绑定明细表格的数据源
        /// </summary>
        protected override void DoBindingDetailGrid(DataSet dataSource)
        {
            gcDetail.DataSource = null;
            gcDetail.DataSource = dataSource.Tables[tb_WMS_TaskDtl.__TableName];

        }


        #region
        /// <summary>
        /// 任务查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskSeeClick(object sender, EventArgs e)
        { 
            
        }
        /// <summary>
        /// 任务手动过账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskAccountByManualClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 任务下发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskAssignClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 任务取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskCancelClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 任务状态修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskStatusModifyClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 站台修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskStationModifyClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 任务出入库口修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskPortNumModifyClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 任务优先级修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTaskPriorityModifyClick(object sender, EventArgs e)
        {

        }
        #endregion


        private void OnTaskAllInNewClick(object sender, EventArgs e)
        {
            try
            {
                string execSql = "exec Tmp_CreateAllInTask";
                DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                DoSearchSummary();
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskAssignClick2(object sender, EventArgs e)
        {
            try
            {
                string Task_Id= _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Status == "100")
                {
                    string execSql = string.Format("exec Tmp_TaskAssign '{0}','{1}'", Task_Id,Task_Type);
                    DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                    DoSearchSummary();
                }
                else
                {
                    Msg.Warning("任务不是开始状态，你不能进行下发操作！！！");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskArrivalPort_InClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "101")
                {
                    if (Task_Status == "300")
                    {
                        string execSql = string.Format("exec Tmp_ArrivalPort_In '{0}'", Task_Id);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("任务不是下发状态，不能从入库口操作");
                    }
                }
                else
                { 
                    Msg.Warning("不是入库任务，你不能进行该操作！！！");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }
        //
        private void OnTaskArrivalPort_OutClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "201")
                {
                    if (Task_Status == "270")
                    {
                        string execSql = string.Format("exec Tmp_ArrivalPort_Out '{0}'", Task_Id);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("任务不是下发状态，不能从入库口操作");
                    }
                }
                else
                {
                    Msg.Warning("不是入库任务，你不能进行该操作！！！");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskArrivalStation_InClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "101")
                {
                    if (Task_Status == "310")
                    {
                        string execSql = string.Format("exec Tmp_ArrivalStation_In '{0}'", Task_Id);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("任务没有从入库口登记过，禁止操作！！！");
                    }
                }
                else
                {
                    Msg.Warning("不是入库任务，你不能进行该操作！！！");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskArrivalStation_OutClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "201")
                {
                    if (Task_Status == "220")
                    {
                        string execSql = string.Format("exec Tmp_ArrivalStation_Out '{0}'", Task_Id);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("任务堆垛机没有完成，禁止操作！！！");
                    }
                }
                else
                {
                    Msg.Warning("不是出库任务，你不能进行该操作！！！");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskScReceiveClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "101")
                {
                    if (Task_Status == "360")
                    {
                        string execSql = string.Format("exec Tmp_ScReceiveTask '{0}','{1}'", Task_Id,Task_Type);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("任务没有在入库站台请求，禁止操作！！！");
                    }
                }
                else if(Task_Type=="201")
                {
                    if (Task_Status == "200")
                    {
                        string execSql = string.Format("exec Tmp_ScReceiveTask '{0}','{1}'", Task_Id,Task_Type);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("任务没有出库下发，禁止操作！！！");
                    }
                }
                
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskScFinishClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "101")
                {
                    if (Task_Status == "370")
                    {
                        string execSql = string.Format("exec Tmp_ScFinishTask '{0}','{1}'", Task_Id,Task_Type);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("堆垛机没有接收该任务，禁止操作！！！");
                    }
                }
                else if (Task_Type == "201")
                {
                    if (Task_Status == "210")
                    {
                        string execSql = string.Format("exec Tmp_ScFinishTask '{0}','{1}'", Task_Id,Task_Type);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("堆垛机没有接收该任务，禁止操作！！！");
                    }
                }

            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void OnTaskFinishTaskClick(object sender, EventArgs e)
        {
            try
            {
                string Task_Id = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[_BLL.KeyFieldName].ToString();
                string Task_Type = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskType].ToString();
                string Task_Status = _SummaryView.GetDataRow(_SummaryView.FocusedRowHandle)[tb_WMS_Task.Task_TaskStatus].ToString();
                if (Task_Type == "101")
                {
                    if (Task_Status == "390")
                    {
                        string execSql = string.Format("exec Tmp_TaskFinish '{0}','{1}'", Task_Id, Task_Type);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("堆垛机没有完成该任务，禁止操作！！！");
                    }
                }
                else if (Task_Type == "201")
                {
                    if (Task_Status == "290")
                    {
                        string execSql = string.Format("exec Tmp_TaskFinish '{0}','{1}'", Task_Id, Task_Type);
                        DataTable dt = new bllWMS_Task().ExecuteSQL(execSql);
                        DoSearchSummary();
                    }
                    else
                    {
                        Msg.Warning("堆垛机没有完成该任务，禁止操作！！！");
                    }
                }

            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

      
       
    }
}
