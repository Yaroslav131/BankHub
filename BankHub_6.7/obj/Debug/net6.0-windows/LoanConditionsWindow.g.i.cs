﻿#pragma checksum "..\..\..\LoanConditionsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "676FEDFE66CE2F3668E6ED95D3B9699C2D73A038"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BankHub_6._7;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace BankHub_6._7 {
    
    
    /// <summary>
    /// LoanConditionsWindow
    /// </summary>
    public partial class LoanConditionsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 97 "..\..\..\LoanConditionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NumberStackPanel;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\LoanConditionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Accept;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\LoanConditionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Continue;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BankHub_6.7;V1.0.0.0;component/loanconditionswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoanConditionsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NumberStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Accept = ((System.Windows.Controls.RadioButton)(target));
            
            #line 121 "..\..\..\LoanConditionsWindow.xaml"
            this.Accept.Click += new System.Windows.RoutedEventHandler(this.Accept_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Continue = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\LoanConditionsWindow.xaml"
            this.Continue.Click += new System.Windows.RoutedEventHandler(this.AcceptClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

