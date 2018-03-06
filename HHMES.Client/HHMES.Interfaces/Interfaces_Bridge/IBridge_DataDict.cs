using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HHMES.Common;

namespace HHMES.Interfaces
{
    public interface IBridge_DataDict
    {
        DataTable GetDataByKey(string key);
        DataTable GetSummaryData();
        DataTable GetDataDictByTableName(string tableName);
        DataTable ExecuteSqlText(string sqlcmd, string tableName);
        DataSet DownloadDicts();
        DataSet ExecuteProcedure(string sqlcmd);
        bool Update(DataSet data);
        SaveResultEx UpdateEx(DataSet data);
        bool Delete(string keyValue);
        bool CheckNoExists(string keyValue);
        bool CheckNoExists(string TableName, string SqlCondition);
        
        Type ORM { get; set; }
        string TableName { get; set; }
    }
}
