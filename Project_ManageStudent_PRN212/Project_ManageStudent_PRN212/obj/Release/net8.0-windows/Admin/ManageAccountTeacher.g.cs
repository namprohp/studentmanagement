﻿#pragma checksum "..\..\..\..\Admin\ManageAccountTeacher.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843BB3FA8DE7E3260062A67D4695F923726BFEB3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_ManageStudent_PRN212.Admin;
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


namespace Project_ManageStudent_PRN212.Admin {
    
    
    /// <summary>
    /// ManageAccountTeacher
    /// </summary>
    public partial class ManageAccountTeacher : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 98 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTeachers;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTeacherID;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTeacherName;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMale;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFemale;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtBirthDate;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/admin/manageaccountteacher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            ((Project_ManageStudent_PRN212.Admin.ManageAccountTeacher)(target)).Loaded += new System.Windows.RoutedEventHandler(this.window_load);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 87 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvTeachers = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txtTeacherID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtTeacherName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.rbMale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.rbFemale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtBirthDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 151 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInsertClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 152 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdateClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 153 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteClick);
            
            #line default
            #line hidden
            return;
            case 15:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 156 "..\..\..\..\Admin\ManageAccountTeacher.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchInfoTeacher);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
