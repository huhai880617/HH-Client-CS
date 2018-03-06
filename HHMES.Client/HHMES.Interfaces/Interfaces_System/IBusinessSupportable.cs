
using System;
using System.Collections.Generic;
using System.Text;

namespace HHMES.Interfaces
{
    /// <summary>
    /// 支持业务操作的系统接口
    /// </summary>
    public interface IBusinessSupportable
    {
        /// <summary>
        /// 返回业务单据窗体的按钮数组
        /// </summary>
        /// <returns></returns>
        IButtonInfo[] GetBusinessButtons();

        /// <summary>
        /// (审核)(批准)
        /// </summary>
        /// <param name="button"></param>
        void DoApproval(IButtonInfo button);

        /// <summary>
        /// 查看单据的修改历史记录
        /// </summary>
        /// <param name="button"></param>
        void DoShowModifyHistory(IButtonInfo button);//

        /// <summary>
        /// 显示指定单号的业务单据数据
        /// </summary>
        /// <param name="docNo">单据号码</param>
        void ShowBusiness(string docNo);

    }

}
