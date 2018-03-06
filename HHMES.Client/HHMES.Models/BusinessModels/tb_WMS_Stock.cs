using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_WMS_Stock的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2016/12/12 02:18:38
     *   最后修改: 2016/12/12 02:18:38
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Stock,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_Stock", "Stock_PositionId", true)]
    public sealed class tb_WMS_Stock
    {
        public static string __TableName = "WMS_Stock";

        public static string __KeyName = "Stock_PositionId";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, true, true, true, false, false)]
        public static string Stock_PositionId = "Stock_PositionId";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, true, true, false, false, false)]
        public static string Stock_PalletId = "Stock_PalletId";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, false, false)]
        public static string Stock_StockStatus = "Stock_StockStatus";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 40, true, true, false, false, false)]
        public static string Stock_StockType = "Stock_StockType";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string Stock_UpdateTime = "Stock_UpdateTime";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, false, false)]
        public static string Stock_CheckStatus = "Stock_CheckStatus";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string Stock_CheckTime = "Stock_CheckTime";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Stock_PalletIdNum = "Stock_PalletIdNum";

    }
}