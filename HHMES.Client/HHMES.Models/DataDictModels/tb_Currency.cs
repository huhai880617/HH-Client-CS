using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    ///<summary>
    /// ORM模型, 数据表:tb_Currency,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("tb_Currency", "Currency", true)]
    public sealed class tb_Currency
    {
        public static string __TableName ="tb_Currency";

        public static string __KeyName = "Currency";

        [ORM_FieldAttribute(SqlDbType.Int,4,false,false,false,false,false)]
        public static string ID = "ID"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,10,false,true,true,false,false)]
        public static string Currency = "Currency"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,20,false,true,false,false,false)]
        public static string CurrencyName = "CurrencyName"; 

    }
}