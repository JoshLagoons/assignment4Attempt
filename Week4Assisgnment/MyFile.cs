using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using static System.Console;

namespace Week4Assisgnment
{
    class MyFile : IDelimitedFile
    {
        public string path { get; set; }
        public string Delimiter { get; set; }
        public string Extension { get; set; }
        public bool isError { get; set; }

        public MyFile(string extension, out bool isError)
        {
            if(extension.EndsWith(Constants.FileExtensions.CSV))
            {
                Delimiter = Constants.FileDelimiters.CSV;
                Extension = Constants.FileExtensions.CSV;
                isError = false;
            }
            else
            {
                Delimiter = "Bad";
                Extension = "Bad";
                isError = true;
            }
            if(extension.EndsWith(Constants.FileExtensions.txtPipe))
            {
                Delimiter = Constants.FileDelimiters.txtPipe;
                Extension = Constants.FileExtensions.txtPipe;
                isError = false;
            }
            else
            {
                Delimiter = "Bad";
                Extension = "Bad";
                isError = true;
            }
            if (extension.EndsWith(Constants.FileExtensions.JSON))
            {
                Delimiter = Constants.FileDelimiters.JSON;
                Extension = Constants.FileExtensions.JSON;
                isError = false;
            }
            else
            {
                Delimiter = "Bad";
                Extension = "Bad";
                isError = true;
            }
            if (extension.EndsWith(Constants.FileExtensions.XML))
            {
                Delimiter = Constants.FileDelimiters.XML;
                Extension = Constants.FileExtensions.XML;
                isError = false;
            }
            else
            {
                Delimiter = "Bad";
                Extension = "Bad";
                isError = true;
            }
            path = Path.Combine(Constants.dirPath, extension);
        }

     
    }
}
