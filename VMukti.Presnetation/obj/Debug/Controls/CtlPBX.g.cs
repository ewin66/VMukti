﻿#pragma checksum "..\..\..\Controls\CtlPBX.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85320A0C31959730C870349F7551E9D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace VMukti.Presentation.Controls {
    
    
    /// <summary>
    /// CtlPBX
    /// </summary>
    public partial class CtlPBX : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Canvas Canvas;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Canvas ModulePBX;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Shapes.Rectangle ModulePBXTitle;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Label UName_M;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Label Passwd_M;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Label ConfirmPasswd_M;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Label DName_M;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.TextBlock ModuleConfig;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.TextBox txtUserName_M;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.PasswordBox txtPassword_M;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.PasswordBox txtConfirmPassword_M;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.TextBox txtDirname_M;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Controls\CtlPBX.xaml"
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VMukti.Presentation;component/controls/ctlpbx.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\CtlPBX.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.ModulePBX = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.ModulePBXTitle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.UName_M = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Passwd_M = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ConfirmPasswd_M = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.DName_M = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.ModuleConfig = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtUserName_M = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtPassword_M = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 11:
            this.txtConfirmPassword_M = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 12:
            this.txtDirname_M = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Controls\CtlPBX.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Controls\CtlPBX.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
