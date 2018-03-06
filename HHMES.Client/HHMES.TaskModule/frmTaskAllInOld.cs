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
    public partial class frmTaskAllInOld: HHMES.Library.frmBaseBusinessForm
    {
        public frmTaskAllInOld()
        {
            InitializeComponent();
        }

        private void frmWMS_Bill_Load(object sender, EventArgs e)
        {
            InitializeForm();//自定义初始化窗体操作    
        }

        public static  string sqlConst = "";
        /// <summary>
        /// 初始化窗体///
        /// </summary>
        protected override void InitializeForm()
        {
           // //_BLL = new bllWMS_Bill();// 业务逻辑层实例
           _BLL = new bllWMS_Task();
           _SummaryView = new DevGridView(gvSummary);
           _ActiveEditor = txtTaskId;
           _DetailGroupControl = panelControl1;

           base.InitializeForm(); //这行代码放到初始化变量后最好

            frmGridCustomize.RegisterGrid(gvSummary);
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskSee"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "任务查看", null, OnTaskSeeClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskAssign"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "任务下发", null, OnTaskAssignClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskCancel"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "任务取消", null, OnTaskCancelClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskManualAccount"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "手动过账", null, OnTaskAccountByManualClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskStatusModify"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "状态修改", null, OnTaskStatusModifyClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskStationModify"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "站台修改", null, OnTaskStationModifyClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskPortModify"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "出库口修改", null, OnTaskPortNumModifyClick, true);
            }
            if (SystemAuthentication.ButtonAuthorized("MenuItemTaskPriorityModify"))
            {
                frmGridCustomize.AddMenuItem(gvSummary, "优先级修改", null, OnTaskPriorityModifyClick, true);
            }
           
            

            DevStyle.SetGridControlLayout(gcSummary, false);//表格设置   
            DevStyle.SetGridControlLayout(gcDetail, true);//表格设置   
            DevStyle.SetSummaryGridViewLayout(gvSummary);
            DevStyle.SetDetailGridViewLayout(gvDetail);
            //主表
            BindingSummaryNavigator(controlNavigatorSummary, gcSummary); //Summary导航条.
            BindingSummarySearchPanel(btnQuery, btnEmpty, gcFindGroup);
           // //从表
           // gcDetail.EmbeddedNavigator.ButtonClick += new NavigatorButtonClickEventHandler(this.OnEmbeddedNavigatorButtonClick); //表格按钮事件
           // gvDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(OnCellValueChanged); //表格值改变
           // gvSummary.DoubleClick += new EventHandler(OnGridViewDoubleClick); //主表DoubleClict
            txt_DocDateFrom.DateTime = DateTime.Today.AddDays(-7);
            txt_DocDateTo.DateTime = DateTime.Today.AddDays(1); //查询条件


            DataBinder.BindingLookupEditDataSource(lookUpEditDocType, DataDictCache.Cache.TaskType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(lookUpEditDocStatus, DataDictCache.Cache.TaskStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEditDocType, DataDictCache.Cache.TaskType, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);
            DataBinder.BindingLookupEditDataSource(repositoryItemLookUpEditDocStatus, DataDictCache.Cache.TaskStatus, tb_CommonDataDict.NativeName, tb_CommonDataDict.DataCode);

           

           // (colIsId.ColumnEdit as RepositoryItemButtonEdit).ButtonClick += new ButtonPressedEventHandler(OnStockCode_ButtonClick);
           // (colIsId.ColumnEdit as RepositoryItemButtonEdit).Validating += new CancelEventHandler(OnStockCode_Validating);
            //sqlConst=string.Format(" and Task_CreatorDate between '{0}' and '{1}'",txt_DocDateFrom.DateTime,txt_DocDateTo.DateTime);
            //((bllWMS_Task)_BLL).GetTask(sqlConst);
            _BLL.GetBusinessByKey("-", true);//加载一个空的业务对象.

            ShowSummaryPage(true); //一切初始化完毕后显示SummaryPage        
        }


        //protected override void SetViewMode()
        //{
        //    base.SetViewMode();
        //}

        //protected override void SetEditMode()
        //{
        //    base.SetEditMode();
        //}

        //public override void InitButtons()
        //{
        //    base.InitButtons();
            
        //}
        public override void SetButtonAuthority()
        {
            base.SetButtonAuthority();
        }

        //private void OnStockCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{//打开产品查询窗体
        //    frmFuzzySearch.Execute(sender as ButtonEdit, this._BLL as bllWMS_BillIn, this.SearchStockCallBack);
        //}

        private void OnStockCode_Validating(object sender, CancelEventArgs e)
        {
            if (this.IsAddOrEditMode == false) return;
            if (string.IsNullOrEmpty((sender as ButtonEdit).Text)) return;

            string stockCode = (sender as ButtonEdit).Text.Trim();
            DataTable dt = new bllWMS_Material().GetDataByKey(stockCode); //验证产品编号是否正确
            if (dt.Rows.Count > 0)
                this.SearchStockCallBack(dt.Rows[0]);
            else
            {
                e.Cancel = true;
                Msg.Warning("产品编号不存在！");
            }
        }

        /// <summary>
        /// 选择产品资料，设置当前产品相关信息
        /// </summary>        
        private void SearchStockCallBack(DataRow resultRow)
        {
            if (resultRow == null) return;
            int H = gvDetail.FocusedRowHandle;

            //gvDetail.SetRowCellValue(H, colD_ProductCode, ConvertEx.ToString(resultRow[tb_WMS_Material.ProductCode]));
            //gvDetail.SetRowCellValue(H, colD_ProductName, ConvertEx.ToString(resultRow[tb_WMS_Material.ProductName]));
            //gvDetail2.SetRowCellValue(H, colIsId, ConvertEx.ToString(resultRow[tb_WMS_Material.Material_Code]));
            //gvDetail2.SetRowCellValue(H, colBillDtlMaterialName, ConvertEx.ToString(resultRow[tb_WMS_Material.Material_Name]));
            //gvDetail2.SetRowCellValue(H, colBillDtlMaterialQty, 1);
            //gvDetail2.SetRowCellValue(H, colBillDtlMaterialBarcode, Convert.ToString(resultRow[tb_WMS_Material.Material_barcode]));
            //gvDetail2.SetRowCellValue(H, colBillDtlMaterialUnit, Convert.ToString(resultRow[tb_WMS_Material.Material_Unit]));
            //gvDetail2.UpdateCurrentRow();
        }

        /// <summary>
        /// 改变按钮状态
        /// </summary>
        protected override void ButtonStateChanged(UpdateType currentState)
        {
            //自动赋值的字段，不能手动更改
            //txtINNO.Enabled = false;
            //chkFlagApp.Enabled = false;
            //txtAppDate.Enabled = false;
            //txtAppUser.Enabled = false;

            ////设置编辑明细页面的控件
            //this.SetDetailEditorsAccessable(panelDetailPage, this.DataChanged);
            //base.SetGridCustomButtonAccessable(gcDetail2, this.DataChanged);

            //lbStateName.Text = this.GetStateName();

            //SetEditorEnable(txtSupplierName, false, true);
        }

        protected override void SetDetailEditorsAccessable(Control panel, bool value)
        {
            base.SetDetailEditorsAccessable(panel, value);
            base.SetGridCustomButtonAccessable(gcDetail, value);
        }

        /// <summary>
        /// 显示主表数据,绑定输入框
        /// </summary>
        protected override void DoBindingSummaryEditor(DataTable dataSource)
        {
            if (dataSource == null) return;
            //DataBinder.BindingTextEdit(lookUpEditDocType1, dataSource, tb_WMS_BillIn.Bill_BillType);
            //DataBinder.BindingTextEdit(txtINNO, dataSource, tb_WMS_BillIn.Bill_BillNo);
            //DataBinder.BindingTextEdit(txtDocDate, dataSource, tb_WMS_BillIn.CreationDate);
            //DataBinder.BindingTextEdit(txtDocUser, dataSource, tb_WMS_BillIn.CreatedBy);
            //DataBinder.BindingTextEdit(txtRemark, dataSource, tb_WMS_BillIn.Bill_Remark);
            //DataBinder.BindingTextEdit(txtAppUser, dataSource, tb_WMS_BillIn.AppUser);
            //DataBinder.BindingTextEdit(txtAppDate, dataSource, tb_WMS_BillIn.AppDate);
            //DataBinder.BindingCheckEdit(chkFlagApp, dataSource, tb_WMS_BillIn.FlagApp);
            //DataBinder.BindingTextEdit(txtDeliver, dataSource, tb_WMS_BillIn.Bill_Deliver);
            //DataBinder.BindingTextEdit(txtDepartment, dataSource, tb_WMS_BillIn.Bill_DepartmentId);
            //DataBinder.BindingTextEdit(LookUpEditWarehouseId, dataSource, tb_WMS_BillIn.Bill_WarehouseId);
            //DataBinder.BindingTextEdit(txtRefNo, dataSource, tb_WMS_BillIn.Bill_BillLinkNo);
            //DataBinder.BindingTextEdit(txtSupplierCode, dataSource, tb_WMS_BillIn.Bill_CustomeId);
            //DataBinder.BindingTextEdit(txtSupplierName, dataSource, tb_WMS_BillIn.Bill_CustomeName);
        }

        public override void DoSave(IButtonInfo sender)// 保存数据
        {
            this.UpdateLastControl();//更新最后一个输入框的数据

            if (!ValidatingSummaryData(_BLL.CurrentBusiness.Tables[tb_WMS_BillIn.__TableName])) return; //检查主表数据合法性
            if (!ValidatingDetailData(_BLL.CurrentBusiness.Tables[tb_WMS_BillInDtl.__TableName])) return; //检查从表数据合法性

            //注意:只有修改状态下保存修改日志
            if (_UpdateType == UpdateType.Modify) _BLL.WriteLog();

            //创建用于保存的临时数据
            DataSet dsTemplate = _BLL.CreateSaveData(_BLL.CurrentBusiness, _UpdateType);
            SaveResult result = _BLL.Save(dsTemplate);//调用业务逻辑保存数据方法

            if (result.Success) //保存成功, 不需要重新加载数据，更新当前的缓存数据就行．
            {
                if (_UpdateType == UpdateType.Add)
                {
                    _BLL.DataBindRow[tb_WMS_BillIn.__KeyName] = result.DocNo; //更新单据号码
                    //_BLL.DataBindRow[tb_WMS_Bill.Bill_BillType] = lookUpEditDocType1.Text;
                }
                if (_UpdateType == UpdateType.Modify) _BLL.NotifyUser();//修改后短信或Email通知制单人

                this.UpdateSummaryRow(_BLL.DataBindRow);//刷新表格内当前记录的缓存数据.
                this.DoBindingSummaryEditor(_BLL.DataBinder); //重新显示数据
                if (_UpdateType == UpdateType.Add) gvSummary.MoveLast(); //如是新增单据,移动到取后一条记录.
                base.DoSave(sender); //调用基类的方法. 此行代码应放较后位置.                    
                Msg.ShowInformation("保存成功!");
            }
            else
                Msg.Warning("保存失败!");
        }

        protected override void CreateOneDetail(GridView gridView, int buttonIndex)
        {
            //因需要取OrderID,Append状态下要将光标移到最后一行方可获取正确OrderID
            //if (buttonIndex == DetailButtons.Add) gvDetail2.MoveLast();
            //if (gvDetail2.RowCount == 0) buttonIndex = DetailButtons.Add;

            //DataRow row = _BLL.CurrentBusiness.Tables[tb_WMS_BillInDtl.__TableName].NewRow();
            //string order = new GenerateSortID().Generate(gvDetail2, NItem); //生成排序编号
            //row[tb_WMS_BillInDtl.BillDtl_NItem] = order; //排序编号

            //if (buttonIndex == DetailButtons.Add)
            //{
            //    _BLL.CurrentBusiness.Tables[tb_WMS_BillInDtl.__TableName].Rows.Add(row); //增加一条明细记录
            //    gcDetail2.RefreshDataSource();
            //    gvDetail2.FocusedRowHandle = gvDetail2.RowCount - 1;
            //}
            //else if (buttonIndex == DetailButtons.Insert)
            //{
            //    //插入一条明细记录
            //    _BLL.CurrentBusiness.Tables[tb_WMS_BillInDtl.__TableName].Rows.InsertAt(row, gvDetail2.FocusedRowHandle);
            //    gvDetail2.FocusedRowHandle = gvDetail2.FocusedRowHandle - 1;
            //}
            //gvDetail2.FocusedColumn = gvDetail2.VisibleColumns[0];

        }

        /// <summary>
        /// 检查主表资料输入合法
        /// </summary>
        private bool ValidatingSummaryData(DataTable summary)
        {
            //if (string.IsNullOrEmpty(txtDocUser.Text))
            //{
            //    Msg.Warning("制单人不能为空!");
            //    txtDocUser.Focus();
            //    return false;
            //}

            //if (txtDocDate.DateTime == DateTime.MinValue)
            //{
            //    Msg.Warning("入仓日期不能为空!");
            //    txtDocDate.Focus();
            //    return false;
            //}

            //if (txtSupplierCode.Text == String.Empty)
            //{
            //    Msg.Warning("供应商品不能为空!");
            //    txtSupplierCode.Focus();
            //    return false;
            //}

            //if (txtDepartment.Text == String.Empty)
            //{
            //    Msg.Warning("部门不能为空!");
            //    txtDepartment.Focus();
            //    return false;
            //}

            //if (LookUpEditWarehouseId.Text == String.Empty)
            //{
            //    Msg.Warning("仓库不能为空!");
            //    LookUpEditWarehouseId.Focus();
            //    return false;
            //}

            //if (txtDeliver.Text == String.Empty)
            //{
            //    Msg.Warning("交货人不能为空!");
            //    txtDeliver.Focus();
            //    return false;
            //}

            return true;
        }

        /// <summary>
        /// 检查所有明细表，参数details为所有表，Index=0为主表，1..n为明细
        /// </summary>
        private bool ValidatingDetailData(DataTable detail)
        {
            int i = 0;

            foreach (DataRow row in detail.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                if (ConvertEx.ToString(row[tb_WMS_BillInDtl.BillDtl_MaterialCode]) == string.Empty)
                {
                    gcDetail.Focus();
                    gvDetail.FocusedRowHandle = i;
                   // gvDetail2.FocusedColumn = colIsId;
                    Msg.Warning("货品编号不能为空!");
                    return false;
                }

                if (ConvertEx.ToInt(row[tb_WMS_BillInDtl.BillDtl_MaterialQty]) == 0)
                {
                    gcDetail.Focus();
                    gvDetail.FocusedRowHandle = i;
                   // gvDetail2.FocusedColumn = colBillDtlMaterialQty;
                    Msg.Warning("数量不正确！");
                    return false;
                }

                i++;
            }
            return true;
        }

        /// <summary>
        /// 搜索数据
        /// </summary> 
        protected override bool DoSearchSummary()
        {
            try
            {
                string sqlCondition = sqlConst;
               // sqlCondition += string.Format(" and CreationDate between '{0}' and '{1}' ",txt_DocDateFrom.DateTime,txt_DocDateTo.DateTime.AddDays(1));
                if (txt_TaskNo.Text != "" && txt_PalletNo.Text != "")
                {
                    sqlCondition = sqlCondition + string.Format(" and Bill_BillNo between '{0}' and '{1}' ", txt_TaskNo.Text.Trim(), txt_PalletNo.Text.Trim());
                }
                if ((lookUpEditDocType.EditValue != null))
                {
                    sqlCondition = sqlCondition + string.Format(" and Bill_BillType='{0}'", lookUpEditDocType.EditValue);
                }
                if ((lookUpEditDocStatus.EditValue!=null))
                {
                    sqlCondition = sqlCondition + string.Format(" and Bill_WorkStatus='{0}'", lookUpEditDocStatus.EditValue);
                }
                if (textEditCustomer.Text != "")
                { 
                    sqlCondition +=string.Format(" and Bill_CustomeName like '%{0}%' ",textEditCustomer.Text.Trim());
                }
                if(txt_BatchNo.Text!="")
                {
                    sqlCondition += string.Format(" and Bill_BillLinkNo like '%{0}%' ", textEditCustomer.Text.Trim());
                }

                DataTable dt = (_BLL as bllWMS_BillIn).GetSummaryByParam(sqlCondition);
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
            gcDetail.DataSource = dataSource.Tables[tb_WMS_BillInDtl.__TableName];
        }

        /// <summary>
        ///当子表表格数据更改时，如果是单价或数量改变，重新计算合计
        /// </summary>        
        private void OnCellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //if ((e.Column == colIsId) || (e.Column == colBillDtlMaterialQty))
            //{
            //    //
            //}
        }

        private void txtSupplierCode_OnSetResult(DataRow resultRow)
        {
            //在客户控件内输入编号，返回客户的资料行。
            //
            //在这里可以设置客户的联系人，送货地址等信息            
        }


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


    }
}
