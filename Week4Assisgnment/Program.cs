using System;
using static System.Console;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using Week4Assisgnment.Engines;

namespace Week4Assisgnment
{
    //my references:
    //https://dev.to/bristolsamo/c-csv-parser-step-by-step-tutorial-25ok
    //https://learn.microsoft.com/en-us/dotnet/api/system.io.directory?view=net-6.0
    //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0
    //https://www.youtube.com/watch?v=9mUuJIKq40M
    //https://www.dotnetperls.com/sort-dictionary
    //Was tutored a bit from Duncan Mcdonald.
    //Got tutored by Rafael Santana of fixing the parsing and learning how to implement my json.
    class Program
    {
        static void Main(string[] args)
        {
            /*
            JSON_Engine jsonengine = new JSON_Engine();
            jsonengine.JsonProcess();
            XML_Engine xmlengine = new XML_Engine();
            xmlengine.XMLProcess();
            */
            Output();
            
        }
        public static void Output()
        {
            Parser parsing = new Parser();
            WriteLine("your outputting is done!");
            ReadKey();
        }
    }
}
