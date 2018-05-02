using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_ZONE的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2018-05-01 08:47:20
     *   最后修改: 2018-05-01 08:47:20
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:ZONE,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("ZONE", "ID", true)]
    public sealed class tb_ZONE
    {
        public static string __TableName = "ZONE";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, true, true, false, false, false)]
        public static string CODE = "CODE";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, true, false)]
        public static string WAREHOUSEID = "WAREHOUSEID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string NAME = "NAME";

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