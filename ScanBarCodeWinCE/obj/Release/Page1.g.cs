﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "365C6D97E047518E607D2450F26924C4C0BCF8672000F723004F4448320854EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ScanBarCodeWinCE;
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


namespace ScanBarCodeWinCE {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _btnClear;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton _toggleFocus;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _txbInput;
        
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
            System.Uri resourceLocater = new System.Uri("/ScanBarCodeWinCE;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
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
            this._btnClear = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Page1.xaml"
            this._btnClear.Click += new System.Windows.RoutedEventHandler(this._btnClear_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this._toggleFocus = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 19 "..\..\Page1.xaml"
            this._toggleFocus.Checked += new System.Windows.RoutedEventHandler(this._toggleFocus_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\Page1.xaml"
            this._toggleFocus.Unchecked += new System.Windows.RoutedEventHandler(this._toggleFocus_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this._txbInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\Page1.xaml"
            this._txbInput.IsKeyboardFocusedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this._txbInput_IsKeyboardFocusedChanged);
            
            #line default
            #line hidden
            
            #line 24 "..\..\Page1.xaml"
            this._txbInput.KeyDown += new System.Windows.Input.KeyEventHandler(this._txbInput_KeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

