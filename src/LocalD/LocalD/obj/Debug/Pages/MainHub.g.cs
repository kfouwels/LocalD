﻿#pragma checksum "E:\User1\SkyDrive\MyDocs\dev\Work\LocalD\locald-windows-phone\src\LocalD\LocalD\Pages\MainHub.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1E12A77048285C768928B1EE4B1416E8"
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


namespace LocalD {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Viewbox CameraViewbox;
        
        internal System.Windows.Controls.Canvas ViewfinderCanvas;
        
        internal System.Windows.Media.VideoBrush ViewfinderBrush;
        
        internal System.Windows.Media.CompositeTransform ViewfinderTransform;
        
        internal System.Windows.Controls.TextBlock Status;
        
        internal System.Windows.Controls.TextBlock Resolution;
        
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
            this.CameraViewbox = ((System.Windows.Controls.Viewbox)(this.FindName("CameraViewbox")));
            this.ViewfinderCanvas = ((System.Windows.Controls.Canvas)(this.FindName("ViewfinderCanvas")));
            this.ViewfinderBrush = ((System.Windows.Media.VideoBrush)(this.FindName("ViewfinderBrush")));
            this.ViewfinderTransform = ((System.Windows.Media.CompositeTransform)(this.FindName("ViewfinderTransform")));
            this.Status = ((System.Windows.Controls.TextBlock)(this.FindName("Status")));
            this.Resolution = ((System.Windows.Controls.TextBlock)(this.FindName("Resolution")));
        }
    }
}
