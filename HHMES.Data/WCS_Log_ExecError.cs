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
    
    public partial class WCS_Log_ExecError
    {
        public string GUID { get; set; }
        public string IP { get; set; }
        public string Client { get; set; }
        public string Loginer { get; set; }
        public string FuncationName { get; set; }
        public string ExecSql { get; set; }
        public Nullable<int> OptType { get; set; }
        public string ErrorMsg { get; set; }
        public Nullable<System.DateTime> ErrorTime { get; set; }
    }
}
