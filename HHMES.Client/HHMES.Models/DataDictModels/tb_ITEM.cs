using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.ORM;

namespace HHMES.Models
{


    /*==========================================
     *   程序说明: tb_ITEM的ORM模型
     *   作者姓名: HHMES.com
     *   创建日期: 2018-04-27 09:50:33
     *   最后修改: 2018-04-27 09:50:33
     *   
     *   注: 本代码由ClassGenerator自动生成
     *   版权所有 HHMES.com
     *==========================================*/

    ///<summary>
    /// ORM模型, 数据表:ITEM,由ClassGenerator自动生成
    /// </summary>
    [ORM_ObjectClassAttribute("ITEM", "ID", true)]
    public sealed class tb_ITEM
    {
        public static string __TableName = "ITEM";

        public static string __KeyName = "ID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, true, false, false)]
        public static string ID = "ID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, true, true, false, false, false)]
        public static string CODE = "CODE";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, true, false)]
        public static string COMPANYID = "COMPANYID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, true, true, false, true, false)]
        public static string WAREHOUSEID = "WAREHOUSEID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 1000, true, true, false, false, false)]
        public static string NAME = "NAME";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, true, true, false, false, false)]
        public static string BARCODE = "BARCODE";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string DAYSTOEXPIRE = "DAYSTOEXPIRE";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string EXPIRINGDAYS = "EXPIRINGDAYS";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string MINSHELFLIFEDAYS = "MINSHELFLIFEDAYS";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string CSQTY = "CSQTY";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CSDESC = "CSDESC";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string CSLENGTH = "CSLENGTH";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string CSWIDTH = "CSWIDTH";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string CSHEIGHT = "CSHEIGHT";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string CSWEIGHT = "CSWEIGHT";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string CSVOLUME = "CSVOLUME";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, false, false)]
        public static string PLQTY = "PLQTY";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string PLDESC = "PLDESC";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string PLLENGTH = "PLLENGTH";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string PLWIDTH = "PLWIDTH";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string PLHEIGHT = "PLHEIGHT";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string PLWEIGHT = "PLWEIGHT";

        [ORM_FieldAttribute(SqlDbType.Decimal, 9, false, true, false, false, false)]
        public static string PLVOLUME = "PLVOLUME";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string TIHI = "TIHI";

        [ORM_FieldAttribute(SqlDbType.Bit, 1, false, true, false, false, false)]
        public static string ENABLE = "ENABLE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF1 = "USERDEF1";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF2 = "USERDEF2";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF3 = "USERDEF3";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF4 = "USERDEF4";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF5 = "USERDEF5";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string USERDEF6 = "USERDEF6";

        [ORM_FieldAttribute(SqlDbType.Bit, 1, false, true, false, false, false)]
        public static string IQCTYPE = "IQCTYPE";

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

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string ALLOCATIONRULE_STRATEGY_HEADERID = "ALLOCATIONRULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string REPLENISHMENTRULE_STRATEGY_HEADERID = "REPLENISHMENTRULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string MOVERULE_STRATEGY_HEADERID = "MOVERULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string RECEIPTRULE_STRATEGY_HEADERID = "RECEIPTRULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string WARECELLRULE_STRATEGY_HEADERID = "WARECELLRULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string ROADWAYRULE_STRATEGY_HEADERID = "ROADWAYRULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.Int, 4, false, true, false, true, false)]
        public static string ZONERULE_STRATEGY_HEADERID = "ZONERULE_STRATEGY_HEADERID";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CLASS01 = "CLASS01";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CLASS02 = "CLASS02";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string CLASS03 = "CLASS03";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string BRAND = "BRAND";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string ITEMSIZE = "ITEMSIZE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string ITEMCOLOR = "ITEMCOLOR";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string ITEMSTYLE = "ITEMSTYLE";

        [ORM_FieldAttribute(SqlDbType.NVarChar, 100, false, true, false, false, false)]
        public static string PLACEOFORIGIN = "PLACEOFORIGIN";

    }
}