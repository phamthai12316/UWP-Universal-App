﻿#pragma checksum "C:\Users\admin\source\repos\UWP-Universal-App\UWP-Universal-App\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "357BDF89C54C4BE982CE4513250B478C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWP_Universal_App
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.btnStackPanel = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnStackPanel).Click += this.btnStackPanel_Click;
                }
                break;
            case 3: // MainPage.xaml line 19
                {
                    this.btnGrid = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnGrid).Click += this.btnGrid_Click;
                }
                break;
            case 4: // MainPage.xaml line 24
                {
                    this.btnScrollView = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnScrollView).Click += this.btnScrollView_Click;
                }
                break;
            case 5: // MainPage.xaml line 29
                {
                    this.btnRelativePage = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnRelativePage).Click += this.btnRelativePage_Click;
                }
                break;
            case 6: // MainPage.xaml line 34
                {
                    this.btnSplitViewPage = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSplitViewPage).Click += this.btnSplitViewPage_Click;
                }
                break;
            case 7: // MainPage.xaml line 50
                {
                    this.btnOpenContentDialog = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnOpenContentDialog).Click += this.btnOpenContentDialog_Click;
                }
                break;
            case 8: // MainPage.xaml line 51
                {
                    this.btnFlayout = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

