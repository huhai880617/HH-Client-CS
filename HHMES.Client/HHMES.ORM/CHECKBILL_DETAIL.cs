//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHECKBILL_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHECKBILL_DETAIL()
        {
            this.TASK_DETAIL = new HashSet<TASK_DETAIL>();
        }
    
        public int ID { get; set; }
        public int CHECKBILL_HEADERID { get; set; }
        public int INVENTORYID { get; set; }
        public int PALLETID { get; set; }
        public int ITEMID { get; set; }
        public Nullable<int> REFERENCEDETAIL { get; set; }
        public Nullable<int> WMSTASKHEADER { get; set; }
        public int WAREHOUSEID { get; set; }
        public int COMPANYID { get; set; }
        public int STATUS_CFG { get; set; }
        public bool ISTASKDETAIL { get; set; }
        public string DEFINE01 { get; set; }
        public string DEFINE02 { get; set; }
        public string DEFINE03 { get; set; }
        public string DEFINE04 { get; set; }
        public string DEFINE05 { get; set; }
        public string DEFINE06 { get; set; }
        public int CHECKQTY { get; set; }
        public Nullable<int> CHECKBADQTY { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        public virtual CHECKBILL_HEADER CHECKBILL_HEADER { get; set; }
        public virtual COMPANY COMPANY { get; set; }
        public virtual CONFIG_DETAIL CONFIG_DETAIL { get; set; }
        public virtual INVENTORY INVENTORY { get; set; }
        public virtual ITEM ITEM { get; set; }
        public virtual PALLET PALLET { get; set; }
        public virtual WAREHOUSE WAREHOUSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK_DETAIL> TASK_DETAIL { get; set; }
    }
}
