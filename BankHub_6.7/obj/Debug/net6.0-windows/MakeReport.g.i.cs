﻿#pragma checksum "..\..\..\MakeReport.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3CE1C5F3C8252AA0C2C87CD5A80D446F66DAFF30"
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
    /// MakeReport
    /// </summary>
    public partial class MakeReport : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\..\MakeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TypeError;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MakeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem ReportTreeViewItem;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\MakeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Day;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\MakeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Month;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\MakeReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeViewItem Year;
        
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
            System.Uri resourceLocater = new System.Uri("/BankHub_6.7;V1.0.0.0;component/makereport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MakeReport.xaml"
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
            this.TypeError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ReportTreeViewItem = ((System.Windows.Controls.TreeViewItem)(target));
            return;
            case 3:
            this.Day = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 106 "..\..\..\MakeReport.xaml"
            this.Day.Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Month = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 109 "..\..\..\MakeReport.xaml"
            this.Month.Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Year = ((System.Windows.Controls.TreeViewItem)(target));
            
            #line 112 "..\..\..\MakeReport.xaml"
            this.Year.Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 137 "..\..\..\MakeReport.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MakeReport_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

