﻿#pragma checksum "..\..\Lich.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F1FAD4BCDA9AFDD7E8E6AE5F8D0CECE8299B12D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Shell;
using WPF_DEMO_QLNT;


namespace WPF_DEMO_QLNT {
    
    
    /// <summary>
    /// Lich
    /// </summary>
    public partial class Lich : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Lich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTroVe;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Lich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid_Lich;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_DEMO_QLNT;component/lich.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Lich.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ButtonTroVe = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Lich.xaml"
            this.ButtonTroVe.Click += new System.Windows.RoutedEventHandler(this.ButtonTroVe_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGrid_Lich = ((System.Windows.Controls.DataGrid)(target));
            
            #line 74 "..\..\Lich.xaml"
            this.DataGrid_Lich.Initialized += new System.EventHandler(this.DataGrid_Lich_Initialized);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

