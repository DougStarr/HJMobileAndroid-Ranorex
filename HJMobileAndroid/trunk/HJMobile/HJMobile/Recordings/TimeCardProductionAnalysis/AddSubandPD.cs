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
    ///The AddSubandPD recording.
    /// </summary>
    [TestModule("ea5ab43e-4145-457f-a49f-fa426981d534", ModuleType.Recording, 1)]
    public partial class AddSubandPD : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static AddSubandPD instance = new AddSubandPD();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddSubandPD()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddSubandPD Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.ARIYO_A' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.ARIYO_AInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.ARIYO_A.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.PerDiem' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.PerDiemInfo, new RecordItemIndex(1));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.PerDiem.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.TextDollar000' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.TextDollar000Info, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.TextDollar000.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button2' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button2Info, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button2.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button1' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button1Info, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.ButtonInfo, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button7' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button7Info, new RecordItemIndex(7));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button7.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button5' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button5Info, new RecordItemIndex(8));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Button5.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Done' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.DoneInfo, new RecordItemIndex(9));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout1.Done.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.Done1' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.Done1Info, new RecordItemIndex(10));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.Done1.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
