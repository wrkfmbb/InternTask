using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Audio;
using Windows.Media.Devices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using InternTask.ViewModels;


namespace InternTask.Views
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioSettingsStateView : Page
    {
        private AudioDeviceViewModel ViewModel { get; set; } = new AudioDeviceViewModel();

        public AudioSettingsStateView()
        {
            DataContext = ViewModel; 
            this.InitializeComponent();

           // if (!IsActiveDolbyAtmosForHeadphones()) Setup.Visibility = Visibility.Collapsed;   
        }

        private bool IsActiveDolbyAtmosForHeadphones()
        {
            if (ViewModel.GetSpatialSubtype() == SpatialAudioFormatSubtype.DolbyAtmosForHeadphones)

                return true;

            return false;
        }

        private void Setup_Click(object sender, RoutedEventArgs e)
        {
            if (!IsActiveDolbyAtmosForHeadphones()) 
            {
                // System.Diagnostics.Process.Start("control", "mmsys.cpl");
            }
        }
    }
}
