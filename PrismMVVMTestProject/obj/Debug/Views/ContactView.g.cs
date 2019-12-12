﻿#pragma checksum "..\..\..\Views\ContactView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D03B5490E432526E54B6ACFB4567F0336C8953D877772FC3B7B86C7AA60396D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PrismMVVMTestProject.Converters;
using PrismMVVMTestProject.Enums;
using PrismMVVMTestProject.Properties;
using PrismMVVMTestProject.Views;
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


namespace PrismMVVMTestProject.Views {
    
    
    /// <summary>
    /// ContactView
    /// </summary>
    public partial class ContactView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabContacts;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabAddContact;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateDOB;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCountryCode;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabMyContacts;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\ContactView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdContacts;
        
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
            System.Uri resourceLocater = new System.Uri("/PrismMVVMTestProject;component/views/contactview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ContactView.xaml"
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
            this.tabContacts = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.tabAddContact = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dateDOB = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.cmbCountryCode = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.tabMyContacts = ((System.Windows.Controls.TabItem)(target));
            return;
            case 12:
            this.grdContacts = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

