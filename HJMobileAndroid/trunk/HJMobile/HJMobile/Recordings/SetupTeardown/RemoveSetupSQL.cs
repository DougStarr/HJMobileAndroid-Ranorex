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

namespace HJMobileAndroid.Recordings.SetupTeardown
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RemoveSetupSQL recording.
    /// </summary>
    [TestModule("fc665058-10bb-4a63-9e8e-cc4b7c2c609a", ModuleType.Recording, 1)]
    public partial class RemoveSetupSQL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HJMobileAndroid.HJMobileAndroidRepository repository.
        /// </summary>
        public static HJMobileAndroid.HJMobileAndroidRepository repo = HJMobileAndroid.HJMobileAndroidRepository.Instance;

        static RemoveSetupSQL instance = new RemoveSetupSQL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveSetupSQL()
        {
            ConnectionString = "Data Source=a0dkrsitmm.database.windows.net;Initial Catalog=Automation_Company;User ID=db-admin;Password=Hcss*123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoveSetupSQL Instance
        {
            get { return instance; }
        }

#region Variables

        string _ConnectionString;

        /// <summary>
        /// Gets or sets the value of variable ConnectionString.
        /// </summary>
        [TestVariable("64382b6b-8d06-4d6e-8954-0786d99c2f38")]
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

            RemoveSetups(ConnectionString);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
