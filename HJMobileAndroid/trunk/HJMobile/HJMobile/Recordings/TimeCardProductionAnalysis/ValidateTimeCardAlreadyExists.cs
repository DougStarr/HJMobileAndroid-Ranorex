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
    ///The ValidateTimeCardAlreadyExists recording.
    /// </summary>
    [TestModule("e7c6b997-8694-4a4e-8f78-6b4cff7308fc", ModuleType.Recording, 1)]
    public partial class ValidateTimeCardAlreadyExists : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static ValidateTimeCardAlreadyExists instance = new ValidateTimeCardAlreadyExists();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateTimeCardAlreadyExists()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateTimeCardAlreadyExists Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetImageView' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetImageViewInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetImageView.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView3.MarineCostCode' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.MarineCostCodeInfo, new RecordItemIndex(1));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView3.MarineCostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Done1' at 104;61", repo.ComHcssHcssmobileTesting.Done1Info, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.Done1.Touch("104;61");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.TapToAddCrew' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.TapToAddCrewInfo, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.TapToAddCrew.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.RENALDOA' at Center", repo.ComHcssHcssmobileTesting.Content1.RENALDOAInfo, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.Content1.RENALDOA.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Done3' at 96;82", repo.ComHcssHcssmobileTesting.Done3Info, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.Done3.Touch("96;82");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetButton2' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetButton2Info, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.AndroidWidgetButton2.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(7));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.ButtonOK' at Center", repo.ComHcssHcssmobileTesting.ButtonOKInfo, new RecordItemIndex(8));
            repo.ComHcssHcssmobileTesting.ButtonOK.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5.07') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView5.Text1151'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListView5.Text1151Info, new RecordItemIndex(9));
            Validate.Attribute(repo.ComHcssHcssmobileTesting.AndroidWidgetListView5.Text1151Info, "Text", "5.07");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='138.52') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView5.Copy_of_Text1151'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListView5.Copy_of_Text1151Info, new RecordItemIndex(10));
            Validate.Attribute(repo.ComHcssHcssmobileTesting.AndroidWidgetListView5.Copy_of_Text1151Info, "Text", "138.52");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='($133.45)') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView5.Copy_of_Text11511'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListView5.Copy_of_Text11511Info, new RecordItemIndex(11));
            Validate.Attribute(repo.ComHcssHcssmobileTesting.AndroidWidgetListView5.Copy_of_Text11511Info, "Text", "($133.45)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.HomeButton' at Center", repo.ComHcssHcssmobileTesting.HomeButtonInfo, new RecordItemIndex(12));
            repo.ComHcssHcssmobileTesting.HomeButton.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}