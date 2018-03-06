
using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 发送通知
        /// </summary>
        void Notify();
    }

}
