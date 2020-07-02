using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternTask.Models
{

    //enum SpatialCodec
    //{
    //    DolbyAtmosForHeadphones,
    //    WindowsSonicForHeadphones,
    //    Off,
    //    NotSupported
    //}

    class AudioDevice
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string ActiveCodec { get; set; }
        //public SpatialCodec SpatialCodec { get; set; }
        public bool IsSpatialSupported { get; private set; }
        public bool IsDefault { get; private set; }

    }
}
