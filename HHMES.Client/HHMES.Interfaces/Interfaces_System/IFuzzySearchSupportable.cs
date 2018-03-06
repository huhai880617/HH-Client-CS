
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 支持模糊查询的接口,用于frmFuzzySearch窗体
    /// </summary>
    public interface IFuzzySearchSupportable
    {
        string FuzzySearchName { get; }
        DataTable FuzzySearch(string content);
    }
}
