using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_WMS_TaskDtl的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2016/12/15 05:02:14
     *   最后修改: 2016/12/15 05:02:14
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_TaskDtl,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_TaskDtl", "ID", true)]
    public sealed class tb_WMS_TaskDtl
    {
        public static string __TableName = "WMS_TaskDtl";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string TaskDtl_TaskId = "Task_Id";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string TaskDtl_PalletId = "TaskDtl_PalletId";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string TaskDtl_MaterialCode = "TaskDtl_MaterialCode";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string TaskDtl_MaterialName = "TaskDtl_MaterialName";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string TaskDtl_MaterialQty = "TaskDtl_MaterialQty";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string TaskDtl_WorkStatus = "TaskDtl_WorkStatus";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Bill_BillNo = "Bill_BillNo";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Bill_BillItem = "Bill_BillItem";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Bill_BillType = "Bill_BillType";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string Bill_LinkNo = "Bill_LinkNo";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Bill_LinkItem = "Bill_LinkItem";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string CreationDate = "CreationDate";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string CreatedBy = "CreatedBy";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string LastUpdateDate = "LastUpdateDate";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string LastUpdatedBy = "LastUpdatedBy";

    }
}