﻿#pragma checksum "..\..\..\..\Admin\HomeScreenAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0C9C1BD2193E34395BF2ED9E170C36BA6EC1CCF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// HomeScreenAdmin
    /// </summary>
    public partial class HomeScreenAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project_ManageStudent_PRN212;component/admin/homescreenadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 50 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 70 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnManageAccountTeacher);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 71 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnManageAccountStudent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 72 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnManageCourses);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 74 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMangeRoom);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 75 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnManageStudent);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 76 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnManageClass);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 82 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDashboard_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 89 "..\..\..\..\Admin\HomeScreenAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSchedule_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

