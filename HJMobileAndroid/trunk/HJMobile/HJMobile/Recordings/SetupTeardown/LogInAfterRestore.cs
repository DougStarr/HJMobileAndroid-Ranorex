﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace HJMobile.Recordings.SetupTeardown
{
    /// <summary>
    ///The LogInAfterRestore recording.
    /// </summary>
    [TestModule("b16aceff-89e2-4169-94e0-96cf43284508", ModuleType.Recording, 1)]
    public partial class LogInAfterRestore : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobile.HJMobileRepository repository.
        /// </summary>
        public static HJMobile.HJMobileRepository repo = HJMobile.HJMobileRepository.Instance;

        static LogInAfterRestore instance = new LogInAfterRestore();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogInAfterRestore()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogInAfterRestore Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.2.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.2.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.hcss.hcssmobile.testing' on device 'HJ Android 2 Asus Transformer'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("HJ Android 2 Asus Transformer", "com.hcss.hcssmobile.testing");
            Delay.Milliseconds(3500);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.Accept' at Center", repo.ComHcssHcssmobileTesting.AcceptInfo, new RecordItemIndex(1));
                repo.ComHcssHcssmobileTesting.Accept.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.LogIn1.UserID' at Center", repo.ComHcssHcssmobileTesting.LogIn1.UserIDInfo, new RecordItemIndex(2));
                repo.ComHcssHcssmobileTesting.LogIn1.UserID.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Set Value", "(Optional Action)\r\nSetting attribute Text to 'mmauto' on item 'ComHcssHcssmobileTesting.LogIn1.UserID'.", repo.ComHcssHcssmobileTesting.LogIn1.UserIDInfo, new RecordItemIndex(3));
                repo.ComHcssHcssmobileTesting.LogIn1.UserID.Element.SetAttributeValue("Text", "mmauto");
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.LogIn1.Password' at Center", repo.ComHcssHcssmobileTesting.LogIn1.PasswordInfo, new RecordItemIndex(4));
                repo.ComHcssHcssmobileTesting.LogIn1.Password.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Set Value", "(Optional Action)\r\nSetting attribute Text to 'hcss1234' on item 'ComHcssHcssmobileTesting.LogIn1.Password'.", repo.ComHcssHcssmobileTesting.LogIn1.PasswordInfo, new RecordItemIndex(5));
                repo.ComHcssHcssmobileTesting.LogIn1.Password.Element.SetAttributeValue("Text", "hcss1234");
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.LogIn1.Login' at Center", repo.ComHcssHcssmobileTesting.LogIn1.LoginInfo, new RecordItemIndex(6));
                repo.ComHcssHcssmobileTesting.LogIn1.Login.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.Home' at Center", repo.ComHcssHcssmobileTesting.HomeInfo, new RecordItemIndex(7));
                repo.ComHcssHcssmobileTesting.Home.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.ButtonNo' at Center", repo.ComHcssHcssmobileTesting.ButtonNoInfo, new RecordItemIndex(8));
                repo.ComHcssHcssmobileTesting.ButtonNo.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
        }

#region Image Feature Data
#endregion
    }
}
