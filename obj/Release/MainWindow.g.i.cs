﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "30927C9ACA470B17DE2C5555F7B05770"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MirzaMediaPlayer;
using MirzaMediaPlayer.Commands;
using MirzaMediaPlayer.Models;
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


namespace MirzaMediaPlayer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 46 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdLoad;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdPlayPause;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdPrevious;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdNext;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdStop;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdMute;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdRemoveItems;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding cmdClearAll;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElementMain;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageAudio;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxPlaylist;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderVolume;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderBalance;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderSpeed;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockProgress;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderDuration;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockDuration;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonLoad;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPlayPause;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagePlayPause;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPrevious;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNext;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStop;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton buttonMute;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockMediaStatus;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipseStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/MirzaMediaPlayer;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 13 "..\..\MainWindow.xaml"
            ((MirzaMediaPlayer.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmdLoad = ((System.Windows.Input.CommandBinding)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.cmdLoad.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdLoad_CanExecute);
            
            #line default
            #line hidden
            
            #line 46 "..\..\MainWindow.xaml"
            this.cmdLoad.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdLoad_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmdPlayPause = ((System.Windows.Input.CommandBinding)(target));
            
            #line 47 "..\..\MainWindow.xaml"
            this.cmdPlayPause.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdPlayPause_CanExecute);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.cmdPlayPause.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdPlayPause_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmdPrevious = ((System.Windows.Input.CommandBinding)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.cmdPrevious.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdPrevious_CanExecute);
            
            #line default
            #line hidden
            
            #line 48 "..\..\MainWindow.xaml"
            this.cmdPrevious.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdPrevious_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmdNext = ((System.Windows.Input.CommandBinding)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.cmdNext.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdNext_CanExecute);
            
            #line default
            #line hidden
            
            #line 49 "..\..\MainWindow.xaml"
            this.cmdNext.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdNext_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmdStop = ((System.Windows.Input.CommandBinding)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.cmdStop.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdStop_CanExecute);
            
            #line default
            #line hidden
            
            #line 50 "..\..\MainWindow.xaml"
            this.cmdStop.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdStop_Executed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmdMute = ((System.Windows.Input.CommandBinding)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.cmdMute.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdMute_CanExecute);
            
            #line default
            #line hidden
            
            #line 51 "..\..\MainWindow.xaml"
            this.cmdMute.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdMute_Executed);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmdRemoveItems = ((System.Windows.Input.CommandBinding)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.cmdRemoveItems.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdRemoveItems_CanExecute);
            
            #line default
            #line hidden
            
            #line 52 "..\..\MainWindow.xaml"
            this.cmdRemoveItems.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdRemoveItems_Executed);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmdClearAll = ((System.Windows.Input.CommandBinding)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.cmdClearAll.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.cmdClearAll_CanExecute);
            
            #line default
            #line hidden
            
            #line 53 "..\..\MainWindow.xaml"
            this.cmdClearAll.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.cmdClearAll_Executed);
            
            #line default
            #line hidden
            return;
            case 10:
            this.mediaElementMain = ((System.Windows.Controls.MediaElement)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.mediaElementMain.MediaEnded += new System.Windows.RoutedEventHandler(this.mediaElementMain_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 11:
            this.imageAudio = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            this.listBoxPlaylist = ((System.Windows.Controls.ListBox)(target));
            return;
            case 14:
            this.sliderVolume = ((System.Windows.Controls.Slider)(target));
            
            #line 131 "..\..\MainWindow.xaml"
            this.sliderVolume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderVolume_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.sliderBalance = ((System.Windows.Controls.Slider)(target));
            
            #line 133 "..\..\MainWindow.xaml"
            this.sliderBalance.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderBalance_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.sliderSpeed = ((System.Windows.Controls.Slider)(target));
            
            #line 135 "..\..\MainWindow.xaml"
            this.sliderSpeed.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderSpeed_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.textBlockProgress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 18:
            this.sliderDuration = ((System.Windows.Controls.Slider)(target));
            
            #line 145 "..\..\MainWindow.xaml"
            this.sliderDuration.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderDuration_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            this.textBlockDuration = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.buttonLoad = ((System.Windows.Controls.Button)(target));
            return;
            case 21:
            this.buttonPlayPause = ((System.Windows.Controls.Button)(target));
            return;
            case 22:
            this.imagePlayPause = ((System.Windows.Controls.Image)(target));
            return;
            case 23:
            this.buttonPrevious = ((System.Windows.Controls.Button)(target));
            return;
            case 24:
            this.buttonNext = ((System.Windows.Controls.Button)(target));
            return;
            case 25:
            this.buttonStop = ((System.Windows.Controls.Button)(target));
            return;
            case 26:
            this.buttonMute = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 27:
            this.textBlockMediaStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 28:
            this.ellipseStatus = ((System.Windows.Shapes.Ellipse)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 83 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
