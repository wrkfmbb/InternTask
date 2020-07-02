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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace InternTask.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AudioSettingsStateView : Page
    {
        private AudioDeviceViewModel ViewModel = new AudioDeviceViewModel();

        public AudioSettingsStateView()
        {
            this.InitializeComponent();

                         

        }

        private bool IsActiveDolbyAtmosForHeadphones()
        {
            if (ViewModel.SpatialAudioDeviceConfiguration.ActiveSpatialAudioFormat == SpatialAudioFormatSubtype.DolbyAtmosForHeadphones)

                return true;

            return false;
        }

        private void Setup_Click(object sender, RoutedEventArgs e)
        {
            if (IsActiveDolbyAtmosForHeadphones()) 
            {
                // System.Diagnostics.Process.Start("control", "mmsys.cpl");
            }
        }
    }
}
