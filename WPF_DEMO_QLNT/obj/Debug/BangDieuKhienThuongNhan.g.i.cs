﻿#pragma checksum "..\..\BangDieuKhienThuongNhan.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4148672EC6511B5D4D41BC72BCB33F9281950299"
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
    /// BangDieuKhienThuongNhan
    /// </summary>
    public partial class BangDieuKhienThuongNhan : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\BangDieuKhienThuongNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMua;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\BangDieuKhienThuongNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTroVe;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\BangDieuKhienThuongNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridDanhSachSanPham;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\BangDieuKhienThuongNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxGia;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_DEMO_QLNT;component/bangdieukhienthuongnhan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BangDieuKhienThuongNhan.xaml"
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
            
            #line 26 "..\..\BangDieuKhienThuongNhan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Them);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonMua = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\BangDieuKhienThuongNhan.xaml"
            this.ButtonMua.Click += new System.Windows.RoutedEventHandler(this.ButtonMua_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 44 "..\..\BangDieuKhienThuongNhan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Tim_Kiem);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonTroVe = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\BangDieuKhienThuongNhan.xaml"
            this.ButtonTroVe.Click += new System.Windows.RoutedEventHandler(this.ButtonTroVe_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataGridDanhSachSanPham = ((System.Windows.Controls.DataGrid)(target));
            
            #line 66 "..\..\BangDieuKhienThuongNhan.xaml"
            this.DataGridDanhSachSanPham.Initialized += new System.EventHandler(this.DataGridDanhSachSanPham_Initialized);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxGia = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
