using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HHMES.Common;
using HHMES.Core;
using HHMES.Interfaces;

namespace HHMES.Interfaces
{
    public interface IBridge_WMS_Task
    {
        DataSet GetBusinessByKey(string keyValue);

        DataTable GetSummaryByParam(string Condition);

        DataTable ExecuteSQL(string execSql);

        DataTable GetTask(string conditional);

        DataTable GetTaskDtlByTaskId(int TaskId);


        DataTable TaskAssign(int TaskId);

        DataTable TaskCancel(int TaskId);

        DataTable TaskStatusModify(int TaskId,int StatusValue);

        DataTable TaskStationModify(int TaskId, int Station);

        DataTable TaskPortNumModify(int TaskId, int PortNum);

        DataTable TaskPriorityModify(int TaskId, int First, int Second);

        DataTable TaskAccountByManual(int TaskId);

    }
}
