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
    ///The AddCostCodes recording.
    /// </summary>
    [TestModule("780b5a20-4c8a-4563-8fab-e28b7c917d4f", ModuleType.Recording, 1)]
    public partial class AddCostCodes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static AddCostCodes instance = new AddCostCodes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCostCodes()
        {
            AppVersion = "com.hcss.hcssmobile.staging";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddCostCodes Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable AppVersion.
        /// </summary>
        [TestVariable("e9cd3f50-d908-47fa-8dc7-ffdeca2f7b93")]
        public string AppVersion
        {
            get { return repo.AppVersion; }
            set { repo.AppVersion = value; }
        }

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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetImageView' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetImageViewInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetImageView.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(1));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.RegularCostCode' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.RegularCostCodeInfo, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.RegularCostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.RegularCostCode' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.RegularCostCodeInfo, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.RegularCostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.ExtraWorkCostCode' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.ExtraWorkCostCodeInfo, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.ExtraWorkCostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.MarineCostCode' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.MarineCostCodeInfo, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.MarineCostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.MSECostCode' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.MSECostCodeInfo, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.MSECostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.CostCodeWithNoBudget' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.CostCodeWithNoBudgetInfo, new RecordItemIndex(7));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.CostCodeWithNoBudget.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.TMCC' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.TMCCInfo, new RecordItemIndex(8));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.TMCC.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Done1' at 79;74", repo.ComHcssHcssmobileTesting.Done1Info, new RecordItemIndex(9));
            repo.ComHcssHcssmobileTesting.Done1.Touch("79;74");
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
