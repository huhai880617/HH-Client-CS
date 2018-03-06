using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    ///<summary>
    /// ORM模型, 数据表:tb_PayType,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("tb_PayType", "PayType", true)]
    public sealed class tb_PayType
    {
        public static string __TableName ="tb_PayType";

        public static string __KeyName = "PayType";

        [ORM_FieldAttribute(SqlDbType.Int,4,false,false,false,false,false)]
        public static string isid = "isid"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,10,false,true,true,false,false)]
        public static string PayType = "PayType"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,40,false,true,false,false,false)]
        public static string TypeName = "TypeName"; 

    }
}