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

namespace HJMobileAndroid.Recordings.TimeCardProductionAnalysis
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The GetBacktoMainScreen recording.
    /// </summary>
    [TestModule("a638d000-6036-4001-ac5f-aa92195b04cd", ModuleType.Recording, 1)]
    public partial class GetBacktoMainScreen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static GetBacktoMainScreen instance = new GetBacktoMainScreen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GetBacktoMainScreen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GetBacktoMainScreen Instance
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
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.HomeButton' at Center", repo.ComHcssHcssmobileTesting.HomeButtonInfo, new RecordItemIndex(0));
                repo.ComHcssHcssmobileTesting.HomeButton.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.Home7' at Center", repo.ComHcssHcssmobileTesting.Home7Info, new RecordItemIndex(1));
                repo.ComHcssHcssmobileTesting.Home7.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.ButtonNo1' at Center", repo.ComHcssHcssmobileTesting.ButtonNo1Info, new RecordItemIndex(2));
                repo.ComHcssHcssmobileTesting.ButtonNo1.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}