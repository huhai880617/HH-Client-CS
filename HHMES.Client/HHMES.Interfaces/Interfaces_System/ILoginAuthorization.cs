using System;
using System.Collections.Generic;
using System.Text;
using HHMES.Common;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 系统登录策略
    /// </summary>
    public interface ILoginAuthorization
    {
        /// <summary>
        /// 登录,验证用户．
        /// </summary>
        /// <param name="dataSet">登录帐套</param>
        /// <returns></returns>
        bool Login(LoginUser loginUser);

        /// <summary>
        /// 当前登录策略是否支持登出模式
        /// </summary>
        bool SupportLogout { get; }

        /// <summary>
        /// 登出
        /// </summary>
        void Logout();
    }

    /// <summary>
    /// 系统登录用户类型
    /// S, //System Account
    /// W, //Windows Domain Account
    /// N  //Novell Account
    /// </summary>
    public enum LoginUserType
    {
        S, //System Account
        W, //Windows Domain Account
        N  //Novell Account
    }

}
