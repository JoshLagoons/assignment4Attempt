using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Week4Assisgnment
{
    class Error
    {
       
        public Error(string msg, string info)
        {
            Message = msg;
            Info = info;
        }
        public string Message { get; set; }
        public string Info { get; set; }
    }
}
