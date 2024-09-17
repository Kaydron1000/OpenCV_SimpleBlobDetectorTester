﻿#pragma checksum "..\..\SimpleBlobDectection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "034C919FEA2AD80F6C419DAA355FF7C8FF7D14F4584B5B81BF622F22FC54C60D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OpenCV_SimpleBlobDetectorTester;
using OpenCV_SimpleBlobDetectorTester.Controls;
using OpenCV_SimpleBlobDetectorTester.Converters;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace OpenCV_SimpleBlobDetectorTester {
    
    
    /// <summary>
    /// SimpleBlobDectection
    /// </summary>
    public partial class SimpleBlobDectection : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkBox_FilterByArea;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkBox_FilterByCircularity;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkBox_FilterByColor;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkBox_FilterByConvexity;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChkBox_FilterByInertia;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_MinDistBetweenBlobs;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_MinRepeatablitiy;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_BlobColor;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ColorPicker;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bttn_ColorPicker;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider Slider_Area;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_AreaMin;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_AreaMax;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider Slider_Circularity;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_CircularityMin;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_CircularityMax;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider Slider_Convexity;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ConvexityMin;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ConvexityMax;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider Slider_InertiaRatio;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_InertiaRatioMin;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_InertiaRatioMax;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider Slider_Threshold;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ThresholdMin;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\SimpleBlobDectection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ThresholdMax;
        
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
            System.Uri resourceLocater = new System.Uri("/OpenCV_SimpleBlobDetectorTester;component/simpleblobdectection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SimpleBlobDectection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ChkBox_FilterByArea = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.ChkBox_FilterByCircularity = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.ChkBox_FilterByColor = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.ChkBox_FilterByConvexity = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.ChkBox_FilterByInertia = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.TB_MinDistBetweenBlobs = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TB_MinRepeatablitiy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TB_BlobColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 68 "..\..\SimpleBlobDectection.xaml"
            this.ColorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.ColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Bttn_ColorPicker = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\SimpleBlobDectection.xaml"
            this.Bttn_ColorPicker.Click += new System.Windows.RoutedEventHandler(this.Bttn_ColorPicker_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Slider_Area = ((OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider)(target));
            return;
            case 12:
            this.TB_AreaMin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.TB_AreaMax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.Slider_Circularity = ((OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider)(target));
            return;
            case 15:
            this.TB_CircularityMin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.TB_CircularityMax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.Slider_Convexity = ((OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider)(target));
            return;
            case 18:
            this.TB_ConvexityMin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.TB_ConvexityMax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.Slider_InertiaRatio = ((OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider)(target));
            return;
            case 21:
            this.TB_InertiaRatioMin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 22:
            this.TB_InertiaRatioMax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 23:
            this.Slider_Threshold = ((OpenCV_SimpleBlobDetectorTester.Controls.RangeSlider)(target));
            return;
            case 24:
            this.TB_ThresholdMin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 25:
            this.TB_ThresholdMax = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

