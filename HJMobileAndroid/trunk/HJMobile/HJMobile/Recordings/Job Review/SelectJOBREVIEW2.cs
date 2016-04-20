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

namespace HJMobileAndroid.Recordings.Job_Review
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SelectJOBREVIEW2 recording.
    /// </summary>
    [TestModule("0ead9e1e-0520-4b75-a5c8-0a57015a8076", ModuleType.Recording, 1)]
    public partial class SelectJOBREVIEW2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static SelectJOBREVIEW2 instance = new SelectJOBREVIEW2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectJOBREVIEW2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectJOBREVIEW2 Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.SelectJob223' at Center", repo.ComHcssHcssmobileTesting.SelectJob223Info, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.SelectJob223.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 8000ms.", new RecordItemIndex(1));
            Delay.Duration(8000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.UIWindow.JOBREVIEW2JobForJobReviewWithReq' at Center", repo.ComHcssHcssmobileTesting.UIWindow.JOBREVIEW2JobForJobReviewWithReqInfo, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.UIWindow.JOBREVIEW2JobForJobReviewWithReq.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(3));
            Delay.Duration(20000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}