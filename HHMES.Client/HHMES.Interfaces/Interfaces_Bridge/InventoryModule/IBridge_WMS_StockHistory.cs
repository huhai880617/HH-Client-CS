using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace HHMES.Interfaces
{
    public interface IBridge_WMS_StockHistory
    {
        System.Data.DataTable FuzzySearch(string content);

    }
}
