
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 支持写入日志的接口
    /// </summary>
    public interface ILogSupportable
    {
        /// <summary>
        /// 写入单表日志
        /// </summary>        
        void WriteLog(DataTable original, DataTable changes);

        /// <summary>
        /// 写入多个表的日志,TableIndex=0:主表,1..n为明细表
        /// </summary>
        /// <param name="changes"></param>
        void WriteLog(DataSet original, DataSet changes);
    }
}
