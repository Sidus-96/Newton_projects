﻿#pragma checksum "..\..\..\AddPlantWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2E2C68B8DB4C2BF26FABFEFF0A4E8D4810726E49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GreenThumb;
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


namespace GreenThumb {
    
    
    /// <summary>
    /// AddPlantWindow
    /// </summary>
    public partial class AddPlantWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddPlant;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddInstruction;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddInsctruction;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstNewInstructions;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPlant;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GreenThumb;component/addplantwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddPlantWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtAddPlant = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\AddPlantWindow.xaml"
            this.txtAddPlant.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtAddPlant_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtAddInstruction = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\AddPlantWindow.xaml"
            this.txtAddInstruction.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtAddInsctruction_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAddInsctruction = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AddPlantWindow.xaml"
            this.btnAddInsctruction.Click += new System.Windows.RoutedEventHandler(this.btnAddInsctruction_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstNewInstructions = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.btnAddPlant = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\AddPlantWindow.xaml"
            this.btnAddPlant.Click += new System.Windows.RoutedEventHandler(this.btnAddPlant_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnGoBack = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\AddPlantWindow.xaml"
            this.btnGoBack.Click += new System.Windows.RoutedEventHandler(this.btnGoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
