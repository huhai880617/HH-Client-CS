
using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 支持权限功能的接口
    /// </summary>
    public interface IPurviewControllable
    {
        /// <summary>
        /// 设置窗体权限
        /// </summary>
        void SetButtonAuthority();

        /// <summary>
        /// 窗体按钮访问权限
        /// </summary>
        bool ButtonAuthorized(int authorityValue);

        /// <summary>
        /// 检查当前用户是否拥有本窗体的特定权限
        /// </summary>
        /// <param name="value">需要检查的权限值</param>
        /// <returns></returns>
        bool HasPurview(int value);

        /// <summary>
        /// 子窗体拥有的权限
        /// </summary>
        int FormAuthorities { get; set; }

        /// <summary>
        /// 打开本窗体的菜单名
        /// </summary>
        string FormMenuName { get; set; }
    }

}
