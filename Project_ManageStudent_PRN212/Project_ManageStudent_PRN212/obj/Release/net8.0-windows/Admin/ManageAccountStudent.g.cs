﻿#pragma checksum "..\..\..\..\Admin\ManageAccountStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8EAC46ABC36EC3A16BFC519E21536972ABBA8318"
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
    /// ManageAccountStudent
    /// </summary>
    public partial class ManageAccountStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 97 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvStudents;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStudentID;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStudentName;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbMale;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbFemale;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtBirthDate;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Admin\ManageAccountStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\Admin\ManageAccountStudent.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/admin/manageaccountstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ManageAccountStudent.xaml"
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
            
            #line 9 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((Project_ManageStudent_PRN212.Admin.ManageAccountStudent)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Load);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 88 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvStudents = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txtStudentID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtStudentName = ((System.Windows.Controls.TextBox)(target));
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
            
            #line 149 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInsertClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 150 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdateClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 151 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 154 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnImportXML_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 155 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSaveXml_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 156 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnImportStudent);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 157 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSaveJson_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 160 "..\..\..\..\Admin\ManageAccountStudent.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchInfoStudent);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

