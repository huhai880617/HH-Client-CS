using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{
    [ORM_ObjectClassAttribute("C_FormTagName", "AUID", true)]
    public class TFormTagName
    {
        public static string __TableName = "C_FormTagName";

        public static string __KeyName = "AUID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, false, true, false, false)]
        public static string AUID = "AUID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 20, false, true, false, false, false)]
        public static string TagName = "TagName";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 20, false, true, false, false, false)]
        public static string MenuName = "MenuName";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string TagValue = "TagValue";

    }
}
