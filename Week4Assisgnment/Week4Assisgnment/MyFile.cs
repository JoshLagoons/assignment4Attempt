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
        public string Delimiter { get; set; }
        public string Extension { get; set; }
        public bool isError { get; set; }

        public MyFile(string path, string delimiter, string extension)
        {
            if(extension.EndsWith(Constants.FileExtensions.CSV))
            {
                Delimiter = Constants.FileDelimiters.CSV;
                Extension = Constants.FileExtensions.CSV;
                isError = false;
            }
            else
            {
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
                isError = true;
            }
            path = Path.Combine(Constants.dirPath, extension);
        }

        public MyFile(string naming)
        {
        }

        //was considering making it a switch case but didnt know how to implement both the files to come out.
        /*  public static void csvOption()
          {

          }
          public static void txtOption()
          {

          }
          public static void None()
          {

          }*/
    }
}
