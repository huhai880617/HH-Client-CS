using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    ///<summary>
    /// ORM模型, 数据表:tb_Location,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("tb_Location", "LocationID", true)]
    public sealed class tb_Location
    {
        public static string __TableName ="tb_Location";

        public static string __KeyName = "LocationID";

        [ORM_FieldAttribute(SqlDbType.Int,4,false,false,false,false,false)]
        public static string ID = "ID"; 

        [ORM_FieldAttribute(SqlDbType.VarChar,20,false,true,false,false,false)]
        public static string LocationID = "LocationID"; 

        [ORM_FieldAttribute(SqlDbType.NVarChar,100,false,true,false,false,false)]
        public static string LocationName = "LocationName"; 

    }
}