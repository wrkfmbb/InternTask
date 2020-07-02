using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Audio;

namespace InternTask.Models
{
    class AudioDevice
    {
        public DeviceInformation Device { get; set; }

        public bool IsDefault { get; set; }

        public SpatialAudioDeviceConfiguration SpatialAudioDeviceConfiguration { get; set; }
    }
}
