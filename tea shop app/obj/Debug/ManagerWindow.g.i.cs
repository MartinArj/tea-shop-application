﻿#pragma checksum "..\..\ManagerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E13E544D1603796AFD15897A8CCE4096DF63EA04"
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


namespace tea_shop_app {
    
    
    /// <summary>
    /// ManagerWindow
    /// </summary>
    public partial class ManagerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton product;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel product_panal;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton resource;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel resource_pannel;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button remove;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button emp_view;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock id;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border l;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_btn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame manager;
        
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
            System.Uri resourceLocater = new System.Uri("/tea shop app;component/managerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManagerWindow.xaml"
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
            this.product = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 24 "..\..\ManagerWindow.xaml"
            this.product.Click += new System.Windows.RoutedEventHandler(this.product_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.product_panal = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 26 "..\..\ManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_product);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\ManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_product);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 30 "..\..\ManagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.view);
            
            #line default
            #line hidden
            return;
            case 6:
            this.resource = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 34 "..\..\ManagerWindow.xaml"
            this.resource.Click += new System.Windows.RoutedEventHandler(this.resource_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.resource_pannel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\ManagerWindow.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.add_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.remove = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ManagerWindow.xaml"
            this.remove.Click += new System.Windows.RoutedEventHandler(this.remove_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.emp_view = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ManagerWindow.xaml"
            this.emp_view.Click += new System.Windows.RoutedEventHandler(this.emp_view_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            this.id = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.l = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            this.logout_btn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\ManagerWindow.xaml"
            this.logout_btn.Click += new System.Windows.RoutedEventHandler(this.logout_btn_Click_1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.manager = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

