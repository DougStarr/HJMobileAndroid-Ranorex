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

namespace HJMobileAndroid.Recordings.ExportTimeCardToHDM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddCrew recording.
    /// </summary>
    [TestModule("8ae18406-a05d-495d-8e52-07ec01756921", ModuleType.Recording, 1)]
    public partial class AddCrew : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static AddCrew instance = new AddCrew();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCrew()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddCrew Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.TapToAddCrew' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.TapToAddCrewInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.TapToAddCrew.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(1));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'mendoza,m' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "mendoza,m");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Relative' at Center", repo.ComHcssHcssmobileTesting.Content1.RelativeInfo, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.Content1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'stewart,a' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(4));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "stewart,a");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Relative' at Center", repo.ComHcssHcssmobileTesting.Content1.RelativeInfo, new RecordItemIndex(5));
            repo.ComHcssHcssmobileTesting.Content1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'bob,b' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(6));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "bob,b");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Relative' at Center", repo.ComHcssHcssmobileTesting.Content1.RelativeInfo, new RecordItemIndex(7));
            repo.ComHcssHcssmobileTesting.Content1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'ducke,d' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(8));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "ducke,d");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Relative' at Center", repo.ComHcssHcssmobileTesting.Content1.RelativeInfo, new RecordItemIndex(9));
            repo.ComHcssHcssmobileTesting.Content1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'carol,f' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(10));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "carol,f");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Relative' at Center", repo.ComHcssHcssmobileTesting.Content1.RelativeInfo, new RecordItemIndex(11));
            repo.ComHcssHcssmobileTesting.Content1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'siegfried,s' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(12));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "siegfried,s");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Relative' at Center", repo.ComHcssHcssmobileTesting.Content1.RelativeInfo, new RecordItemIndex(13));
            repo.ComHcssHcssmobileTesting.Content1.Relative.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Equipment' at Center", repo.ComHcssHcssmobileTesting.Content1.EquipmentInfo, new RecordItemIndex(14));
            repo.ComHcssHcssmobileTesting.Content1.Equipment.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'd8-4080' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(15));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "d8-4080");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Link' at Center", repo.ComHcssHcssmobileTesting.Content1.LinkInfo, new RecordItemIndex(16));
            repo.ComHcssHcssmobileTesting.Content1.Link.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative2' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative2Info, new RecordItemIndex(17));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.Relative2.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'bh426-8020' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(18));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "bh426-8020");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Link' at Center", repo.ComHcssHcssmobileTesting.Content1.LinkInfo, new RecordItemIndex(19));
            repo.ComHcssHcssmobileTesting.Content1.Link.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.ArnoldStewart' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.ArnoldStewartInfo, new RecordItemIndex(20));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.ArnoldStewart.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'lz' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(21));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "lz");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.AddUnlink' at Center", repo.ComHcssHcssmobileTesting.Content1.AddUnlinkInfo, new RecordItemIndex(22));
            repo.ComHcssHcssmobileTesting.Content1.AddUnlink.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'e235-6032' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(23));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "e235-6032");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Link' at Center", repo.ComHcssHcssmobileTesting.Content1.LinkInfo, new RecordItemIndex(24));
            repo.ComHcssHcssmobileTesting.Content1.Link.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.MiggyMendoza' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.MiggyMendozaInfo, new RecordItemIndex(25));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.MiggyMendoza.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'arc-2356' on item 'ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText'.", repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditTextInfo, new RecordItemIndex(26));
            repo.ComHcssHcssmobileTesting.Content1.AndroidWidgetEditText.Element.SetAttributeValue("Text", "arc-2356");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Content1.Link' at Center", repo.ComHcssHcssmobileTesting.Content1.LinkInfo, new RecordItemIndex(27));
            repo.ComHcssHcssmobileTesting.Content1.Link.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.AndroidWidgetListView1.BigBob' at Center", repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.BigBobInfo, new RecordItemIndex(28));
            repo.ComHcssHcssmobileTesting.AndroidWidgetListView1.BigBob.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.Done3' at Center", repo.ComHcssHcssmobileTesting.Done3Info, new RecordItemIndex(29));
            repo.ComHcssHcssmobileTesting.Done3.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
