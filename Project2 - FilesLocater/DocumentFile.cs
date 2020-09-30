using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2___FilesLocater
{
    class DocumentFile : File
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DocumentFile()
        {
            NumberOfPages = 0;
            NumberOfWords = 0;
            DocumentSubject = "";
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int NumberOfPages { get; set; }
        public int NumberOfWords { get; set; }
        public string DocumentSubject { get; set; }
    }
}
