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
    ///The AddCostCodeQty recording.
    /// </summary>
    [TestModule("45037bfb-9d44-46aa-b772-2590f66c8ad3", ModuleType.Recording, 1)]
    public partial class AddCostCodeQty : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static AddCostCodeQty instance = new AddCostCodeQty();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCostCodeQty()
        {
            AppVersion = "com.hcss.hcssmobile.staging";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddCostCodeQty Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.RegularCostCode' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.RegularCostCodeInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.RegularCostCode.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            // 1st Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "1st Cost Code Qty\r\nSetting attribute Text to '2714.991' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "2714.991");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '0.057' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", "0.057");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '0.688' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "0.688");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.58' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", "1.58");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '3.586' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", "3.586");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.204' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(7));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "1.204");
            Delay.Milliseconds(100);
            
            // doing it again because sometimes it does not work
            Report.Log(ReportLevel.Info, "Set Value", "doing it again because sometimes it does not work\r\nSetting attribute Text to '2714.991' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(8));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "2714.991");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(9));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(10));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(11));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(12));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(13));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.SomeButton' at Center", repo.ComHcssHcssmobileTesting.Content.SomeButtonInfo, new RecordItemIndex(14));
            repo.ComHcssHcssmobileTesting.Content.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Rework' at Center", repo.ComHcssHcssmobileTesting.Content.ReworkInfo, new RecordItemIndex(15));
            repo.ComHcssHcssmobileTesting.Content.Rework.Touch();
            Delay.Milliseconds(500);
            
            // 2nd Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "2nd Cost Code Qty\r\nSetting attribute Text to '1562.141' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(16));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "1562.141");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '.315' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(17));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", ".315");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '0.155' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(18));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "0.155");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '.986' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(19));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", ".986");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '2.524' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(20));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", "2.524");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.25' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(21));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "1.25");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(22));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(23));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(24));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(25));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(26));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.SomeButton' at Center", repo.ComHcssHcssmobileTesting.Content.SomeButtonInfo, new RecordItemIndex(27));
            repo.ComHcssHcssmobileTesting.Content.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            // 3rd Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "3rd Cost Code Qty\r\nSetting attribute Text to '1.105' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(28));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "1.105");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '4.279' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(29));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", "4.279");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.673' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(30));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "1.673");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '4.968' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(31));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", "4.968");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '2.570' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(32));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", "2.570");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '3.288' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(33));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "3.288");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(34));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(35));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(36));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(37));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(38));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.SomeButton' at Center", repo.ComHcssHcssmobileTesting.Content.SomeButtonInfo, new RecordItemIndex(39));
            repo.ComHcssHcssmobileTesting.Content.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            // 4th Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "4th Cost Code Qty\r\nSetting attribute Text to '10.663' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(40));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "10.663");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '.076' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(41));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", ".076");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '2.682' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(42));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "2.682");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.965' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(43));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", "1.965");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '.44' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(44));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", ".44");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.38' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(45));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "1.38");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(46));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(47));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(48));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(49));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(50));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.SomeButton' at Center", repo.ComHcssHcssmobileTesting.Content.SomeButtonInfo, new RecordItemIndex(51));
            repo.ComHcssHcssmobileTesting.Content.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            // 5th Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "5th Cost Code Qty\r\nSetting attribute Text to '3.64' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(52));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "3.64");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '11.338' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(53));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", "11.338");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '3.342' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(54));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "3.342");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '4.048' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(55));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", "4.048");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '4.912' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(56));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", "4.912");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '4.572' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(57));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "4.572");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(58));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(59));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(60));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(61));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(62));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.SomeButton' at Center", repo.ComHcssHcssmobileTesting.Content.SomeButtonInfo, new RecordItemIndex(63));
            repo.ComHcssHcssmobileTesting.Content.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            // 6th Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "6th Cost Code Qty\r\nSetting attribute Text to '5.79' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(64));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "5.79");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '3.447' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(65));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", "3.447");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.843' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(66));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "1.843");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '2.102' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(67));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", "2.102");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '2.773' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(68));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", "2.773");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '3.417' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(69));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "3.417");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(70));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(71));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(72));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(73));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(74));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.SomeButton' at Center", repo.ComHcssHcssmobileTesting.Content.SomeButtonInfo, new RecordItemIndex(75));
            repo.ComHcssHcssmobileTesting.Content.SomeButton.Touch();
            Delay.Milliseconds(500);
            
            // 7th Cost Code Qty
            Report.Log(ReportLevel.Info, "Set Value", "7th Cost Code Qty\r\nSetting attribute Text to '45.383' on item 'ComHcssHcssmobileTesting.Content.Text5'.", repo.ComHcssHcssmobileTesting.Content.Text5Info, new RecordItemIndex(76));
            repo.ComHcssHcssmobileTesting.Content.Text5.Element.SetAttributeValue("Text", "45.383");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '4.572' on item 'ComHcssHcssmobileTesting.Content.Text00'.", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(77));
            repo.ComHcssHcssmobileTesting.Content.Text00.Element.SetAttributeValue("Text", "4.572");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '1.632' on item 'ComHcssHcssmobileTesting.Content.Text01'.", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(78));
            repo.ComHcssHcssmobileTesting.Content.Text01.Element.SetAttributeValue("Text", "1.632");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '.938' on item 'ComHcssHcssmobileTesting.Content.Text02'.", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(79));
            repo.ComHcssHcssmobileTesting.Content.Text02.Element.SetAttributeValue("Text", ".938");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '3.141' on item 'ComHcssHcssmobileTesting.Content.Text03'.", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(80));
            repo.ComHcssHcssmobileTesting.Content.Text03.Element.SetAttributeValue("Text", "3.141");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '2.02' on item 'ComHcssHcssmobileTesting.Content.Text04'.", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(81));
            repo.ComHcssHcssmobileTesting.Content.Text04.Element.SetAttributeValue("Text", "2.02");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text00' at Center", repo.ComHcssHcssmobileTesting.Content.Text00Info, new RecordItemIndex(82));
            repo.ComHcssHcssmobileTesting.Content.Text00.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text01' at Center", repo.ComHcssHcssmobileTesting.Content.Text01Info, new RecordItemIndex(83));
            repo.ComHcssHcssmobileTesting.Content.Text01.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text02' at Center", repo.ComHcssHcssmobileTesting.Content.Text02Info, new RecordItemIndex(84));
            repo.ComHcssHcssmobileTesting.Content.Text02.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text03' at Center", repo.ComHcssHcssmobileTesting.Content.Text03Info, new RecordItemIndex(85));
            repo.ComHcssHcssmobileTesting.Content.Text03.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content.Text04' at Center", repo.ComHcssHcssmobileTesting.Content.Text04Info, new RecordItemIndex(86));
            repo.ComHcssHcssmobileTesting.Content.Text04.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Done2' at 81;74", repo.ComHcssHcssmobileTesting.Done2Info, new RecordItemIndex(87));
            repo.ComHcssHcssmobileTesting.Done2.Touch("81;74");
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
