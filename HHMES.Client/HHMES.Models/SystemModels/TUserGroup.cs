using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{
    [ORM_ObjectClassAttribute("C_UserGroup", "GroupCode", true)]
    public class TUserGroup
    {
        public static string __TableName = "C_UserGroup";

        public static string __KeyName = "GroupCode";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, false, false, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 30, false, true, false, false, false)]
        public static string GroupCode = "GroupCode";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string GroupName = "GroupName";

    }

    public class BusinessDataSetIndex
    {
        public const int Groups = 0;
        public const int GroupUsers = 1;
        public const int GroupAuthorities = 2;
        public const int GroupAvailableUser = 3;
    }
}
