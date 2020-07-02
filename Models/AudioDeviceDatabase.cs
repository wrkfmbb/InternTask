using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Audio;
using Windows.Media.Devices;

namespace InternTask.Models
{
   

    class AudioDeviceDatabase
    {
        public IReadOnlyCollection<DeviceInformation> AudioDevices { get; set; }

        public DeviceInformation DefaultAudioDevice { get; set; }

        public SpatialAudioDeviceConfiguration SpatialAudioDeviceConfiguration { get; set; }
     
    }
}
