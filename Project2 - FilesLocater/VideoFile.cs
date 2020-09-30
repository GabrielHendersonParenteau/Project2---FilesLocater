using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2___FilesLocater
{
    class VideoFile : MediaFile
    {
        public VideoFile()
        {
            Director = "";
            Producer = "";
        }

        public string Director { get; set; }
        public string Producer { get; set; }
    }
}
