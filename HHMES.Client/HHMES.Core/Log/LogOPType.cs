using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Core.Log
{
    /// <summary>
    /// 系统日志功能跟踪的操作数据类型
    /// </summary>
    public enum LogOPType
    {
        None = 0,

        /// <summary>
        /// 跟踪修改的记录
        /// </summary>
        LogEdit = 1,

        /// <summary>
        /// 跟踪删除的记录
        /// </summary>
        LogDelete = 2,

        /// <summary>
        /// 跟踪新增的记录
        /// </summary>
        LogAppend = 3
    }

}
