using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_WMS_Task的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2016/12/15 04:59:57
     *   最后修改: 2016/12/15 04:59:57
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Task,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_Task", "Task_Id", true)]
    public sealed class tb_WMS_Task
    {
        public static string __TableName = "WMS_Task";

        public static string __KeyName = "Task_Id";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string Task_Id = "Task_Id";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Task_OpcNo = "Task_OpcNo";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_BillNo = "Task_BillNo";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_PalletId = "Task_PalletId";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string Task_TaskType = "Task_TaskType";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Task_OptionStation = "Task_OptionStation";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Task_PortNum = "Task_PortNum";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Task_TaskStatus = "Task_TaskStatus";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_FromWareCell = "Task_FromWareCell";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_ToWareCell = "Task_ToWareCell";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Task_PriorityFirst = "Task_PriorityFirst";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Task_PrioritySecond = "Task_PrioritySecond";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 300, false, true, false, false, false)]
        public static string Task_Remark = "Task_Remark";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string Task_CreatorDate = "Task_CreatorDate";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_CreatedBy = "Task_CreatedBy";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string Task_StartDate = "Task_StartDate";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_StartBy = "Task_StartBy";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string Task_FinishDate = "Task_FinishDate";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Task_FinishBy = "Task_FinishBy";

        [ORM_FieldAttribute(SqlDbType.Char, 1, false, true, false, false, false)]
        public static string Task_AccountType = "Task_AccountType";

    }
}
