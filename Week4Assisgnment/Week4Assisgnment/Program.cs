using System;
using static System.Console;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace Week4Assisgnment
{
    //my references:
    //https://dev.to/bristolsamo/c-csv-parser-step-by-step-tutorial-25ok
    //https://learn.microsoft.com/en-us/dotnet/api/system.io.directory?view=net-6.0
    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0
    //https://www.youtube.com/watch?v=9mUuJIKq40M
    //https://www.dotnetperls.com/sort-dictionary
    //Was tutored a bit from Duncan Mcdonald.

    class Program
    {
        static void Main(string[] args)
        {

            Output();
            
        }
        public static void Output()
        {
            List<string> outputting = new List<string>() { Constants.csvFile, Constants.txtFile };
            Parser parsing = new Parser(outputting);
            WriteLine("your outputting is done!");
            ReadKey();
        }
    }
}
