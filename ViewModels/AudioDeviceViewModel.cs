using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Devices;
using Windows.Media.Audio;
using InternTask.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace InternTask.ViewModels
{
    class AudioDeviceViewModel
    {

        public AudioDeviceViewModel()
        {
            GetDeviceInformation();
            GetDefaultAudioDevice();
            GetSpatialAudioConf();
        }

        public IReadOnlyCollection<DeviceInformation> AudioDevices { get; set; }

        public DeviceInformation DefaultAudioDevice { get; set; }

        public SpatialAudioDeviceConfiguration SpatialAudioDeviceConfiguration { get; set; }




        private async void GetDeviceInformation()
        {
            AudioDevices = await DeviceInformation.FindAllAsync(MediaDevice.GetAudioRenderSelector());
        }

        private async void GetDefaultAudioDevice()
        {
            string id = MediaDevice.GetDefaultAudioCaptureId(AudioDeviceRole.Default);

            if (id != null)
                DefaultAudioDevice = await DeviceInformation.CreateFromIdAsync(id);
        }

        public void GetSpatialAudioConf()
        {
            SpatialAudioDeviceConfiguration = SpatialAudioDeviceConfiguration.GetForDeviceId(DefaultAudioDevice.Id);
            SpatialAudioDeviceConfiguration.ConfigurationChanged += SpatialAudioDeviceConfiguration_ConfigurationChanged;
        }

        private void SpatialAudioDeviceConfiguration_ConfigurationChanged(SpatialAudioDeviceConfiguration sender, object args)
        {

        }
    }
}
