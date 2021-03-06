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

namespace HJMobile.Recordings.ExportDiaryToHDM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddNoteIndexes_IOS_ recording.
    /// </summary>
    [TestModule("6a42cd55-d658-455f-aabd-236258c49325", ModuleType.Recording, 1)]
    public partial class AddNoteIndexes_IOS_ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobile.HJMobileRepository repository.
        /// </summary>
        public static HJMobile.HJMobileRepository repo = HJMobile.HJMobileRepository.Instance;

        static AddNoteIndexes_IOS_ instance = new AddNoteIndexes_IOS_();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddNoteIndexes_IOS_()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddNoteIndexes_IOS_ Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(0));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.WeatherDelay' at Center", repo.ComHcssMobileTest.UIWindow.WeatherDelayInfo, new RecordItemIndex(1));
            repo.ComHcssMobileTest.UIWindow.WeatherDelay.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.VisitorInspector' at Center", repo.ComHcssMobileTest.UIWindow.VisitorInspectorInfo, new RecordItemIndex(2));
            repo.ComHcssMobileTest.UIWindow.VisitorInspector.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.SubcontractorIssue' at Center", repo.ComHcssMobileTest.UIWindow.SubcontractorIssueInfo, new RecordItemIndex(3));
            repo.ComHcssMobileTest.UIWindow.SubcontractorIssue.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.VerbalInstructionGiven' at Center", repo.ComHcssMobileTest.UIWindow.VerbalInstructionGivenInfo, new RecordItemIndex(4));
            repo.ComHcssMobileTest.UIWindow.VerbalInstructionGiven.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.OtherSuggestion' at Center", repo.ComHcssMobileTest.UIWindow.OtherSuggestionInfo, new RecordItemIndex(5));
            repo.ComHcssMobileTest.UIWindow.OtherSuggestion.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(6));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(7));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.UndergroundUtilityDamageReport' at Center", repo.ComHcssMobileTest.UIWindow.UndergroundUtilityDamageReportInfo, new RecordItemIndex(8));
            repo.ComHcssMobileTest.UIWindow.UndergroundUtilityDamageReport.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.ContractDocuments' at Center", repo.ComHcssMobileTest.UIWindow.ContractDocumentsInfo, new RecordItemIndex(9));
            repo.ComHcssMobileTest.UIWindow.ContractDocuments.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(10));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(11));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.Subcontracts' at Center", repo.ComHcssMobileTest.UIWindow.SubcontractsInfo, new RecordItemIndex(12));
            repo.ComHcssMobileTest.UIWindow.Subcontracts.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(13));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(14));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.Email' at Center", repo.ComHcssMobileTest.UIWindow.EmailInfo, new RecordItemIndex(15));
            repo.ComHcssMobileTest.UIWindow.Email.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(16));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(17));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.UtilityHitWater' at Center", repo.ComHcssMobileTest.UIWindow.UtilityHitWaterInfo, new RecordItemIndex(18));
            repo.ComHcssMobileTest.UIWindow.UtilityHitWater.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.NoteIndexes1' at Center", repo.ComHcssMobileTest.UIWindow.NoteIndexes1Info, new RecordItemIndex(19));
            repo.ComHcssMobileTest.UIWindow.NoteIndexes1.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
