﻿#pragma checksum "E:\User1\SkyDrive\MyDocs\dev\Work\LocalD\locald-windows-phone\src\LocalD\LocalD\Pages\UserLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9D420CF5595C7716FC24A702011ADAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace LocalD.Pages {
    
    
    public partial class UserLogin : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox UserUsername;
        
        internal System.Windows.Controls.PasswordBox UserPwd;
        
        internal System.Windows.Controls.Button UserToRegister;
        
        internal System.Windows.Controls.Button UserToLogin;
        
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
        internal Microsoft.Phone.Shell.ApplicationBar AppBar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LocalD;component/Pages/UserLogin.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.UserUsername = ((System.Windows.Controls.TextBox)(this.FindName("UserUsername")));
            this.UserPwd = ((System.Windows.Controls.PasswordBox)(this.FindName("UserPwd")));
            this.UserToRegister = ((System.Windows.Controls.Button)(this.FindName("UserToRegister")));
            this.UserToLogin = ((System.Windows.Controls.Button)(this.FindName("UserToLogin")));
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("ProgressBar")));
            this.AppBar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("AppBar")));
        }
    }
}

