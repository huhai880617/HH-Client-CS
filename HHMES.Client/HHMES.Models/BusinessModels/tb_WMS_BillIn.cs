using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_Bill的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-21 10:18:01
 *   最后修改: 2016-10-21 10:18:01
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Bill,由ClassGenerator自动生成
    /// 表名，主键，主表
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_BillIn", "Bill_BillNo", true)]
    public sealed class tb_WMS_BillIn
    {
        public static string __TableName ="WMS_BillIn";

        public static string __KeyName = "Bill_BillNo";

        // public ORM_FieldAttribute(SqlDbType type, int size, bool islookup, bool isAddorUpdate, bool isPrimaryKey, bool isForeignKey, bool isDocFieldName);
        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,true,false,true)]
        public static string Bill_BillNo = "Bill_BillNo"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Bill_BillType = "Bill_BillType"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Bill_BillLinkNo = "Bill_BillLinkNo";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Bill_Batch = "Bill_Batch";

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Bill_WarehouseId = "Bill_WarehouseId"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Bill_DepartmentId = "Bill_DepartmentId"; 


        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Bill_CustomeId = "Bill_CustomeId"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Bill_CustomeName = "Bill_CustomeName"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string Bill_WorkStatus = "Bill_WorkStatus";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string VerNo = "Bill_VerNo"; 


        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string Bill_QcCheckStatus = "Bill_QcCheckStatus"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Bill_Deliver = "Bill_Deliver"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Bill_Remark = "Bill_Remark"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string CreationDate = "CreationDate"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string CreatedBy = "CreatedBy"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string LastUpdateDate = "LastUpdateDate"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string LastUpdatedBy = "LastUpdatedBy"; 

        [ORM_FieldAttribute(SqlDbType.Char,1,false,true,false,false,false)]
        public static string FlagApp = "FlagApp"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string AppUser = "AppUser"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string AppDate = "AppDate"; 

    }
}