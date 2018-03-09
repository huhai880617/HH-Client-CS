using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{
    [ORM_ObjectClassAttribute("C_UserGroupRe", "ID", true)]
    public class TUserGroupRe
    {
        public static string __TableName = "C_UserGroupRe";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, false, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 30, false, true, false, false, false)]
        public static string GroupCode = "GroupCode";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 30, false, true, false, false, false)]
        public static string Account = "Account";
    }
}
