﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace HJMobileAndroid.Recordings.ExportTimeCardToHDM
{
    public partial class RemoveTimeCardFromHJ
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        private void TypeColon()
        {
        	int count = 0;
        	Validate.Options myOptions = new Validate.Options(false,ReportLevel.Info);
        	Imaging.FindOptions myFindOptions = new Imaging.FindOptions(1);
        	
        	Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence '{RShiftKey down}'.", new RecordItemIndex(3));
            Keyboard.Press("{RShiftKey down}");
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence ':'.", new RecordItemIndex(5));
            Keyboard.Press(":");
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence '{RShiftKey up}'.", new RecordItemIndex(7));
            Keyboard.Press("{RShiftKey up}");
            Delay.Milliseconds(300);
        	
            while(!Validate.ContainsImage(repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo, repo.QaAutomationQaAutomationRemoteD.OPWindowClassInfo.GetScreenshot6(new Rectangle(25, 1000, 15, 15)), myFindOptions, "Validating that the colon exists", myOptions) && count < 5)
            {
            	Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence '{Back}'.", new RecordItemIndex(7));
            	Keyboard.Press("{Back}");
            	Delay.Milliseconds(300);
            	
            	Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence '{RShiftKey down}'.", new RecordItemIndex(3));
            	Keyboard.Press("{RShiftKey down}");
            	Delay.Milliseconds(300);
            
            	Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(4));
            	Delay.Duration(1000, false);
            
            	Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence ':'.", new RecordItemIndex(5));
            	Keyboard.Press(":");
            	Delay.Milliseconds(300);
            
            	Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(6));
            	Delay.Duration(1000, false);
            
            	Report.Log(ReportLevel.Info, "Keyboard", "Removing Time Card from HJ\r\nKey sequence '{RShiftKey up}'.", new RecordItemIndex(7));
            	Keyboard.Press("{RShiftKey up}");
            	Delay.Milliseconds(300);
            	
            	count++;
            }
        }

    }
}