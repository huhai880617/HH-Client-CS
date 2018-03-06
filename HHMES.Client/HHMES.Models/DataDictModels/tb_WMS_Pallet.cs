using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_Pallet的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-05 09:00:31
 *   最后修改: 2016-10-05 09:00:31
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Pallet,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_Pallet", "Pallet_No", true)]
    public sealed class tb_WMS_Pallet
    {
        public static string __TableName ="WMS_Pallet";

        public static string __KeyName = "Pallet_No";

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,true,true,true,false,false)]
        public static string Pallet_No = "Pallet_No"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string Pallet_PrintQty = "Pallet_PrintQty";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Pallet_UseQty = "Pallet_UseQty"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,200,false,true,false,false,false)]
        public static string Pallet_Notes = "Pallet_Notes"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Pallet_Spec = "Pallet_Spec"; 

        [ORM_FieldAttribute(SqlDbType.Char,1,false,true,false,false,false)]
        public static string Pallet_InUse = "Pallet_IsUse";

        [ORM_FieldAttribute(SqlDbType.VarChar, 20, false, true, false, false, false)]
        public static string Pallet_Status = "Pallet_Status"; 
    }
}