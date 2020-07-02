using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Devices;

namespace InternTask.Models
{
    class AudioDeviceDatabase
    {
        public IReadOnlyCollection<DeviceInformation> audioDevices;

        public AudioDeviceDatabase()
        {
            GetDeviceInformation();
        }

        async void GetDeviceInformation()
        {
            audioDevices = await DeviceInformation.FindAllAsync(MediaDevice.GetAudioRenderSelector());

        }
    }
}
