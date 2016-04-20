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

namespace HJMobileAndroid.Recordings.ExportDiaryToHDM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RemoveDiaryFromHJ recording.
    /// </summary>
    [TestModule("7f441088-3566-4b6b-bb4f-db6f6e9904ae", ModuleType.Recording, 1)]
    public partial class RemoveDiaryFromHJ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static RemoveDiaryFromHJ instance = new RemoveDiaryFromHJ();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveDiaryFromHJ()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoveDiaryFromHJ Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'QaAutomationQaAutomationRemoteD.OPWindowClass' at Center.", repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo, new RecordItemIndex(0));
            repo.QaAutomationQaAutomationRemoteD.OPWindowClass.MoveTo();
            Delay.Milliseconds(200);
            
            // opening start menu to get to run program
            Report.Log(ReportLevel.Info, "Mouse", "opening start menu to get to run program\r\nMouse Left Click item 'QaAutomationQaAutomationRemoteD.OPWindowClass' at 22;28.", repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo, new RecordItemIndex(1));
            repo.QaAutomationQaAutomationRemoteD.OPWindowClass.Click(new Location(OPWindowClass_Screenshot1, "22;28", OPWindowClass_Screenshot1_Options));
            Delay.Milliseconds(200);
            
            // Running RemoveDiary batch
            Report.Log(ReportLevel.Info, "Keyboard", "Running RemoveDiary batch\r\nKey sequence 'c'.", new RecordItemIndex(2));
            Keyboard.Press("c");
            Delay.Milliseconds(0);
            
            TypeColon();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '\\heavyjob\\mgrcnsldsvc\\automation files\\removediary.bat'.", new RecordItemIndex(4));
            Keyboard.Press("\\heavyjob\\mgrcnsldsvc\\automation files\\removediary.bat");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage OPWindowClass_Screenshot1
        { get { return repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo.GetScreenshot1(new Rectangle(5, 1037, 44, 37)); } }

        Imaging.FindOptions OPWindowClass_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.97;None;0,0,0,0;True;10000000;60000ms"); } }

#endregion
    }
#pragma warning restore 0436
}
