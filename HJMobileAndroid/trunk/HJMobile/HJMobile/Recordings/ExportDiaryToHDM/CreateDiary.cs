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

namespace HJMobileAndroid.Recordings.ExportDiaryToHDM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateDiary recording.
    /// </summary>
    [TestModule("56d64ffe-d181-4806-9f8a-76429d1526c0", ModuleType.Recording, 1)]
    public partial class CreateDiary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static CreateDiary instance = new CreateDiary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateDiary()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateDiary Instance
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

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.hcss.hcssmobile.testing' on device 'Nexus 9'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("Nexus 9", "com.hcss.hcssmobile.testing", true);
            Delay.Milliseconds(3500);
            
            // Select a job before opening the diary
            Report.Log(ReportLevel.Info, "Touch", "Select a job before opening the diary\r\nTouch item 'ComHcssHcssmobileTesting.SelectJob' at Center", repo.ComHcssHcssmobileTesting.SelectJobInfo, new RecordItemIndex(1));
            repo.ComHcssHcssmobileTesting.SelectJob.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetEditText' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetEditTextInfo, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.AndroidWidgetEditText.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'hjmobile1' on item 'ComHcssHcssmobileTesting.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.AndroidWidgetEditTextInfo, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.AndroidWidgetEditText.Element.SetAttributeValue("Text", "hjmobile1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.HJMOBILE1JobForHJMobile' at Center", repo.ComHcssHcssmobileTesting.HJMOBILE1JobForHJMobileInfo, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.HJMOBILE1JobForHJMobile.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(5));
            Delay.Duration(15000, false);
            
            // Open Diary
            Report.Log(ReportLevel.Info, "Touch", "Open Diary\r\nTouch item 'ComHcssHcssmobileTesting.Diary1' at Center", repo.ComHcssHcssmobileTesting.Diary1Info, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.Diary1.Touch();
            Delay.Milliseconds(500);
            
            // Add Three working conditions
            Report.Log(ReportLevel.Info, "Touch", "Add Three working conditions\r\nTouch item 'ComHcssHcssmobileTesting.ScrollView.WorkingConditions' at Center", repo.ComHcssHcssmobileTesting.ScrollView.WorkingConditionsInfo, new RecordItemIndex(7));
            repo.ComHcssHcssmobileTesting.ScrollView.WorkingConditions.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4Info, new RecordItemIndex(8));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('3') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(9));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "3");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('7') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(10));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "7");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('9') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(11));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "9");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative3' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative3Info, new RecordItemIndex(12));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative3.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('18') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(13));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "18");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.RelativeInfo, new RecordItemIndex(14));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.ScrollView.Warm7590' at Center", repo.ComHcssHcssmobileTesting.ScrollView.Warm7590Info, new RecordItemIndex(15));
            repo.ComHcssHcssmobileTesting.ScrollView.Warm7590.Touch();
            Delay.Milliseconds(500);
            
            // Add ten note indexes
            Report.Log(ReportLevel.Info, "Touch", "Add ten note indexes\r\nTouch item 'ComHcssHcssmobileTesting.ScrollView.NoteIndexes' at Center", repo.ComHcssHcssmobileTesting.ScrollView.NoteIndexesInfo, new RecordItemIndex(16));
            repo.ComHcssHcssmobileTesting.ScrollView.NoteIndexes.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4Info, new RecordItemIndex(17));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('2') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(18));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "2");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('10') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(19));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "10");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('13') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(20));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "13");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.SubcontractorIssue' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.SubcontractorIssueInfo, new RecordItemIndex(21));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.SubcontractorIssue.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('19') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(22));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "19");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('23') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(23));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "23");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('24') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(24));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "24");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.RelativeInfo, new RecordItemIndex(25));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('30') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(26));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "30");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('31') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(27));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "31");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.VerbalInstructionGiven' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.VerbalInstructionGivenInfo, new RecordItemIndex(28));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.VerbalInstructionGiven.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('37') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(29));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "37");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.OtherSuggestion' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.OtherSuggestionInfo, new RecordItemIndex(30));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.OtherSuggestion.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.UndergroundUtilityDamageReport' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.UndergroundUtilityDamageReportInfo, new RecordItemIndex(31));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.UndergroundUtilityDamageReport.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('39') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(32));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "39");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('45') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(33));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "45");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative6' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative6Info, new RecordItemIndex(34));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative6.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Subcontracts' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.SubcontractsInfo, new RecordItemIndex(35));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Subcontracts.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Email' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.EmailInfo, new RecordItemIndex(36));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Email.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.UtilityHitWater' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.UtilityHitWaterInfo, new RecordItemIndex(37));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.UtilityHitWater.Touch();
            Delay.Milliseconds(500);
            
            // This is to close the note index selection
            Report.Log(ReportLevel.Info, "Touch", "This is to close the note index selection\r\nTouch item 'ComHcssHcssmobileTesting.ScrollView.Warm7590' at Center", repo.ComHcssHcssmobileTesting.ScrollView.Warm7590Info, new RecordItemIndex(38));
            repo.ComHcssHcssmobileTesting.ScrollView.Warm7590.Touch();
            Delay.Milliseconds(500);
            
            // This is to close the note index selection
            Report.Log(ReportLevel.Info, "Touch", "This is to close the note index selection\r\nTouch item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText1' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText1Info, new RecordItemIndex(39));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText1.Touch();
            Delay.Milliseconds(500);
            
            // Add text to some of the note indexes
            Report.Log(ReportLevel.Info, "Set Value", "Add text to some of the note indexes\r\nSetting attribute Text to ' Too windy at first' on item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText1'.", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText1Info, new RecordItemIndex(40));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText1.Element.SetAttributeValue("Text", " Too windy at first");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'sub did not work ' on item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText2'.", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText2Info, new RecordItemIndex(41));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText2.Element.SetAttributeValue("Text", "sub did not work ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Todd was being a jerk' on item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText3'.", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText3Info, new RecordItemIndex(42));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText3.Element.SetAttributeValue("Text", "Todd was being a jerk");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Would be nice if app was rainbow colored' on item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditTextInfo, new RecordItemIndex(43));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText.Element.SetAttributeValue("Text", "Would be nice if app was rainbow colored");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'sent an email to Todd's mother about his behavior' on item 'ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText5'.", repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText5Info, new RecordItemIndex(44));
            repo.ComHcssHcssmobileTesting.AndroidWidgetTableLayout.AndroidWidgetEditText5.Element.SetAttributeValue("Text", "sent an email to Todd's mother about his behavior");
            Delay.Milliseconds(100);
            
            // Add Entry Notes
            Report.Log(ReportLevel.Info, "Set Value", "Add Entry Notes\r\nSetting attribute Text to 'We worked hard today.  It started out too windy, but we made up for it.  Todd was not working so I had words with him and sent him home.   The sub did not show up with enough guys to be effective.' on item 'ComHcssHcssmobileTesting.ScrollView.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.ScrollView.AndroidWidgetEditTextInfo, new RecordItemIndex(45));
            repo.ComHcssHcssmobileTesting.ScrollView.AndroidWidgetEditText.Element.SetAttributeValue("Text", "We worked hard today.  It started out too windy, but we made up for it.  Todd was not working so I had words with him and sent him home.   The sub did not show up with enough guys to be effective.");
            Delay.Milliseconds(100);
            
            // Tap out of the Entry Notes so that Quick Prases get added to the correct place
            Report.Log(ReportLevel.Info, "Touch", "Tap out of the Entry Notes so that Quick Prases get added to the correct place\r\nTouch item 'ComHcssHcssmobileTesting.ScrollView.Warm7590' at Center", repo.ComHcssHcssmobileTesting.ScrollView.Warm7590Info, new RecordItemIndex(46));
            repo.ComHcssHcssmobileTesting.ScrollView.Warm7590.Touch();
            Delay.Milliseconds(500);
            
            // Add some Quick Phrases
            Report.Log(ReportLevel.Info, "Touch", "Add some Quick Phrases\r\nTouch item 'ComHcssHcssmobileTesting.ScrollView.QuickPhrases' at Center", repo.ComHcssHcssmobileTesting.ScrollView.QuickPhrasesInfo, new RecordItemIndex(47));
            repo.ComHcssHcssmobileTesting.ScrollView.QuickPhrases.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.InspectorAccepted' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.InspectorAcceptedInfo, new RecordItemIndex(48));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.InspectorAccepted.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('4') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(49));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "4");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('7') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(50));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "7");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('8') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(51));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "8");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('16') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(52));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "16");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('17') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(53));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "17");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4Info, new RecordItemIndex(54));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative6' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative6Info, new RecordItemIndex(55));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative6.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('20') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(56));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "20");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('24') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(57));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "24");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('31') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(58));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "31");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative8' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative8Info, new RecordItemIndex(59));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative8.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('35') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(60));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "35");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('44') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(61));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "44");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('46') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(62));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "46");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative9' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative9Info, new RecordItemIndex(63));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative9.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('56') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(64));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "56");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('59') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(65));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "59");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative1' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative1Info, new RecordItemIndex(66));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('71') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(67));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "71");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('74') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(68));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "74");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4Info, new RecordItemIndex(69));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('75') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(70));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "75");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('83') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(71));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "83");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('88') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(72));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "88");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('97') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(73));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "97");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('100') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(74));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "100");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Linear' at Center", repo.ComHcssHcssmobileTesting.LinearInfo, new RecordItemIndex(75));
            repo.ComHcssHcssmobileTesting.Linear.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('106') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(76));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "106");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('112') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(77));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "112");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative3' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative3Info, new RecordItemIndex(78));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative3.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('117') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(79));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "117");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('127') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(80));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "127");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.NeedMoreTrucks' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.NeedMoreTrucksInfo, new RecordItemIndex(81));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.NeedMoreTrucks.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4Info, new RecordItemIndex(82));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('138') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(83));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "138");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('141') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(84));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "141");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative8' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative8Info, new RecordItemIndex(85));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative8.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('142') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(86));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "142");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking ScrollToIndex('156') on item 'ComHcssHcssmobileTesting.AndroidWidgetListView'.", repo.ComHcssHcssmobileTesting.AndroidWidgetListViewInfo, new RecordItemIndex(87));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView.Element.InvokeActionWithText("ScrollToIndex", "156");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4Info, new RecordItemIndex(88));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative4.Touch();
            Delay.Milliseconds(500);
            
            // Close the Quick Phrases
            Report.Log(ReportLevel.Info, "Touch", "Close the Quick Phrases\r\nTouch item 'ComHcssHcssmobileTesting.ScrollView.Warm7590' at Center", repo.ComHcssHcssmobileTesting.ScrollView.Warm7590Info, new RecordItemIndex(89));
            repo.ComHcssHcssmobileTesting.ScrollView.Warm7590.Touch();
            Delay.Milliseconds(500);
            
            // Send the Diary
            Report.Log(ReportLevel.Info, "Touch", "Send the Diary\r\nTouch item 'ComHcssHcssmobileTesting.Send' at 43;18", repo.ComHcssHcssmobileTesting.SendInfo, new RecordItemIndex(90));
            repo.ComHcssHcssmobileTesting.Send.Touch("43;18");
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
