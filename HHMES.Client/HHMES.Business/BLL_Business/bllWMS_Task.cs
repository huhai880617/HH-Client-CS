using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using HHMES.Models;
using HHMES.Common;
using HHMES.Interfaces;
using HHMES.Core.Log;
using HHMES.Server.DataAccess;
using HHMES.Core;
using HHMES.Business.BLL_Base;
using HHMES.Bridge;
using HHMES.Interfaces.Interfaces_Bridge;

/*==========================================
 *   程序说明: WMS_Task的业务逻辑层
 *   作者姓名: HHMES.com
 *   创建日期: 2016/12/19 09:24:19
 *   最后修改: 2016/12/19 09:24:19
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有：HHMES.com
 *==========================================*/

namespace HHMES.Business
{
    /// <summary>
    /// bllWMS_Task
    /// </summary>
    public class bllWMS_Task : bllBaseBusiness,IFuzzySearchSupportable
    {
        private IBridge_WMS_Task _Bridge = null;
         /// <summary>
         /// 构造器
         /// </summary>
         public bllWMS_Task()
         {
             _KeyFieldName = tb_WMS_Task.__KeyName; //主键字段
             _SummaryTableName = tb_WMS_Task.__TableName;//表名
             _Bridge = this.CreateBridge();//实例化桥接功能
         }

        private IBridge_WMS_Task CreateBridge()
        {
            if (BridgeFactory.BridgeType == BridgeType.ADODirect)
                {
                    return new ADODirect_WMS_Task().GetInstance();
                }
            //if (BridgeFactory.BridgeType == BridgeType.WebService)
            //        return new WebService_WMS_Task();
            return null;
        }

        public DataTable ExecuteSQL(string execSql)
        {
            return _Bridge.ExecuteSQL(execSql);
        }

        public DataTable GetTask(string conditional)
        {
            return _Bridge.GetTask(conditional);
        }

        public DataTable GetTaskDtlByTaskId(int TaskId)
        {
            return _Bridge.GetTaskDtlByTaskId(TaskId);
        }


        public DataTable TaskAssign(int TaskId)
        {
            return _Bridge.TaskAssign(TaskId);
        }

        public DataTable TaskCancel(int TaskId)
        {
            return _Bridge.TaskCancel(TaskId);
        }

        public DataTable TaskStatusModify(int TaskId, int StatusValue)
        {
            return _Bridge.TaskStatusModify(TaskId, StatusValue);
        }

        public DataTable TaskStationModify(int TaskId, int Station)
        { 
            return _Bridge.TaskStationModify(TaskId,Station);
        }

        public DataTable TaskPortNumModify(int TaskId, int PortNum)
        {
            return _Bridge.TaskPortNumModify(TaskId, PortNum);
        }

        public DataTable TaskPriorityModify(int TaskId, int First, int Second)
        {
            return _Bridge.TaskPriorityModify(TaskId, First, Second);
        }

        public DataTable TaskAccountByManual(int TaskId)
        {
            return _Bridge.TaskAccountByManual(TaskId);
        }

        public override bool Delete(string keyValue)
        {
            throw new NotImplementedException();
        }

        public override void NewBusiness()
        {
            throw new NotImplementedException();
        }

        public override void WriteLog(DataSet original, DataSet changes)
        {
            throw new NotImplementedException();
        }

        public override void WriteLog(DataTable original, DataTable changes)
        {
            throw new NotImplementedException();
        }

        public override SaveResult Save(DataSet saveData)
        {
            throw new NotImplementedException();
        }

        public override DataSet GetBusinessByKey(string keyValue, bool resetCurrent)
        {
            DataSet ds = new dalWMS_Task(Loginer.CurrentUser).GetBusinessByKey(keyValue);
            this.SetNumericDefaultValue(ds); //设置预设值
            if (resetCurrent) _CurrentBusiness = ds; //保存当前业务数据的对象引用
            return ds; 
        }

        public override void WriteLog()
        {
            throw new NotImplementedException();
        }

        public override DataSet CreateSaveData(DataSet sourceData, UpdateType currentType)
        {
            throw new NotImplementedException();
        }

        #region IFuzzySearchSupportable Members

        public string FuzzySearchName
        {
            get { return "搜索产品资料"; }
        }

        public DataTable FuzzySearch(string content)
        {
            bllITEM bll = new bllITEM();
            return bll.FuzzySearch(content);
        }

        #endregion
     }
}
