﻿#pragma checksum "..\..\..\TravelWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98D3D9D461C3DD7034EAEB139FD61E7F09CEF69F"
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
using TravelPal_App;


namespace TravelPal_App {
    
    
    /// <summary>
    /// TravelWindow
    /// </summary>
    public partial class TravelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSignedInUser;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUserSetting;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDashBoard;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTravel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdmin;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignOut;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\TravelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame _mainframeWindow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TravelPal_App;component/travelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TravelWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblSignedInUser = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnUserSetting = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\TravelWindow.xaml"
            this.btnUserSetting.Click += new System.Windows.RoutedEventHandler(this.userSettings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDashBoard = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\TravelWindow.xaml"
            this.btnDashBoard.Click += new System.Windows.RoutedEventHandler(this.btnDashBoard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAddTravel = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\TravelWindow.xaml"
            this.btnAddTravel.Click += new System.Windows.RoutedEventHandler(this.btnAddTravel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\TravelWindow.xaml"
            this.btnAdmin.Click += new System.Windows.RoutedEventHandler(this.btnAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSignOut = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\TravelWindow.xaml"
            this.btnSignOut.Click += new System.Windows.RoutedEventHandler(this.btnSignOut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._mainframeWindow = ((System.Windows.Controls.Frame)(target));
            
            #line 72 "..\..\..\TravelWindow.xaml"
            this._mainframeWindow.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this._mainframeWindow_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
