﻿

#pragma checksum "c:\users\jimmy\documents\visual studio 2012\Projects\WindowsBlogReader\WindowsBlogReader\SplitPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5863B4E6D98034A5D3B8DFA74C7CC92A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsBlogReader
{
    partial class SplitPage : global::WindowsBlogReader.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 34 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ViewDetail_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 79 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 103 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationFailed += this.ContentView_NavigationFailed;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 62 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


