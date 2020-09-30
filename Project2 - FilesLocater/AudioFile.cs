using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2___FilesLocater
{
    class AudioFile : MediaFile
    {
        public AudioFile()
        {
            Artist = "";
            BitRate = "";
        }

        public string Artist { get; set; }
        public string BitRate { get; set; }
    }
}
