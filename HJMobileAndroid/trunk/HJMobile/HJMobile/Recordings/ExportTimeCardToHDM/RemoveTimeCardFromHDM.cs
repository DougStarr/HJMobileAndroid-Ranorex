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
    ///The RemoveTimeCardFromHDM recording.
    /// </summary>
    [TestModule("48d673d7-2c83-43b0-88fb-5d357970da2c", ModuleType.Recording, 1)]
    public partial class RemoveTimeCardFromHDM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static RemoveTimeCardFromHDM instance = new RemoveTimeCardFromHDM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveTimeCardFromHDM()
        {
            ConnectionString = "Data Source=a0dkrsitmm.database.windows.net;Initial Catalog=Automation_Company;User ID=db-admin;Password=Hcss*123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoveTimeCardFromHDM Instance
        {
            get { return instance; }
        }

#region Variables

        string _ConnectionString;

        /// <summary>
        /// Gets or sets the value of variable ConnectionString.
        /// </summary>
        [TestVariable("25ddfbae-e5c1-4a0e-9f91-ebb3d4a99faa")]
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
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

            RemoveTimeCard(ConnectionString);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}