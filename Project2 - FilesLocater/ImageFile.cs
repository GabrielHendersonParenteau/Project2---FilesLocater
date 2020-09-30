using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2___FilesLocater
{
    class ImageFile : File
    {
        public ImageFile()
        {
            ImageWidth = 0;
            ImageHeight = 0;
            HResolution = "";
            VResolution = "";
        }

        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public string HResolution { get; set; }
        public string VResolution { get; set; }
    }
}
