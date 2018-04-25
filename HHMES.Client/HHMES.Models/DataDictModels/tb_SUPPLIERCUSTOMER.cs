using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_SUPPLIERCUSTOMER的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2018-03-09 11:30:58
     *   最后修改: 2018-03-09 11:30:58
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:SUPPLIERCUSTOMER,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("SUPPLIERCUSTOMER", "ID", true)]
    public sealed class tb_SUPPLIERCUSTOMER
    {
        public static string __TableName = "SUPPLIERCUSTOMER";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CODE = "CODE";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string WAREHOUSEID = "WAREHOUSEID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string COMPANYID = "COMPANYID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string NAME = "NAME";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string TYPE_CFG = "TYPE_CFG";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 400, false, true, false, false, false)]
        public static string ADDRESS1 = "ADDRESS1";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 400, false, true, false, false, false)]
        public static string ADDRESS2 = "ADDRESS2";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CITY = "CITY";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string STATE = "STATE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string COUNTRY = "COUNTRY";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string POSTALCODE = "POSTALCODE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string ATTENTIONTO = "ATTENTIONTO";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string PHONENUM = "PHONENUM";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string MOBILE = "MOBILE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string FAXNUM = "FAXNUM";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string EMAIL = "EMAIL";

        [ORM_FieldAttribute(SqlDbType.Bit, 1, false, true, false, false, false)]
        public static string ENABLE = "ENABLE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF1 = "USERDEF1";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF2 = "USERDEF2";

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