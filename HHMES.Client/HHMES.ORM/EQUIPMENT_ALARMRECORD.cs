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
    
    public partial class EQUIPMENT_ALARMRECORD
    {
        public int ID { get; set; }
        public int EQUIPMENT_ALARMTEXTID { get; set; }
        public System.DateTime RECORD_STAMP { get; set; }
        public Nullable<int> POSITIONID { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        public virtual EQUIPMENT_ALARMTEXT EQUIPMENT_ALARMTEXT { get; set; }
        public virtual POSITION POSITION { get; set; }
    }
}
