
using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 系统日志接口
    /// </summary>
    public interface ISystemLog
    {
        /// <summary>
        /// 保存系统异常日志
        /// </summary>
        /// <param name="e">系统异常</param>
        /// <param name="reportUser">当前用户</param>
        void WriteException(Exception e, string reportUser);

        /// <summary>
        /// 其它日志
        /// </summary>
        /// <param name="log">日志内容</param>
        /// <param name="reportUser">当前用户</param>
        void WriteLog(string log, string reportUser);
    }
}
