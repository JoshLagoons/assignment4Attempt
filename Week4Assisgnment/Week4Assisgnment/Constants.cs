using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Week4Assisgnment
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
    // was consdering using a delegate.
    //but I tried and would've have to install chilkat for it to work.
    public static class Constants
    {
        public static string csvFile = "SampleCSV.csv";
        public static string txtFile = "SamplePipe.txt";
        public static string Folder = "FILEFOLDER";

        //combining two string into a path
        //used getdirectories but came out red so used current instead.
        public static string dirPath = Path.Combine(Directory.GetCurrentDirectory(), Folder);


        public sealed class FileExtensions
        {
            public static string CSV => ".csv";
            public static string txtPipe => ".txt";
        }
        public sealed class FileDelimiters
        {
            public static string CSV => ",";
            public static string txtPipe => "|";
        }
    }
   
}
