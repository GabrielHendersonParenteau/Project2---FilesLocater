using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2___FilesLocater
{
    class Directory
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Directory()
        {
            NumberOfFiles = 0;
            NumberOfFilesPerType = 0;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int NumberOfFiles { get; set; }
        public int NumberOfFilesPerType { get; set; }
    }
}
