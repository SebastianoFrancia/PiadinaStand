﻿#pragma checksum "..\..\..\OrdinePagina.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26234385774A4B1E8DAAA6AFE07B4ADFE2DAB33B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using LAB_MARZO_FRANCIA_SEBASTIANO;
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


namespace LAB_MARZO_FRANCIA_SEBASTIANO {
    
    
    /// <summary>
    /// OrdinePagina
    /// </summary>
    public partial class OrdinePagina : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxMenu;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuantitaTitle;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPiu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPiu_Copy;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuantita;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgiungiOrdine;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRimuoviOrdine;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\OrdinePagina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOrdine;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LAB_MARZO_FRANCIA_SEBASTIANO;component/ordinepagina.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\OrdinePagina.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbxMenu = ((System.Windows.Controls.ListBox)(target));
            
            #line 13 "..\..\..\OrdinePagina.xaml"
            this.lbxMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbxMenu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblQuantitaTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnPiu = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\OrdinePagina.xaml"
            this.btnPiu.Click += new System.Windows.RoutedEventHandler(this.btnPiu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnPiu_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\OrdinePagina.xaml"
            this.btnPiu_Copy.Click += new System.Windows.RoutedEventHandler(this.btnPiu_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblQuantita = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnAgiungiOrdine = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\OrdinePagina.xaml"
            this.btnAgiungiOrdine.Click += new System.Windows.RoutedEventHandler(this.btnAgiungiOrdine_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnRimuoviOrdine = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.lblOrdine = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

