﻿#pragma checksum "D:\Chrome\UniversityLife-22a72df65883b6eeae13c309aa9ccb04f13a956a\Hamburger1\Hamburger1\Views\LookCoursePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AEF83D2081272089419608CB6DDE30ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hamburger1.Views
{
    partial class LookCoursePage : 
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
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 162 "..\..\..\Views\LookCoursePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Click += this.DelCourseBtn_Clicked;
                    #line default
                }
                break;
            case 2:
                {
                    this.CourseInfoList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 114 "..\..\..\Views\LookCoursePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.EditCourseBtn_Clicked;
                    #line default
                }
                break;
            case 4:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

