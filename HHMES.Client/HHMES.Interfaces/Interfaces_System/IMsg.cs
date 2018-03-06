

using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Core
{
    /// <summary>
    /// 消息显示接口
    /// </summary>
    public interface IMsg
    {
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msg"></param>
        void UpdateMessage(string msg);
    }
}
