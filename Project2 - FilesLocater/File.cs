using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2___FilesLocater
{
    class File
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public File()
        {
            FileNameAndExtension = "";
            FileSize = "";
            CreationDateTime = "";
            ModificationDateTime = "";
            CommentOnFile = "";
        }

        /// <summary>
        /// Properties
        /// </summary>
        public string FileNameAndExtension { get; set; }
        public string FileSize { get; set; }
        public string CreationDateTime { get; set; }
        public string ModificationDateTime { get; set; }
        public string CommentOnFile { get; set; }
    }
}
