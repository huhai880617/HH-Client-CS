using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{

    ///<summary>
    /// ORM模型, 数据表:sys_BusinessTables,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("sys_BusinessTables", "isid", true)]
    public sealed class sys_BusinessTables
    {
        public static string __TableName ="sys_BusinessTables";

        public static string __KeyName = "isid";

        [ORM_FieldAttribute(SqlDbType.Int,4,false,false,true,false,false)]
        public static string isid = "isid"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string ModuleID = "ModuleID"; 

        [ORM_FieldAttribute(SqlDbType.Int,4,false,true,false,false,false)]
        public static string SortID = "SortID"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string FormName = "FormName"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,100,false,true,false,false,false)]
        public static string FormNameSpace = "FormNameSpace"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string FormCaption = "FormCaption"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string KeyFieldName = "KeyFieldName"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string Table1 = "Table1"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Table1Name = "Table1Name"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string Table2 = "Table2"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Table2Name = "Table2Name"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string Table3 = "Table3"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Table3Name = "Table3Name"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string Table4 = "Table4"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Table4Name = "Table4Name"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,50,false,true,false,false,false)]
        public static string Table5 = "Table5"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string Table5Name = "Table5Name"; 

    }
}