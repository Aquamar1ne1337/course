﻿#pragma checksum "..\..\GamePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2A06E594A918925529B1DFBA30B05C672D0561B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseDataB;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SourceChord.FluentWPF;
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


namespace CourseDataB {
    
    
    /// <summary>
    /// GamePage
    /// </summary>
    public partial class GamePage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageDoge;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock GameNameTB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateTB;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlatformTB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PriceTB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuyBT;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WishlistBT;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionTB;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseDataB;component/gamepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GamePage.xaml"
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
            this.ImageDoge = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.GameNameTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DateTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PlatformTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PriceTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BuyBT = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\GamePage.xaml"
            this.BuyBT.Click += new System.Windows.RoutedEventHandler(this.BuyBT_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.WishlistBT = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\GamePage.xaml"
            this.WishlistBT.Click += new System.Windows.RoutedEventHandler(this.WishlistBT_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DescriptionTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

