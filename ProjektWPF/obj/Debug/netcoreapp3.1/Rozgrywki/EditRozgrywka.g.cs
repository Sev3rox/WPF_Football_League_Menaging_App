﻿#pragma checksum "..\..\..\..\Rozgrywki\EditRozgrywka.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6E3896795A80B82ABBF382136E512D1A2E674B25"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektWPF.Rozgrywki;
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


namespace ProjektWPF.Rozgrywki {
    
    
    /// <summary>
    /// EditRozgrywka
    /// </summary>
    public partial class EditRozgrywka : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid EditGrid;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SedziaglownyTextBox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Team1;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Team2;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar DateCalendar;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HourTextBox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlaceTextBox;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform MyAnimatedTransform;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjektWPF;component/rozgrywki/editrozgrywka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EditGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SedziaglownyTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            this.SedziaglownyTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SedziaglownyVali);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Team1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 95 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            this.Team1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Team1sel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Team2 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            this.Team2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Team2sel);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DateCalendar = ((System.Windows.Controls.Calendar)(target));
            return;
            case 6:
            this.HourTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 103 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            this.HourTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.HourFocus);
            
            #line default
            #line hidden
            
            #line 103 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            this.HourTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.HourVali);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PlaceTextBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 104 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            this.PlaceTextBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PlaceVali);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MyAnimatedTransform = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 9:
            
            #line 148 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 149 "..\..\..\..\Rozgrywki\EditRozgrywka.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

