﻿#pragma checksum "..\..\..\..\Students\HomeScreenStudent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603DF7E16F6BF91E741136A99EC7CE447077D485"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_ManageStudent_PRN212.Student;
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


namespace Project_ManageStudent_PRN212.Student {
    
    
    /// <summary>
    /// HomeScreenStudent
    /// </summary>
    public partial class HomeScreenStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 95 "..\..\..\..\Students\HomeScreenStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvStudents;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Students\HomeScreenStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbClassId;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Students\HomeScreenStudent.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/students/homescreenstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Students\HomeScreenStudent.xaml"
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
            
            #line 9 "..\..\..\..\Students\HomeScreenStudent.xaml"
            ((Project_ManageStudent_PRN212.Student.HomeScreenStudent)(target)).Loaded += new System.Windows.RoutedEventHandler(this.window_load);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 85 "..\..\..\..\Students\HomeScreenStudent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBackClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvStudents = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.cbbClassId = ((System.Windows.Controls.ComboBox)(target));
            
            #line 122 "..\..\..\..\Students\HomeScreenStudent.xaml"
            this.cbbClassId.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.searchClass);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 123 "..\..\..\..\Students\HomeScreenStudent.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchClass);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

