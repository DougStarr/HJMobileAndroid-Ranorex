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
    ///The AddNoteIndexNotes_IOS_ recording.
    /// </summary>
    [TestModule("41fb1c80-8415-42c6-becb-f4cde1dd1120", ModuleType.Recording, 1)]
    public partial class AddNoteIndexNotes_IOS_ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobile.HJMobileRepository repository.
        /// </summary>
        public static HJMobile.HJMobileRepository repo = HJMobile.HJMobileRepository.Instance;

        static AddNoteIndexNotes_IOS_ instance = new AddNoteIndexNotes_IOS_();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddNoteIndexNotes_IOS_()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddNoteIndexNotes_IOS_ Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.TooWindyAtFirst' at 131;68", repo.ComHcssMobileTest.UIWindow.TooWindyAtFirstInfo, new RecordItemIndex(0));
            repo.ComHcssMobileTest.UIWindow.TooWindyAtFirst.Touch("131;68");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Too windy at first' on item 'ComHcssMobileTest.UIWindow.TextToo'.", repo.ComHcssMobileTest.UIWindow.TextTooInfo, new RecordItemIndex(1));
            repo.ComHcssMobileTest.UIWindow.TextToo.Element.SetAttributeValue("Text", "Too windy at first");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.UITextView' at 173;23", repo.ComHcssMobileTest.UIWindow.UITextViewInfo, new RecordItemIndex(2));
            repo.ComHcssMobileTest.UIWindow.UITextView.Touch("173;23");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'sub did not work' on item 'ComHcssMobileTest.UIWindow.UITextView'.", repo.ComHcssMobileTest.UIWindow.UITextViewInfo, new RecordItemIndex(3));
            repo.ComHcssMobileTest.UIWindow.UITextView.Element.SetAttributeValue("Text", "sub did not work");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.UITextView2' at 214;61", repo.ComHcssMobileTest.UIWindow.UITextView2Info, new RecordItemIndex(4));
            repo.ComHcssMobileTest.UIWindow.UITextView2.Touch("214;61");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Todd was being a jerk' on item 'ComHcssMobileTest.UIWindow.UITextView2'.", repo.ComHcssMobileTest.UIWindow.UITextView2Info, new RecordItemIndex(5));
            repo.ComHcssMobileTest.UIWindow.UITextView2.Element.SetAttributeValue("Text", "Todd was being a jerk");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.UITextView3' at 222;77", repo.ComHcssMobileTest.UIWindow.UITextView3Info, new RecordItemIndex(6));
            repo.ComHcssMobileTest.UIWindow.UITextView3.Touch("222;77");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Would be nice if app was rainbow colored' on item 'ComHcssMobileTest.UIWindow.UITextView3'.", repo.ComHcssMobileTest.UIWindow.UITextView3Info, new RecordItemIndex(7));
            repo.ComHcssMobileTest.UIWindow.UITextView3.Element.SetAttributeValue("Text", "Would be nice if app was rainbow colored");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssMobileTest.UIWindow.CellEmail' at Center", repo.ComHcssMobileTest.UIWindow.CellEmailInfo, new RecordItemIndex(8));
            repo.ComHcssMobileTest.UIWindow.CellEmail.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'sent an email to Todd's mother about his behavior' on item 'ComHcssMobileTest.UIWindow.UITextView6'.", repo.ComHcssMobileTest.UIWindow.UITextView6Info, new RecordItemIndex(9));
            repo.ComHcssMobileTest.UIWindow.UITextView6.Element.SetAttributeValue("Text", "sent an email to Todd's mother about his behavior");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
