using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using TMSUI.objectPool;
using DevExpress.XtraSplashScreen;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace TMSUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationKey.division = args[0];
            ApplicationKey.corporation = args[1];
            ApplicationKey.plant = args[2];
            ApplicationKey.masterID = args[3];
            ApplicationKey.planID = args[4];
            ApplicationKey.plansST = args[5];
            ApplicationKey.userId = args[6];

            SplashScreenManager.ShowForm(typeof(FormSplash), true, false);

            //20131001_0000
            ApplicationKey.planID2 = new string[3];
            for (int a = 0; a < 3; a++)
                ApplicationKey.planID2[a] = ApplicationKey.planID.Substring(0, 12) + (a+1);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");

            //SplashScreenManager.CloseForm();

            //Application.Run(new FormMain());

            Application.Run(new FormRibbon());
        }
    }
}