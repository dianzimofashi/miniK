using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;
using GIS应用系统.窗体;

namespace GIS应用系统
{
    static class Program
    {
       
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);//添加许可
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

            //显示Login
            using (frmLogin loginForm = new frmLogin())
            {
                DialogResult result = loginForm.ShowDialog();
                // 判断登录结果
                if (result == DialogResult.OK)
                {
                    // 登录成功，打开主窗体
                    Application.Run(new frmMain());
                }
                else
                {
                    // 登录失败或用户点击退出，退出程序
                    Application.Exit();
                }
            }
        }
    }
}
