using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Week4Assisgnment
{
    class IDelimitedFile
    {   //these are going to be transferred to the myfile class

        public string Extension { get; set; }
        public string path { get; set; }

        public string Delimiter { get; set; }

        public bool isError { get; set; }

    }
}
