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
    ///The SolveMissingCCNotes recording.
    /// </summary>
    [TestModule("cec19d26-7dd6-4bf8-b2f5-e7b765ed34e1", ModuleType.Recording, 1)]
    public partial class SolveMissingCCNotes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static SolveMissingCCNotes instance = new SolveMissingCCNotes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SolveMissingCCNotes()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SolveMissingCCNotes Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.UIWindow.Attendance_NonUseCodes.AlertOrangePlusCostCodeHasNoNotes1' at Center", repo.ComHcssHcssmobileTesting.UIWindow.Attendance_NonUseCodes.AlertOrangePlusCostCodeHasNoNotes1Info, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.UIWindow.Attendance_NonUseCodes.AlertOrangePlusCostCodeHasNoNotes1.Touch();
            Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ComHcssHcssmobileTesting.UIWindow.AlertNotes'.", repo.ComHcssHcssmobileTesting.UIWindow.AlertNotesInfo, new RecordItemIndex(1));
            //Validate.Exists(repo.ComHcssHcssmobileTesting.UIWindow.AlertNotesInfo);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ComHcssHcssmobileTesting.UIWindow.Attendance_NonUseCodes.AlertCompanyNote'.", repo.ComHcssHcssmobileTesting.UIWindow.Attendance_NonUseCodes.AlertCompanyNoteInfo, new RecordItemIndex(2));
            //Validate.Exists(repo.ComHcssHcssmobileTesting.UIWindow.Attendance_NonUseCodes.AlertCompanyNoteInfo);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Here is a note for cost code 02-0265010' on item 'ComHcssHcssmobileTesting.UIWindow.CompanyNote'.", repo.ComHcssHcssmobileTesting.UIWindow.CompanyNoteInfo, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.UIWindow.CompanyNote.Element.SetAttributeValue("Text", "Here is a note for cost code 02-0265010");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.UIWindow.SomeButton' at Center", repo.ComHcssHcssmobileTesting.UIWindow.SomeButtonInfo, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.UIWindow.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Here is a note for cost code 01-0910002' on item 'ComHcssHcssmobileTesting.UIWindow.CompanyNote'.", repo.ComHcssHcssmobileTesting.UIWindow.CompanyNoteInfo, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.UIWindow.CompanyNote.Element.SetAttributeValue("Text", "Here is a note for cost code 01-0910002");
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.Done23' at Center", repo.ComHcssHcssmobileTesting.Done23Info, new RecordItemIndex(6));
                repo.ComHcssHcssmobileTesting.Done23.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.Copy_of_Done623' at Center", repo.ComHcssHcssmobileTesting.Copy_of_Done623Info, new RecordItemIndex(7));
                repo.ComHcssHcssmobileTesting.Copy_of_Done623.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
