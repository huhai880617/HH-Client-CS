using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 支持执行存储过程的接口
    /// </summary>
    public interface IExecuteProcedure
    {
         DataSet ExecuteProcedure( SqlCommand sqlcmd);
    }
}
