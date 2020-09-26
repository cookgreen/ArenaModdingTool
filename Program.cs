using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LanguageManager.Instance.Init();
            AppSetting appSetting = new AppSetting("app.ini");

            LanguageManager.Instance.CurrentLocalization = appSetting.Localization;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(appSetting));
        }
    }
}
