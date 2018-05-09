using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_SERIAL_NUMBER的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2018-05-04 03:56:45
     *   最后修改: 2018-05-04 03:56:45
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:SERIAL_NUMBER,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("SERIAL_NUMBER", "ID", true)]
    public sealed class tb_SERIAL_NUMBER
    {
        public static string __TableName = "SERIAL_NUMBER";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string PRIMARYFIELD = "PRIMARYFIELD";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string PREFIX = "PREFIX";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string SUFFIX = "SUFFIX";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 2, false, true, false, false, false)]
        public static string PADDINGCHAR = "PADDINGCHAR";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 2, false, true, false, false, false)]
        public static string PADDINGPOS = "PADDINGPOS";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string LENGTH = "LENGTH";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string MINID = "MINID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string MAXID = "MAXID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string CURRENTVALUES = "CURRENTVALUES";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string ISSERIAL = "ISSERIAL";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 2, false, true, false, false, false)]
        public static string RESTBYDAY = "RESTBYDAY";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 2, false, true, false, false, false)]
        public static string RESTBYWEEK = "RESTBYWEEK";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 2, false, true, false, false, false)]
        public static string RESTBYMONTH = "RESTBYMONTH";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 2, false, true, false, false, false)]
        public static string RESTBYYEAR = "RESTBYYEAR";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string YYMMDD = "YYMMDD";

        [ORM_FieldAttribute(SqlDbType.DateTime, 8, false, true, false, false, false)]
        public static string MODIFITIME = "MODIFITIME";

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