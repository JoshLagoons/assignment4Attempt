using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using static System.Console;

namespace Week4Assisgnment
{
    class Parser
    {
        Engine parsingEngine = new Engine();
        List<IDelimitedFile> FileStyleUriParser = new List<IDelimitedFile>();
        List<Error> errorParse = new List<Error>();

        bool hasError2 {get; set;)
        public Parser(List<string> outputting)
        {
            foreach(var naming in outputting)
            {
                FileStyleUriParser.Add(new MyFile(naming));
            }

            ExtensionCheck();
            ErrorCheck();

            
        }

        public void ExtensionCheck()
        {
            foreach(var filing in FileStyleUriParser)
            {
                if(filing.isError)
                {
                    errorParse.Add(new Error("File " + filing.path + "doesn't have the right extension"));
                }
            }
        }
        public void ErrorCheck()
        {
            if(hasError2)
            {
                WriteLine("Process not working cause of errors");
                foreach(var shrub in errorParse)
                {
                    Write("Here's your Error:" + shrub.Message + " and " + shrub.Info);
                }
                return;
            }
            //moved your if(Haserror) from the main to the parser instead since it already was using the parser class.
        }

    }
}
