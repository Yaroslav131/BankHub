#pragma checksum "..\..\..\ChangePasswordWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FCA22153B79D1E9F7CACB7794026054AB4891033"
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
    /// ChangePasswordWindow
    /// </summary>
    public partial class ChangePasswordWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel NumberStackPanel;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PasswordError;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RepiatePasswordError;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ReapeatPassword;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exete;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\ChangePasswordWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangePasswordButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BankHub_6.7;component/changepasswordwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChangePasswordWindow.xaml"
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
            
            #line 16 "..\..\..\ChangePasswordWindow.xaml"
            ((BankHub_6._7.ChangePasswordWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.FocusWindow_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NumberStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.PasswordError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 115 "..\..\..\ChangePasswordWindow.xaml"
            this.Password.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\ChangePasswordWindow.xaml"
            this.Password.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Password_OnPreviewTextInput_OnPreviewTextInputTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RepiatePasswordError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ReapeatPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 150 "..\..\..\ChangePasswordWindow.xaml"
            this.ReapeatPassword.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 151 "..\..\..\ChangePasswordWindow.xaml"
            this.ReapeatPassword.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Password2_OnPreviewTextInput_OnPreviewTextInputTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exete = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.ChangePasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 182 "..\..\..\ChangePasswordWindow.xaml"
            this.ChangePasswordButton.Click += new System.Windows.RoutedEventHandler(this.Button_ChangeClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

