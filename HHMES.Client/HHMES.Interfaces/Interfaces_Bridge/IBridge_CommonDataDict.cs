using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 共同数据字典表的数据层桥接接口
    /// </summary>
    public interface IBridge_CommonDataDict
    {
        DataTable SearchBy(string dataType);        
        bool AddCommonType(string code, string name);
        bool DeleteCommonType(string code);
        bool IsExistsCommonType(string code);
    }
}
