//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WMS_BillOut
    {
        public string Bill_BillNo { get; set; }
        public int Bill_VerNo { get; set; }
        public string Bill_Batch { get; set; }
        public string Bill_BillType { get; set; }
        public string Bill_BillLinkNo { get; set; }
        public string Bill_WarehouseId { get; set; }
        public string Bill_DepartmentId { get; set; }
        public string Bill_CustomeId { get; set; }
        public string Bill_CustomeName { get; set; }
        public Nullable<int> Bill_WorkStatus { get; set; }
        public Nullable<int> Bill_QcCheckStatus { get; set; }
        public string Bill_Deliver { get; set; }
        public string Bill_Remark { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string FlagApp { get; set; }
        public string AppUser { get; set; }
        public Nullable<System.DateTime> AppDate { get; set; }
    }
}
