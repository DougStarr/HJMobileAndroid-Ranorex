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
    ///The MaterialValidationNewData recording.
    /// </summary>
    [TestModule("e2358f78-6f63-4919-b24a-4da998832301", ModuleType.Recording, 1)]
    public partial class MaterialValidationNewData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static MaterialValidationNewData instance = new MaterialValidationNewData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MaterialValidationNewData()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MaterialValidationNewData Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.MoreOptions' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.MoreOptionsInfo, new RecordItemIndex(0));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.MoreOptions.Touch();
            Delay.Milliseconds(500);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComHcssHcssmobileTesting.TimeCardMoreOptionsMenu.TurnOnMaterials' at Center", repo.ComHcssHcssmobileTesting.TimeCardMoreOptionsMenu.TurnOnMaterialsInfo, new RecordItemIndex(1));
                repo.ComHcssHcssmobileTesting.TimeCardMoreOptionsMenu.TurnOnMaterials.Touch();
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.TextTimeCardHasNotBeenSentToHe' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.TextTimeCardHasNotBeenSentToHeInfo, new RecordItemIndex(2));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.TextTimeCardHasNotBeenSentToHe.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHcssHcssmobileTesting.TimeCardEntry.Text010910001' at Center", repo.ComHcssHcssmobileTesting.TimeCardEntry.Text010910001Info, new RecordItemIndex(3));
            repo.ComHcssHcssmobileTesting.TimeCardEntry.Text010910001.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3PERMITS') on item 'ComHcssHcssmobileTesting.Content.N3PERMITS'.", repo.ComHcssHcssmobileTesting.Content.N3PERMITSInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.ComHcssHcssmobileTesting.Content.N3PERMITSInfo, "Text", "3PERMITS");
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='NEWMAT') on item 'ComHcssHcssmobileTesting.Content.NEWMAT'.", repo.ComHcssHcssmobileTesting.Content.NEWMATInfo, new RecordItemIndex(5));
                Validate.Attribute(repo.ComHcssHcssmobileTesting.Content.NEWMATInfo, "Text", "NEWMAT", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
