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

namespace HJMobileAndroid.Recordings.MobileTimeCard
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ChangeTimeCardShift recording.
    /// </summary>
    [TestModule("a2e056ed-6843-490e-b5c7-46f228ec752e", ModuleType.Recording, 1)]
    public partial class ChangeTimeCardShift : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static ChangeTimeCardShift instance = new ChangeTimeCardShift();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChangeTimeCardShift()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChangeTimeCardShift Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Shift1' at Center", repo.ComHcssHcssmobileTesting.Shift1Info, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.Shift1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Shift2' at Center", repo.ComHcssHcssmobileTesting.Shift2Info, new RecordItemIndex(1));
            repo.ComHcssHcssmobileTesting.Shift2.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
