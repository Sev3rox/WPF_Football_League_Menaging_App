﻿#pragma checksum "..\..\..\..\Rozgrywki\AddRozgrywka.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6AAE4E3ADBF04874D6059D869D45452F2C2B60F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using System.Windows.Forms.Integration;
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
    /// AddRozgrywka
    /// </summary>
    public partial class AddRozgrywka : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddGrid;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SedziaglownyTextBox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Team1;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Team2;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar DateCalendar;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HourTextBox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlaceTextBox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ProjektWPF;component/rozgrywki/addrozgrywka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
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
            this.AddGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 45 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.AddGrid.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.validationError));
            
            #line default
            #line hidden
            return;
            case 2:
            this.SedziaglownyTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.SedziaglownyTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SedziaglownyVali);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Team1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 95 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.Team1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Team1sel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Team2 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.Team2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Team2sel);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DateCalendar = ((System.Windows.Controls.Calendar)(target));
            return;
            case 6:
            this.HourTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 103 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.HourTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.HourFocus);
            
            #line default
            #line hidden
            
            #line 103 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.HourTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.HourVali);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PlaceTextBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 104 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            this.PlaceTextBox.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PlaceVali);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MyAnimatedTransform = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 9:
            
            #line 146 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 147 "..\..\..\..\Rozgrywki\AddRozgrywka.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

