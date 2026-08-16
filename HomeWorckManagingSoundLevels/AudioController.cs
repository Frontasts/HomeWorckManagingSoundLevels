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
    }
}
