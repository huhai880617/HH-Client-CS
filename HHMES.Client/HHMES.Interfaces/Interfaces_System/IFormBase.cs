
using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 基类窗体接口
    /// </summary>
    public interface IFormBase
    {
        /// <summary>
        /// 设置窗体皮肤
        /// </summary>
        void LoadSkin();

        /// <summary>
        /// 设置窗体皮肤
        /// </summary>
        /// <param name="skinName">名称</param>
        void SetSkin(string skinName);
    }
}
