﻿#pragma checksum "..\..\..\AddMoneyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5F104B63DFEF82983F53C23FFFEB15E4C703E23B"
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
    /// AddMoneyWindow
    /// </summary>
    public partial class AddMoneyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 192 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NumberStackPanel;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CardNameError;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cardList;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PasswordError;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordName;
        
        #line default
        #line hidden
        
        
        #line 280 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MoneyError;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Money;
        
        #line default
        #line hidden
        
        
        #line 319 "..\..\..\AddMoneyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BankHub_6.7;component/addmoneywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddMoneyWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\AddMoneyWindow.xaml"
            ((BankHub_6._7.AddMoneyWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.FocusWindow_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NumberStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.CardNameError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.cardList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 223 "..\..\..\AddMoneyWindow.xaml"
            this.cardList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PasswordError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.PasswordName = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 256 "..\..\..\AddMoneyWindow.xaml"
            this.PasswordName.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 257 "..\..\..\AddMoneyWindow.xaml"
            this.PasswordName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Password_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MoneyError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Money = ((System.Windows.Controls.TextBox)(target));
            
            #line 287 "..\..\..\AddMoneyWindow.xaml"
            this.Money.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 288 "..\..\..\AddMoneyWindow.xaml"
            this.Money.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Money_OnPreviewTextInput_OnPreviewTextInputOnPreviewTextInputTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 318 "..\..\..\AddMoneyWindow.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Button_AddClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

