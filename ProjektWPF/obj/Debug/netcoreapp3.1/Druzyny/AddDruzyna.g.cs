﻿#pragma checksum "..\..\..\..\Druzyny\AddDruzyna.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC4AAC862856D3D8F811D25D42FD0D913E99ACFC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektWPF.Druzyny;
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


namespace ProjektWPF.Druzyny {
    
    
    /// <summary>
    /// AddDruzyna
    /// </summary>
    public partial class AddDruzyna : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddDruzGrid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NazwaTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KrajTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SiedzibaTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SukcesyTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDynamic;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SponsorzyTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Druzyny\AddDruzyna.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WlasicielTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjektWPF;component/druzyny/adddruzyna.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Druzyny\AddDruzyna.xaml"
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
            this.AddDruzGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 10 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            this.AddDruzGrid.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.validationError));
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 31 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ImageFromFile);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NazwaTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            this.NazwaTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NazwaValid);
            
            #line default
            #line hidden
            return;
            case 4:
            this.KrajTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            this.KrajTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.KrajValid);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SiedzibaTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            this.SiedzibaTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SiedzibaValid);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SukcesyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.imgDynamic = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.SponsorzyTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            this.SponsorzyTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SponsorzyValid);
            
            #line default
            #line hidden
            return;
            case 9:
            this.WlasicielTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            this.WlasicielTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WlascicielValid);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 43 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 44 "..\..\..\..\Druzyny\AddDruzyna.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

