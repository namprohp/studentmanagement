﻿#pragma checksum "..\..\..\..\Admin\ManageClass.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F99049DA8D2316EAEAAAAA81220A300844E8305D"
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
    /// ManageClass
    /// </summary>
    public partial class ManageClass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 94 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvClass;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbClass;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClassID;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtClassname;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbCourse;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbTeacherID;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\Admin\ManageClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbRoom;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Admin\ManageClass.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/admin/manageclass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ManageClass.xaml"
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
            
            #line 9 "..\..\..\..\Admin\ManageClass.xaml"
            ((Project_ManageStudent_PRN212.Admin.ManageClass)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Load);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 84 "..\..\..\..\Admin\ManageClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvClass = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.cbbClass = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txtClassID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtClassname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cbbCourse = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.cbbTeacherID = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cbbRoom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            
            #line 148 "..\..\..\..\Admin\ManageClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInsertClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 149 "..\..\..\..\Admin\ManageClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdateClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 150 "..\..\..\..\Admin\ManageClass.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 153 "..\..\..\..\Admin\ManageClass.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchInfoClass);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

