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
        static List<Error> errorEng = new List<Error>();
        bool hasError => errorEng.Any();
        public static List<Error> FileProcess(List<IDelimitedFile> filestoParser)
        {
            //adding the try and catch 
            try
            {
                WriteLine("process working...");
                for (int i = 0; i < filestoParser.Count; i++)
                {
                    Dictionary<int, string[]> opera = new Dictionary<int, string[]>();
                    //suppose to replace the current extension with the _outand adding the .txt or csv.
                    string writingIT = filestoParser[i].path.Replace(filestoParser[i].Extension, $"_out{Constants.FileExtensions.output}");


                    if (File.Exists(writingIT))
                    {
                        File.Delete(writingIT);
                    }
                    //reads the files 
                    using (StreamReader Reading = new StreamReader(filestoParser[i].path))
                    {
                        int index = 1;
                        while (!Reading.EndOfStream)
                        {
                            var openItems = Reading.ReadLine()?.Split(filestoParser[i].Delimiter) ?? new string[0];
                            opera.Add((index++), openItems);
                        }

                        //writes on them
                        using (StreamWriter Writing = new StreamWriter(writingIT, true))
                        {
                            foreach (var item in opera)
                            {
                                Writing.Write($"Line#{item.Key}: ");
                                for (int y = 0; y < item.Value.Length; y++)
                                {
                                    Writing.Write($"Field# {y + 1}={item.Value[y]}");
                                    if (!(y + 1 == item.Value.Length))
                                    {

                                        Writing.Write(" ==> ");
                                    }
                                    Writing.WriteLine();
                                }
                            }
                        }

                    }
                }
            }
            catch(Exception e)
            {
                errorEng.Add(new Error(e.Message, e.Source));
            }
            return errorEng;
        }
    }
}
