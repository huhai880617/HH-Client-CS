using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace HHMES.Common
{
    /// <summary>
    /// Windows启动项目管理
    /// </summary>
    public class WinStartItems
    {
        const string REG_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        /// <summary>
        /// 取程序安装位置
        /// </summary>
        /// <param name="registName">键名</param>
        /// <returns></returns>
        public static string GetRegistData(string registName)
        {
            string registData;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(REG_PATH, true);
            registData = ConvertEx.ToString(key.GetValue(registName));
            return registData;
        }

        /// <summary>
        /// 取注册表启动项的启动项目名称
        /// </summary>
        /// <returns></returns>
        public static string[] GetRegistName()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(REG_PATH, true);
            return key.GetValueNames();
        }

        /// <summary>
        /// 将程序的开机启动写入注册表
        /// </summary>
        /// <param name="runName">启动项目名称</param>
        /// <param name="starupPath">程序文件名</param>
        /// <returns></returns>
        public static bool RegistStartItem(string runName, string starupPath)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(REG_PATH, true);
                key.SetValue(runName, starupPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
