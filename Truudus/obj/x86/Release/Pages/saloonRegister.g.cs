﻿#pragma checksum "C:\Users\Desmond\Documents\Visual Studio 2017\Projects\Universal\Truudus\Truudus\Pages\saloonRegister.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9055D41C7D61FB96124B3142C7203D36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Truudus.Pages
{
    partial class saloonRegister : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.nameingblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.emaila = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.aboutBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.sname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.shortDescbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.submit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\Pages\saloonRegister.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.submit).Click += this.submit_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.goBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 63 "..\..\..\Pages\saloonRegister.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goBack).Click += this.goBack_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.welcomeRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 10:
                {
                    this.otpBLOCK = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.otpdata = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.otpbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 94 "..\..\..\Pages\saloonRegister.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.otpbutton).Click += this.otpbutton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

