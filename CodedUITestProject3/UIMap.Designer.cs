﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinButton uIStartButton = this.UIStartWindow.UIStartButton;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(27, 27));
        }
        
        #region Properties
        public UIStartWindow UIStartWindow
        {
            get
            {
                if ((this.mUIStartWindow == null))
                {
                    this.mUIStartWindow = new UIStartWindow();
                }
                return this.mUIStartWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIStartWindow mUIStartWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIStartWindow : WinWindow
    {
        
        public UIStartWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Start";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("Start");
            #endregion
        }
        
        #region Properties
        public WinButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WinButton.PropertyNames.Name] = "Start";
                    this.mUIStartButton.WindowTitles.Add("Start");
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIStartButton;
        #endregion
    }
}
