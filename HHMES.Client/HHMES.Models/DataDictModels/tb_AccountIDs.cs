using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{
   
    ///<summary>
    /// ORM模型, 数据表:tb_AccountIDs,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("tb_AccountIDs", "AccID", false)]
    public sealed class tb_AccountIDs
    {
        public static string __TableName = "tb_AccountIDs";

        public static string __KeyName = "AccID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, false, false, false, false)]
        public static string ISID = "ISID";

        [ORM_FieldAttribute(SqlDbType.VarChar, 20, false, true, true, false, false)]
        public static string AccID = "AccID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string AccName = "AccName";

    }
}