﻿#pragma checksum "C:\Users\João Pedro Dias\Documents\Visual Studio 2013\Projects\LightningDistance\LightningDistance\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "11EC0A2D5A7825DFB94272843762B8DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
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


namespace LightningDistance {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button Click;
        
        internal System.Windows.Controls.TextBlock time;
        
        internal System.Windows.Controls.TextBlock Dist;
        
        internal System.Windows.Controls.ListBox lista;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LightningDistance;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Click = ((System.Windows.Controls.Button)(this.FindName("Click")));
            this.time = ((System.Windows.Controls.TextBlock)(this.FindName("time")));
            this.Dist = ((System.Windows.Controls.TextBlock)(this.FindName("Dist")));
            this.lista = ((System.Windows.Controls.ListBox)(this.FindName("lista")));
        }
    }
}
