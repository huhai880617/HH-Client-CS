using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace HHMES.Interfaces
{
    //客户数据层桥接接口
    public interface IBridge_SUPPLIERCUSTOMER
    {
        //模糊查询客户数据
        DataTable SearchBy(string code,  string Name, string type_cfg);

        //由客户类别获取客户数据
        DataTable GetSUPPLIERCUSTOMERByAttributeCodes(string attributeCodes, bool nameWithCode);

        //模糊查询
        DataTable FuzzySearch(string content);

        //模糊查询
        DataTable FuzzySearch(string attributeCodes, string content);
    }
}
