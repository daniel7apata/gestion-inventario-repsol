﻿#pragma checksum "..\..\Reportes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D888E9907DC7B62394750B98AACB6B1277BFFDA4ACA22B18AAA79E832C02F73B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Prensentacion;
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


namespace Prensentacion {
    
    
    /// <summary>
    /// Reportes
    /// </summary>
    public partial class Reportes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Reportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtmayorcombus;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Reportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtciudadmasenvios;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Reportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmayorcombustible;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Reportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnciudadmasenvios;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Reportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtordenar;
        
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
            System.Uri resourceLocater = new System.Uri("/Prensentacion;component/reportes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Reportes.xaml"
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
            this.dtmayorcombus = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\Reportes.xaml"
            this.dtmayorcombus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dtmayorcombus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtciudadmasenvios = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.txtmayorcombustible = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 26 "..\..\Reportes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnciudadmasenvios = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Reportes.xaml"
            this.btnciudadmasenvios.Click += new System.Windows.RoutedEventHandler(this.btnciudadmasenvios_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\Reportes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dtordenar = ((System.Windows.Controls.DataGrid)(target));
            
            #line 29 "..\..\Reportes.xaml"
            this.dtordenar.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dtordenar_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 30 "..\..\Reportes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

