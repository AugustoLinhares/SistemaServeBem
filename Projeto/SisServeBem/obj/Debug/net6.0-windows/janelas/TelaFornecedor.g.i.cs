﻿#pragma checksum "..\..\..\..\janelas\TelaFornecedor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864FB7375B3C9A999A7CFC3531A2B65DFB85BEB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using SisServeBem;
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


namespace SisServeBem {
    
    
    /// <summary>
    /// TelaFornecedor
    /// </summary>
    public partial class TelaFornecedor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomeFantasia;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCnpj;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEndereco;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContato;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRazaoSocial;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSalvar;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btExcluir;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\janelas\TelaFornecedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_consultar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SisServeBem;component/janelas/telafornecedor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\janelas\TelaFornecedor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtNomeFantasia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtCnpj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtEndereco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtContato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtRazaoSocial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btSalvar = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\janelas\TelaFornecedor.xaml"
            this.btSalvar.Click += new System.Windows.RoutedEventHandler(this.btSalvar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btExcluir = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\janelas\TelaFornecedor.xaml"
            this.btExcluir.Click += new System.Windows.RoutedEventHandler(this.btExcluir_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bt_consultar = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\janelas\TelaFornecedor.xaml"
            this.bt_consultar.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

