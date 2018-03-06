using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Xml;
using DevExpress.UserSkins;
using DevExpress.Skins;
using HHMES.Common;
using HHMES.Business;
using HHMES.Core;
using HHMES.Bridge;
//using Autoupdater;

namespace HHMES.Main
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);//捕获系统所产生的异常。
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            Program.CheckInstance();//检查程序是否运行多实例

            SystemConfig.ReadSettings(); //读取用户自定义设置

            if (false == BridgeFactory.InitializeBridge())//初始化桥接功能
            {
                Application.Exit();
                return;
            }

            BonusSkins.Register();//注册Dev酷皮肤
            OfficeSkins.Register();////注册Office样式的皮肤
            SkinManager.EnableFormSkins();//启用窗体支持换肤特性

            //注意：先打开登陆窗体,登陆成功后正式运行程序(MDI主窗体)            
            if (frmLogin.Login())
            {
               // if (Program.CheckAndDownloadNewVersion() == false)
                {
                    Program.MainForm.Show();
                    Application.Run();
                }
                //else
                //    Application.Exit();
            }
            else//登录失败,退出程序
                Application.Exit();
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (SystemAuthentication.Current != null)
                SystemAuthentication.Current.Logout(); //登出
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Msg.ShowException(e.Exception);//处理系统异常
        }

        private static frmMain _mainForm = null;

        /// <summary>
        /// MDI主窗体
        /// </summary>        
        public static frmMain MainForm { get { return _mainForm; } set { _mainForm = value; } }

        /// <summary>
        ///检查程序是否运行多实例
        /// </summary>
        public static void CheckInstance()
        {
            Boolean createdNew; //返回是否赋予了使用线程的互斥体初始所属权
            Mutex instance = new Mutex(true, Globals.DEF_PROGRAM_NAME, out createdNew); //同步基元变量
            if (createdNew) //首次使用互斥体
            {
                instance.ReleaseMutex();
            }
            else
            {
                if (!SystemConfig.CurrentConfig.AllowRunMultiInstance)
                {
                    Msg.Warning("已经启动了一个程序，请先退出！");
                    Application.Exit();
                    return;
                }
            }
        }

        ///// <summary>
        ///// 检查是否有新版本，有则下载
        ///// </summary>
        //public static bool CheckAndDownloadNewVersion()
        //{
        //    bool bHasError = false;
            
        //    IAutoUpdater autoUpdater = new AutoUpdater();
        //    try
        //    {
        //        autoUpdater.Update();
        //    }
        //    catch (WebException exp)
        //    {
        //        MessageBox.Show("Can not find the specified resource");
        //        bHasError = true;
        //    }
        //    catch (XmlException exp)
        //    {
        //        bHasError = true;
        //        MessageBox.Show("Download the upgrade file error");
        //    }
        //    catch (NotSupportedException exp)
        //    {
        //        bHasError = true;
        //        MessageBox.Show("Upgrade address configuration error");
        //    }
        //    catch (ArgumentException exp)
        //    {
        //        bHasError = true;
        //        MessageBox.Show("Download the upgrade file error");
        //    }
        //    catch (Exception exp)
        //    {
        //        bHasError = true;
        //        MessageBox.Show("An error occurred during the upgrade process");
        //    }
        //    finally
        //    {
        //        if (bHasError == true)
        //        {
        //            try
        //            {
        //                autoUpdater.RollBack();
        //            }
        //            catch (Exception)
        //            {
        //                //Log the message to your file or database
        //            }
        //        }
        //    }
        //    return bHasError;
        //}
    }
}