using ArenaModdingTool.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlLoader;

namespace ArenaModdingTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LanguageManager.Instance.Init();
            AppSetting appSetting = new AppSetting("app.ini");

            RecentOperations recentOperations;
            XmlObjectLoader xmlObjectLoader = new XmlObjectLoader("RecentOperations.xml");
            xmlObjectLoader.Load(out recentOperations);

            frmAppSetting appSettingSelector = new frmAppSetting(appSetting);
            if(appSettingSelector.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain(appSettingSelector.AppSetting, recentOperations));
            }
        }
    }
}
