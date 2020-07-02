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
        public AudioDeviceDatabase AudioDeviceDatabase = new AudioDeviceDatabase();

        public AudioDeviceViewModel()
        {
            InitializeAudioDeviceDatabase();
            //InitializeDeviceInformation();
            //InitializeDefaultAudioDevice();
            //InitializeSpatialAudioConf();
        }

        //private async void InitializeDeviceInformation()
        //{
        //    this.AudioDeviceDatabase.AudioDevices = await DeviceInformation.FindAllAsync(MediaDevice.GetAudioRenderSelector());
        //}

        //private async void InitializeDefaultAudioDevice()
        //{
        //    string id = MediaDevice.GetDefaultAudioRenderId(AudioDeviceRole.Default);

        //    if (id != null)
        //        this.AudioDeviceDatabase.DefaultAudioDevice = await DeviceInformation.CreateFromIdAsync(id);
        //}

        private void InitializeSpatialAudioConf()
        {
            if (AudioDeviceDatabase.DefaultAudioDevice != null)
            {
                AudioDeviceDatabase.SpatialAudioDeviceConfiguration = SpatialAudioDeviceConfiguration.GetForDeviceId(AudioDeviceDatabase.DefaultAudioDevice.Id);
                AudioDeviceDatabase.SpatialAudioDeviceConfiguration.ConfigurationChanged += SpatialAudioDeviceConfiguration_ConfigurationChanged;
            }
        }

        private void SpatialAudioDeviceConfiguration_ConfigurationChanged(SpatialAudioDeviceConfiguration sender, object args)
        {

        }

        private async Task<IReadOnlyCollection<DeviceInformation>> InitializeDeviceInformation()
        {
            var deviceInformation = await DeviceInformation.FindAllAsync(MediaDevice.GetAudioRenderSelector());
            AudioDeviceDatabase.AudioDevices = deviceInformation;
            return deviceInformation;

        }
        private async Task<DeviceInformation> InitializeDefaultAudioDevice()
        {
            string id = MediaDevice.GetDefaultAudioRenderId(AudioDeviceRole.Default);
            
            var defaultDevice = await DeviceInformation.CreateFromIdAsync(id);
            AudioDeviceDatabase.DefaultAudioDevice = defaultDevice;


            return defaultDevice; 

        }

        private async void InitializeAudioDeviceDatabase()
        {
            await InitializeDeviceInformation();
            await InitializeDefaultAudioDevice(); 
            InitializeSpatialAudioConf();

        }

        public string GetSpatialSubtype() => AudioDeviceDatabase.SpatialAudioDeviceConfiguration.ActiveSpatialAudioFormat;


    }
}
