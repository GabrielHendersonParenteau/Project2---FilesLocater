using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project2___FilesLocater
{
    class MediaFile : File
    {
        public MediaFile()
        {
            Title = "";
            Length = "";
            Rating = "";
        }

        public string Title { get; set; }
        public string Length { get; set; }
        public string Rating { get; set; }
    }
}
