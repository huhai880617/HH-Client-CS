using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_PALLETSPEC的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2018-05-01 08:42:09
     *   最后修改: 2018-05-01 08:42:09
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:PALLETSPEC,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("PALLETSPEC", "ID", true)]
    public sealed class tb_PALLETSPEC
    {
        public static string __TableName = "PALLETSPEC";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CODE = "CODE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string NAME = "NAME";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 6, false, true, false, false, false)]
        public static string PREFIX = "PREFIX";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string LENGTH = "LENGTH";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string WIDTH = "WIDTH";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string HEIGHT = "HEIGHT";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string WEIGHT = "WEIGHT";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string VOLUME = "VOLUME";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string TYPE = "TYPE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 300, false, true, false, false, false)]
        public static string REMARK = "REMARK";

        [ORM_FieldAttribute(SqlDbType.Bit, 1, false, true, false, false, false)]
        public static string ENABLE = "ENABLE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string DEFINE01 = "DEFINE01";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string DEFINE02 = "DEFINE02";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string DEFINE03 = "DEFINE03";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string DEFINE04 = "DEFINE04";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string DEFINE05 = "DEFINE05";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string DEFINE06 = "DEFINE06";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CREATEBY = "CREATEBY";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string CREATETIME = "CREATETIME";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string MODIFYBY = "MODIFYBY";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string MODIFYTIME = "MODIFYTIME";

        [ORM_FieldAttribute(SqlDbType.Bit, 1, false, true, false, false, false)]
        public static string ISDELETED = "ISDELETED";

    }
}