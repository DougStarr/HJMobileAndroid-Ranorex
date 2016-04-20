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

namespace HJMobileAndroid.Recordings.Validation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LibraryEmployeeValidationNewData recording.
    /// </summary>
    [TestModule("ee445684-835d-40a3-9636-352c1968490f", ModuleType.Recording, 1)]
    public partial class LibraryEmployeeValidationNewData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static LibraryEmployeeValidationNewData instance = new LibraryEmployeeValidationNewData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LibraryEmployeeValidationNewData()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LibraryEmployeeValidationNewData Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Employee' at Center", repo.ComHcssHcssmobileTesting.Content1.EmployeeInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.Content1.Employee.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.SourceJob' at Center", repo.ComHcssHcssmobileTesting.Content1.SourceJobInfo, new RecordItemIndex(1));
            repo.ComHcssHcssmobileTesting.Content1.SourceJob.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Refresh2' at Center", repo.ComHcssHcssmobileTesting.Refresh2Info, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.Refresh2.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Master Library - LABOR') on item 'ComHcssHcssmobileTesting.Content1.MasterLibraryLABOR'.", repo.ComHcssHcssmobileTesting.Content1.MasterLibraryLABORInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.ComHcssHcssmobileTesting.Content1.MasterLibraryLABORInfo, "Text", "Master Library - LABOR");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText' at Center", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'new' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "new");
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='New Library Employee - LABOR') on item 'ComHcssHcssmobileTesting.Content1.NewLibraryEmployeeLABOR'.", repo.ComHcssHcssmobileTesting.Content1.NewLibraryEmployeeLABORInfo, new RecordItemIndex(7));
                Validate.Attribute(repo.ComHcssHcssmobileTesting.Content1.NewLibraryEmployeeLABORInfo, "Text", "New Library Employee - LABOR", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
