using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_WMS_StockHistory的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2016/12/12 02:21:30
     *   最后修改: 2016/12/12 02:21:30
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_StockHistory,由ClassGenerator自动生成
    /// public ORM_FieldAttribute(SqlDbType type, int size,
   ///         bool islookup, bool isAddorUpdate, bool isPrimaryKey,
   ///       bool isForeignKey, bool isDocFieldName)
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_StockDtl_History", "IsId", true)]
    public sealed class tb_WMS_StockHistory
    {
        public static string __TableName = "WMS_StockDtl_History";

        public static string __KeyName = "IsId";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, false, true, false, false)]
        public static string IsId = "IsId";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, true, true, false, false, false)]
        public static string StockDtl_BillNo = "StockDtl_BillNo";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, false, false)]
        public static string StockDtl_Item = "StockDtl_Item";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, true, true, false, false, false)]
        public static string StockDtl_Batch = "StockDtl_Batch";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, true, true, false, false, false)]
        public static string Stock_PositionId = "Stock_PositionId";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, true, true, false, false, false)]
        public static string StockDtl_PalletId = "StockDtl_PalletId";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, false, false)]
        public static string StockDtl_PalletIdNum = "StockDtl_PalletIdNum";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string StockDtl_Type = "StockDtl_Type";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string StockDtl_Status = "StockDtl_Status";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string StockDtl_MaterialCode = "StockDtl_MaterialCode";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string StockDtl_MaterialName = "StockDtl_MaterialName";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string StockDtl_MaterialQty = "StockDtl_MaterialQty";

        [ORM_FieldAttribute(SqlDbType.Char, 1, false, true, false, false, false)]
        public static string StockDtl_IsLock = "StockDtl_IsLock";

        [ORM_FieldAttribute(SqlDbType.Char, 1, false, true, false, false, false)]
        public static string StockDtl_IsCheck = "StockDtl_IsCheck";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string CreationDate = "CreationDate";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, false, true, false, false, false)]
        public static string CreatedBy = "CreatedBy";

    }
}