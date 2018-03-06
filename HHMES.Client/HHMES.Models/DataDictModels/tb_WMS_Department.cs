using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


/*==========================================
 *   程序说明: tb_WMS_Department的ORM模型
 *   作者姓名: HHMES.com
 *   创建日期: 2016-10-05 08:59:29
 *   最后修改: 2016-10-05 08:59:29
 *   
 *   注: 本代码由ClassGenerator自动生成
 *   版权所有 HHMES.com
 *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:WMS_Department,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("WMS_Department", "Department_ID", true)]
    public sealed class tb_WMS_Department
    {
        public static string __TableName ="WMS_Department";

        public static string __KeyName = "Department_ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,true,true,true,false,false)]
        public static string Department_ID = "Department_ID"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Department_Name = "Department_Name"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Department_Attribute = "Department_Attribute"; 

        [ORM_FieldAttribute(SqlDbType.Char,1,false,true,false,false,false)]
        public static string Department_IsStop = "Department_IsStop"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Department_Creator = "Department_Creator"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string Department_CreateTime = "Department_CreateTime"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string Department_Editor = "Department_Editor"; 

        [ORM_FieldAttribute(SqlDbType.DateTime,8,false,true,false,false,false)]
        public static string Department_EditTime = "Department_EditTime"; 

    }
}