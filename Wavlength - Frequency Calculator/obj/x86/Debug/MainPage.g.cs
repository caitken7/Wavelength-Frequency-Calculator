﻿#pragma checksum "C:\Users\caseyaitken\Documents\Visual Studio 2015\Projects\Wavlength - Frequency Calculator\Wavlength - Frequency Calculator\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E40C22589622574714AFC4C540FB3A31"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Frequency___Wavelength_Calculator
{
    partial class MainPage : 
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
                    this.Background = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.inputFrequency = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.inputWavelength = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.inputTemperature = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.outputWavelength = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.outputFrequency = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.outputSpeed = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.calcWavelength = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.calcWavelength).Click += this.calcWavelength_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.calcFrequency = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.calcFrequency).Click += this.calcFrequency_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.calcSpeed = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.calcSpeed).Click += this.calcSpeed_Click;
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

