//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHMES.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_MyUser
    {
        public int isid { get; set; }
        public string Account { get; set; }
        public string NovellAccount { get; set; }
        public string DomainName { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public Nullable<System.DateTime> LastLogoutTime { get; set; }
        public Nullable<short> IsLocked { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string FlagAdmin { get; set; }
        public string FlagOnline { get; set; }
        public Nullable<int> LoginCounter { get; set; }
        public string DataSets { get; set; }
    }
}
