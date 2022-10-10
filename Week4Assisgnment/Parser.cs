using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using static System.Console;

namespace Week4Assisgnment
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
    //what rafael taught to use to fix my first foreach.
    class Parser
    {
        List<IDelimitedFile> fileStoParser = new List<IDelimitedFile>();
        List<Error> errorParse = new List<Error>();

        bool hasError2 => errorParse.Any();
        public Parser()
        {
            List<string> outputting = AllFiles();

            foreach(var naming in outputting)
            {
                fileStoParser.Add(new MyFile(naming, out bool isError));
                if(isError)
                {
                    errorParse.Add(new Error($"Bad file extension, {naming.Substring(naming.LastIndexOf("."))} isn't supported", $"{naming}"));
                }
            }
            ErrorCheck();
            //this is getting the delimites from the folder and making it process.
            List<IDelimitedFile> csvProcess = fileStoParser.Where(x => x.Extension == Constants.FileDelimiters.CSV).ToList();
            List<IDelimitedFile> txtProcess = fileStoParser.Where(x => x.Extension == Constants.FileDelimiters.txtPipe).ToList();

            List<IDelimitedFile> jsonProcess = fileStoParser.Where(x => x.Extension == Constants.FileDelimiters.JSON).ToList();
            List<IDelimitedFile> xmlProcess = fileStoParser.Where(x => x.Extension == Constants.FileDelimiters.XML).ToList();

            errorParse.AddRange(Engine.FileProcess(csvProcess));
            errorParse.AddRange(Engine.FileProcess(txtProcess));
            errorParse.AddRange(Engine.FileProcess(jsonProcess));
            errorParse.AddRange(Engine.FileProcess(xmlProcess));
            ErrorCheck2();

            
        }
        public void ErrorCheck()
        {
            if (hasError2)
            {
                WriteLine("The parsing ended with errors");
                foreach (var errDetail in errorParse)
                {
                    WriteLine($"Heres the error: {errDetail.Message} ----{errDetail.Info}");
                }
            }
        }
        public void ErrorCheck2()
        {
            if (hasError2)
            {
                foreach (var errDetail2 in errorParse)
                {
                    WriteLine($"Here's the error: {errDetail2.Message} ----{errDetail2.Info}");
                }
            }
            else
            {
                WriteLine("parsing completed!");
            }
        }

        List<string> AllFiles()
        {
            
           return Directory.GetFiles(Constants.dirPath).Where(x => !x.EndsWith("_out.txt")).ToList();
        }

    }
}
