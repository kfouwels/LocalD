﻿#pragma checksum "E:\User1\SkyDrive\MyDocs\dev\Work\LocalD\locald-windows-phone\src\LocalD\LocalD\Pages\MainHub.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7A27D7304563594CAEED2DCCF802AA57"
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


namespace LocalD {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama MainPano;
        
        internal System.Windows.Controls.TextBlock PanoramaTitle;
        
        internal Microsoft.Phone.Controls.PanoramaItem Panelminus1;
        
        internal Microsoft.Phone.Controls.PanoramaItem Panel1News;
        
        internal System.Windows.Controls.ListBox NewsFeedBox;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton RefreshAppButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LocalD;component/Pages/MainHub.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.MainPano = ((Microsoft.Phone.Controls.Panorama)(this.FindName("MainPano")));
            this.PanoramaTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PanoramaTitle")));
            this.Panelminus1 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Panelminus1")));
            this.Panel1News = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Panel1News")));
            this.NewsFeedBox = ((System.Windows.Controls.ListBox)(this.FindName("NewsFeedBox")));
            this.RefreshAppButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("RefreshAppButton")));
        }
    }
}

