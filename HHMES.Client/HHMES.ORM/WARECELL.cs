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
    
    public partial class WARECELL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WARECELL()
        {
            this.INVENTORY_HISTORY = new HashSet<INVENTORY_HISTORY>();
            this.TASK_HEADER = new HashSet<TASK_HEADER>();
            this.TASK_HEADER1 = new HashSet<TASK_HEADER>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public Nullable<int> PALLETID { get; set; }
        public int ZONEID { get; set; }
        public int WARECELLSPECID { get; set; }
        public int STATUS_CFG { get; set; }
        public int NROW { get; set; }
        public int NCOLUMN { get; set; }
        public int NLAYER { get; set; }
        public int ROADWAYID { get; set; }
        public string REMARK { get; set; }
        public bool ENABLE { get; set; }
        public string DEFINE01 { get; set; }
        public string DEFINE02 { get; set; }
        public string DEFINE03 { get; set; }
        public string DEFINE04 { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        public virtual CONFIG_DETAIL CONFIG_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTORY_HISTORY> INVENTORY_HISTORY { get; set; }
        public virtual PALLET PALLET { get; set; }
        public virtual ROADWAY ROADWAY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK_HEADER> TASK_HEADER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TASK_HEADER> TASK_HEADER1 { get; set; }
        public virtual WARECELLSPEC WARECELLSPEC { get; set; }
        public virtual ZONE ZONE { get; set; }
    }
}