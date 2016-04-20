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
    ///The SelectTCANALYSIS1 recording.
    /// </summary>
    [TestModule("7498ace9-2361-4e19-9d8f-011c2974e6e4", ModuleType.Recording, 1)]
    public partial class SelectTCANALYSIS1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static SelectTCANALYSIS1 instance = new SelectTCANALYSIS1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectTCANALYSIS1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectTCANALYSIS1 Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.SelectJob' at Center", repo.ComHcssHcssmobileTesting.SelectJobInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.SelectJob.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6000ms.", new RecordItemIndex(1));
            Delay.Duration(6000, false);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'tcanalysis1' on item 'ComHcssHcssmobileTesting.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.AndroidWidgetEditTextInfo, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.AndroidWidgetEditText.Element.SetAttributeValue("Text", "tcanalysis1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Linear2' at Center", repo.ComHcssHcssmobileTesting.Linear2Info, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.Linear2.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 45s.", new RecordItemIndex(4));
            Delay.Duration(45000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
