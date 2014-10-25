﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "98F37308822FB6A73088EECB90A50E92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Kinect.Toolkit;
using Microsoft.Samples.Kinect.KinectFusionExplorer;
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


namespace Microsoft.Samples.Kinect.KinectFusionExplorer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 224 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.KinectSensorChooserUI sensorChooserUI;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CompositeHost;
        
        #line default
        #line hidden
        
        
        #line 246 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image shadedSurfaceImage;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewport3D GraphicsViewport;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image depthFloatImage;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image deltaFromReferenceImage;
        
        #line default
        #line hidden
        
        
        #line 285 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton stlFormat;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton objFormat;
        
        #line default
        #line hidden
        
        
        #line 287 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton plyFormat;
        
        #line default
        #line hidden
        
        
        #line 319 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox nearModeCheckBox;
        
        #line default
        #line hidden
        
        
        #line 408 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VoxelsXSlider;
        
        #line default
        #line hidden
        
        
        #line 419 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VoxelsYSlider;
        
        #line default
        #line hidden
        
        
        #line 430 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VoxelsZSlider;
        
        #line default
        #line hidden
        
        
        #line 440 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fpsText;
        
        #line default
        #line hidden
        
        
        #line 443 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusBarText;
        
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
            System.Uri resourceLocater = new System.Uri("/KinectFusionExplorer-WPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 6 "..\..\MainWindow.xaml"
            ((Microsoft.Samples.Kinect.KinectFusionExplorer.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.WindowLoaded);
            
            #line default
            #line hidden
            
            #line 6 "..\..\MainWindow.xaml"
            ((Microsoft.Samples.Kinect.KinectFusionExplorer.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.WindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sensorChooserUI = ((Microsoft.Kinect.Toolkit.KinectSensorChooserUI)(target));
            return;
            case 3:
            this.CompositeHost = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.shadedSurfaceImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.GraphicsViewport = ((System.Windows.Controls.Viewport3D)(target));
            return;
            case 6:
            this.depthFloatImage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.deltaFromReferenceImage = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            
            #line 282 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateMeshButtonClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.stlFormat = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.objFormat = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.plyFormat = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            
            #line 290 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetReconstructionButtonClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 294 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetCameraButtonClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.nearModeCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 15:
            
            #line 391 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Slider)(target)).ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSettingsChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.VoxelsXSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 408 "..\..\MainWindow.xaml"
            this.VoxelsXSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSettingsChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.VoxelsYSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 419 "..\..\MainWindow.xaml"
            this.VoxelsYSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSettingsChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.VoxelsZSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 430 "..\..\MainWindow.xaml"
            this.VoxelsZSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSettingsChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            this.fpsText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.statusBarText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

