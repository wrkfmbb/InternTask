using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;
using System.ComponentModel;

namespace InternTask.Models
{
    class SpatialSupport
    {
        private bool _isSpatialSupported;
        private string _subtype;

        public SpatialAudioDeviceConfiguration spatialAudioDeviceConfiguration { get; set; }

        public bool IsSpatialSupported
        {
            get
            { return _isSpatialSupported; }
            set { _isSpatialSupported = value; RaisePropertyChanged("IsSpatialSupported"); }
        }

        public string Subtype { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
