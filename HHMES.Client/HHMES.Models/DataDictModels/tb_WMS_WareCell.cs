using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_WareCell的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-05 09:01:00
 *   最后修改: 2016-10-05 09:01:00
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_WareCell,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_WareCell", "WareCell_Name", true)]
    public sealed class tb_WMS_WareCell
    {
        public static string __TableName ="WMS_WareCell";

        public static string __KeyName = "WareCell_Name";

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,true,true,true,false,false)]
        public static string WareCell_Name = "WareCell_Name"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string WareCell_Warehouse = "WareCell_Warehouse"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string WareCell_Zone = "WareCell_Zone"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string WareCell_State = "WareCell_State"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string WareCell_Spec = "WareCell_Spec"; 

        [ORM_FieldAttribute(SqlDbType.Decimal,9,false,true,false,false,false)]
        public static string WareCell_MaxWeight = "WareCell_MaxWeight"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string WareCell_Row = "WareCell_Row"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string WareCell_Column = "WareCell_Column"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string WareCell_Layer = "WareCell_Layer"; 

        [ORM_FieldAttribute(SqlDbType.Char,1,false,true,false,false,false)]
        public static string WareCell_IsStop = "WareCell_IsStop"; 


    }
}