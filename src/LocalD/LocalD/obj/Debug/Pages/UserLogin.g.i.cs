﻿#pragma checksum "E:\User1\SkyDrive\MyDocs\dev\Work\LocalD\locald-windows-phone\src\LocalD\LocalD\Pages\UserLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63F7191EDDF2D7D57627D7DFDD9E484E"
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
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard SpinningAnimation;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox UserEmail;
        
        internal System.Windows.Controls.PasswordBox UserPwd;
        
        internal System.Windows.Controls.Button UserSubmit;
        
        internal System.Windows.Shapes.Ellipse Spinner;
        
        internal System.Windows.Media.RotateTransform SpinningRotateTransform;
        
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
            this.SpinningAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SpinningAnimation")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.UserEmail = ((System.Windows.Controls.TextBox)(this.FindName("UserEmail")));
            this.UserPwd = ((System.Windows.Controls.PasswordBox)(this.FindName("UserPwd")));
            this.UserSubmit = ((System.Windows.Controls.Button)(this.FindName("UserSubmit")));
            this.Spinner = ((System.Windows.Shapes.Ellipse)(this.FindName("Spinner")));
            this.SpinningRotateTransform = ((System.Windows.Media.RotateTransform)(this.FindName("SpinningRotateTransform")));
        }
    }
}
