using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace HHMES.Common
{
    /// <summary>
    /// 监视器开关控制
    /// </summary>
    public class MonitorTool
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(
        IntPtr hWnd,
        uint msg,
        uint wParam,
        int lParam);

        //系统消息
        private const uint WM_SYSCOMMAND = 0x112;

        //关闭显示器的系统命令
        private const int SC_MONITORPOWER = 0xF170;

        //2为PowerOff, 1为省电状态，-1为开机
        private const int MonitorPowerOff = 2;

        /// <summary>
        /// 关闭显示器
        /// </summary>
        public static void PowerOff(IntPtr hWnd)
        {
            SendMessage(
            hWnd,
            WM_SYSCOMMAND,
            SC_MONITORPOWER,
            2
            );
        }

        /// <summary>
        /// 打开显示器
        /// </summary>
        public static void PowerOn(IntPtr hWnd)
        {
            SendMessage(
            hWnd,
            WM_SYSCOMMAND,
            SC_MONITORPOWER,
            -1
            );
        }

    }
}
