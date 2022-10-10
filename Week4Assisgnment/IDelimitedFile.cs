using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Assisgnment
{
    interface IDelimitedFile
    {
        //didn't realize that this wasn't a interface class beforehand.
        public string Extension { get; set; }
        public string path { get; set; }

        public string Delimiter { get; set; }

        public bool isError { get; set; }
    }
}
