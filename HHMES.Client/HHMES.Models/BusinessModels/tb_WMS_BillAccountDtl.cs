using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_BillDtl的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-21 10:17:41
 *   最后修改: 2016-10-21 10:17:41
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_BillInDtl,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_BillAccountDtl", "ID", false)]
    public sealed class tb_WMS_BillAccountDtl
    {
        public static string __TableName ="WMS_BillAccountDtl";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int,4,false,false,true,false,false)]
        public static string ID = "ID"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,true,false)]
        public static string BillDtl_BillNo = "Bill_BillNo";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string BillDtl_LinkNo = "BillDtl_LinkNo";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string BillDtl_LinkItem = "BillDtl_LinkItem"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string BillDtl_MaterialCode = "BillDtl_MaterialCode"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string BillDtl_MaterialName = "BillDtl_MaterialName"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string BillDtl_MaterialBarcode = "BillDtl_MaterialBarcode"; 

        [ORM_FieldAttribute(SqlDbType.NChar,20,false,true,false,false,false)]
        public static string BillDtl_MaterialUnit = "BillDtl_MaterialUnit"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string BillDtl_MaterialQty = "BillDtl_MaterialQty";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string BillDtl_NItem = "BillDtl_NItem"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string BillDtl_WorkStatus = "BillDtl_WorkStatus"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string BillDtl_OptionQty = "BillDtl_OptionQty"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string BillDtl_FinishQty = "BillDtl_FinishQty"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string BillDtl_CheckStatus = "BillDtl_CheckStatus"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string BillDtl_CheckQty = "BillDtl_CheckQty"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string CreationDate = "CreationDate"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string CreatedBy = "CreatedBy"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string LastUpdateDate = "LastUpdateDate"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string LastUpdatedBy = "LastUpdatedBy"; 

    }
}