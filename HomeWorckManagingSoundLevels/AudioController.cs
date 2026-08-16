using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckManagingSoundLevels
{
    public class AudioController
    {
        private Volume _currentVolume;

        public AudioController(Volume initialVolume)
        {
            _currentVolume = initialVolume;
        }

        public void SetVolume(Volume volume)
        {
            _currentVolume = volume;
        }

        public Volume GetVolume()
        {
            return _currentVolume;
        }

        public int GetVolumePercent()
        {
            if (_currentVolume == Volume.Mute)
            {
                return 0;
            }
            else if (_currentVolume == Volume.Low)
            {
                return 25;
            }
            else if (_currentVolume == Volume.Medium)
            {
                return 50;
            }
            else
            {
                return 100;
            }
        }

        public string GetStatus()
        {
            return $"Громкость: {_currentVolume} ({GetVolumePercent()}%)";
        }
    }
}
