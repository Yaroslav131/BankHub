﻿#pragma checksum "..\..\..\TransitMoneyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AECE5FA794ACBABFB43616D995CFAF88F2EC4AA2"
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
    /// TransitMoneyWindow
    /// </summary>
    public partial class TransitMoneyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 167 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NumberStackPanel;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AccError;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox accList;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AccRecListError;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AccRecList;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MoneyError;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Money;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\..\TransitMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TransitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BankHub_6.7;V1.0.0.0;component/transitmoneywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TransitMoneyWindow.xaml"
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
            this.AccError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.accList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 199 "..\..\..\TransitMoneyWindow.xaml"
            this.accList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxAcc_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AccRecListError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.AccRecList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 232 "..\..\..\TransitMoneyWindow.xaml"
            this.AccRecList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxAccRec_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MoneyError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Money = ((System.Windows.Controls.TextBox)(target));
            
            #line 267 "..\..\..\TransitMoneyWindow.xaml"
            this.Money.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 268 "..\..\..\TransitMoneyWindow.xaml"
            this.Money.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Money_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TransitButton = ((System.Windows.Controls.Button)(target));
            
            #line 297 "..\..\..\TransitMoneyWindow.xaml"
            this.TransitButton.Click += new System.Windows.RoutedEventHandler(this.ButtonBase_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

