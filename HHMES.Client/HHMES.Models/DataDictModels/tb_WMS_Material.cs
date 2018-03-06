using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_Material的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-05 09:00:05
 *   最后修改: 2016-10-05 09:00:05
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Material,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_Material", "Material_Code", true)]
    public sealed class tb_WMS_Material
    {
        public static string __TableName ="WMS_Material";

        public static string __KeyName = "Material_Code";

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,true,true,true,false,false)]
        public static string Material_Code = "Material_Code"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Material_barcode = "Material_barcode"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Material_Name = "Material_Name"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Material_Type = "Material_Type"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Material_Attribute = "Material_Attribute"; 

        [ORM_FieldAttribute(SqlDbType.Char,1,false,true,false,false,false)]
        public static string Material_IsStop = "Material_IsStop";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Material_StockLife = "Material_StockLife"; 

        [ORM_FieldAttribute(SqlDbType.Char, 1, false, true, false, false, false)]
        public static string Material_IsNeedCheck = "Material_IsNeedCheck";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Material_CombinQty = "Material_CombinQty";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Material_UpperQty = "Material_UpperQty";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Material_LowerQty = "Material_LowerQty";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Material_Weight_g = "Material_Weight_g";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string Material_Size_LxWxH_cm = "Material_Size_LxWxH_cm";

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Material_Unit = "Material_Unit";

        [ORM_FieldAttribute(SqlDbType.Float, 8, false, true, false, false, false)]
        public static string Material_ActPrice = "Material_ActPrice";

        [ORM_FieldAttribute(SqlDbType.Float, 8, false, true, false, false, false)]
        public static string Material_PrePrice = "Material_PrePrice";

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Material_Creator = "Material_Creator"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string Material_CreateTime = "Material_CreateTime"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Material_Editor = "Material_Editor"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string Material_EditTime = "Material_EditTime";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 300, false, true, false, false, false)]
        public static string Material_Remark = "Material_Remark";

    }
}