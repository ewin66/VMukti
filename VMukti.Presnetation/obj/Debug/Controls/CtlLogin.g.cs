﻿#pragma checksum "..\..\..\Controls\CtlLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FB40D5F5F2425A71B2AAEBA52A093B00"
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
    /// CtlLogin
    /// </summary>
    public partial class CtlLogin : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Controls\CtlLogin.xaml"
        internal VMukti.Presentation.Controls.CtlLogin ucLogin;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Canvas cnvMain;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Label lblUserNameID;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.TextBox txtUserNameID;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Label lblPasword;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.PasswordBox pwdPasssword;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.CheckBox chkRememberMe;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.CheckBox chkSigninAuto;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Label lblForgotYourPassword;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Button btnForgetPass;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Button btnLogIn;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Button btnSignUp;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Controls\CtlLogin.xaml"
        internal System.Windows.Controls.Label lblValidate;
        
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
            System.Uri resourceLocater = new System.Uri("/VMukti.Presentation;component/controls/ctllogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\CtlLogin.xaml"
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
            this.ucLogin = ((VMukti.Presentation.Controls.CtlLogin)(target));
            return;
            case 2:
            this.cnvMain = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.lblUserNameID = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtUserNameID = ((System.Windows.Controls.TextBox)(target));
            
            #line 98 "..\..\..\Controls\CtlLogin.xaml"
            this.txtUserNameID.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtUserNameID_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblPasword = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.pwdPasssword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 100 "..\..\..\Controls\CtlLogin.xaml"
            this.pwdPasssword.KeyDown += new System.Windows.Input.KeyEventHandler(this.pwdPasssword_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.chkRememberMe = ((System.Windows.Controls.CheckBox)(target));
            
            #line 102 "..\..\..\Controls\CtlLogin.xaml"
            this.chkRememberMe.Checked += new System.Windows.RoutedEventHandler(this.chkRememberMe_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.chkSigninAuto = ((System.Windows.Controls.CheckBox)(target));
            
            #line 103 "..\..\..\Controls\CtlLogin.xaml"
            this.chkSigninAuto.Checked += new System.Windows.RoutedEventHandler(this.chkSigninAuto_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblForgotYourPassword = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btnForgetPass = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\Controls\CtlLogin.xaml"
            this.btnForgetPass.Click += new System.Windows.RoutedEventHandler(this.btnForgetPassClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnLogIn = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\Controls\CtlLogin.xaml"
            this.btnLogIn.Click += new System.Windows.RoutedEventHandler(this.btnLogIn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnSignUp = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Controls\CtlLogin.xaml"
            this.btnSignUp.Click += new System.Windows.RoutedEventHandler(this.btnSignUp_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.lblValidate = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
