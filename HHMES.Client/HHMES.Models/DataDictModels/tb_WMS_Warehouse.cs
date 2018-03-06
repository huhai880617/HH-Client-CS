using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_Warehouse的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-09-29 03:01:27
 *   最后修改: 2016-09-29 03:01:27
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Warehouse,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_Warehouse", "Warehouse_Id", true)]
    public sealed class tb_WMS_Warehouse
    {
        public static string __TableName ="WMS_Warehouse";

        public static string __KeyName = "Warehouse_Id";

        //[ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        //public static string IsId = "IsId"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Warehouse_Id = "Warehouse_Id"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Warehouse_Name = "Warehouse_Name"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Warehouse_Location = "Warehouse_Location"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,200,false,true,false,false,false)]
        public static string Warehouse_Notes = "Warehouse_Notes"; 

        [ORM_FieldAttribute(SqlDbType.Char,1,false,true,false,false,false)]
        public static string Warehouse_IsUse = "Warehouse_IsUse"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Warehouse_EditWho = "Warehouse_EditWho"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string Warehouse_EditTime = "Warehouse_EditTime"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Warehouse_Creator = "Warehouse_Creator"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string Warehouse_CreateTime = "Warehouse_CreateTime"; 

    }
}