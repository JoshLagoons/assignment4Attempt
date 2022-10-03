using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using static System.Console;

namespace Week4Assisgnment
{
    class Engine
    {
        List<Error> errorEng = new List<Error>();
        bool hasError => errorEng.Any();

        public void fileProcess(List<Error> errorChecking, List<IDelimitedFile> processor)
        {
            errorEng = errorChecking;
            WriteLine("process working...");
            for (int i = 0; i < processor.Count; i++)
            {
                Dictionary<int, string[]> opera = new Dictionary<int, string[]>();
                //suppose to replace the current extension with the _outand adding the .txt or csv.
                string writingIT = processor[i].path.Replace(processor[i].Extension, "_out" + Constants.FileExtensions.txtPipe);
                int Index = 1;

                if(File.Exists(writingIT))
                {
                    File.Delete(writingIT);
                }
                //reads the files 
                using(StreamReader Reading = new StreamReader(processor[i].path))
                {
                    string opening;
                    while ((opening = Reading.ReadLine()) == null)
                    {
                        var openItems = opening.Split(processor[i].Delimiter);
                        opera.Add((Index++), openItems);
                    }
                }
                if(hasError)
                {
                    foreach(var error3 in errorEng)
                    {
                        WriteLine("Error is" + error3.Message + "and" + error3.Info);
                    }
                    return;
                }

                //writes on them
                using(StreamWriter Writing = new StreamWriter(writingIT, true))
                {
                    foreach(var item in opera)
                    {
                        Writing.Write("Line#" + item.Key);
                        for(int y = 0; y < item.Value.Length; y++)
                        {
                            Writing.Write("Field#" + (y + 1) + "=" + item.Value[y]);
                            if((y + 1 == item.Value.Length))
                            {
                                return;
                            }
                            else
                            {
                                Writing.Write(" ==> ");

                            }
                            Writing.WriteLine();
                        }
                    }
                }

            }


        }
     
        internal static void fileProcess(List<Error> errorParse)
        {
            throw new NotImplementedException();
        }
    }
}
