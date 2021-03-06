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

namespace HJMobileAndroid.Recordings.SetupTeardown
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RemoteDesktopLogout recording.
    /// </summary>
    [TestModule("1cccdf87-1708-4a72-b1c4-7ff7c0ed5824", ModuleType.Recording, 1)]
    public partial class RemoteDesktopLogout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static RemoteDesktopLogout instance = new RemoteDesktopLogout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoteDesktopLogout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoteDesktopLogout Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.4")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 10s.", new RecordItemIndex(0));
                Delay.Duration(10000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Move item 'QaAutomationQaAutomationRemoteD.OPWindowClass' at Center.", repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo, new RecordItemIndex(1));
                repo.QaAutomationQaAutomationRemoteD.OPWindowClass.MoveTo();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'QaAutomationQaAutomationRemoteD.OPWindowClass' at 16;12.", repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo, new RecordItemIndex(2));
                repo.QaAutomationQaAutomationRemoteD.OPWindowClass.Click(new Location(OPWindowClass_Screenshot2, "16;12", OPWindowClass_Screenshot2_Options));
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 1m.", new RecordItemIndex(3));
                Delay.Duration(60000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'QaAutomationQaAutomationRemoteD.OPWindowClass' at 88;20.", repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo, new RecordItemIndex(4));
                repo.QaAutomationQaAutomationRemoteD.OPWindowClass.Click(new Location(OPWindowClass_Screenshot3, "88;20", OPWindowClass_Screenshot3_Options));
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
        }

#region Image Feature Data
        CompressedImage OPWindowClass_Screenshot2
        { get { return repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo.GetScreenshot2(new Rectangle(8, 1044, 43, 31)); } }

        Imaging.FindOptions OPWindowClass_Screenshot2_Options
        { get { return Imaging.FindOptions.Parse("0.93;None;0,0,0,0;True;10000000;0ms"); } }

        CompressedImage OPWindowClass_Screenshot3
        { get { return repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo.GetScreenshot3(new Rectangle(223, 991, 104, 33)); } }

        Imaging.FindOptions OPWindowClass_Screenshot3_Options
        { get { return Imaging.FindOptions.Parse("0.99;None;0,0,0,0;True;10000000;60000ms"); } }

#endregion
    }
#pragma warning restore 0436
}
