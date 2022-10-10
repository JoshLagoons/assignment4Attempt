using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Week4Assisgnment
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
    public static class Constants
    {
        public static string Folder = @"C:\Users\13129\Desktop\Week4Assisgnment\Week4Assisgnment\data";
        //combining two string into a path
        //used getdirectories but came out red so used current instead.
        public static string dirPath = Path.Combine(Directory.GetCurrentDirectory(), Folder);


        public sealed class FileExtensions
        {
            public static string CSV => ".csv";
            public static string txtPipe => ".txt";
            public static string output => ".txt";
            public static string JSON => ".json";
            public static string XML => ".xml";
        }
        public sealed class FileDelimiters
        {
            public static string CSV => ",";
            public static string txtPipe => "|";
            public static string output => " ";
            public static string JSON => "";
            public static string XML => "";

        }
    }
   
}
