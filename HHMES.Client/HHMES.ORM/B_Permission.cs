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
    
    public partial class B_Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public B_Permission()
        {
            this.B_ModulePermission = new HashSet<B_ModulePermission>();
            this.B_RoleModulePermission = new HashSet<B_RoleModulePermission>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B_ModulePermission> B_ModulePermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<B_RoleModulePermission> B_RoleModulePermission { get; set; }
    }
}
