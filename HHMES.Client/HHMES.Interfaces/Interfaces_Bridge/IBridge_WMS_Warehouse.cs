using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    public interface IBridge_WMS_Warehouse
    {
        System.Data.DataTable FuzzySearch(string content);
    }
}
