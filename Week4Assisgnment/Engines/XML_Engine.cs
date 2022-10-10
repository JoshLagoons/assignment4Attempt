using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using static System.Console;
using System.Xml.Serialization;
using Week4Assisgnment.XML;

namespace Week4Assisgnment.Engines
{
    class XML_Engine : Engine
    {
        List<Error> errXEng = new List<Error>();

        bool hasErrors => errXEng.Any();
        public List<Error> XMLProcess(List<IDelimitedFile> filestoParser)
        {
            
            try
            {
                foreach(var chop in filestoParser)
                {
                    string writing = chop.path.Replace(chop.Extension, $"_out{Constants.FileExtensions.output}");
                    if(File.Exists(writing))
                    {
                        File.Delete(writing);

                    }
                    using (var higher = File.Open(chop.path, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Grocery));
                        var inventory = (Grocery)serializer?.Deserialize(higher);

                        using (StreamWriter sw = new StreamWriter(writing, true))
                        {
                            WriteLine();
                            var lineout = 1;

                            foreach (var item in inventory.item)
                            {
                                sw.WriteLine($"Line#{lineout++} : Item Info => {item.name}{item.price}/{item.unit}");
                            }
                        }

                    }

                }

            }
            catch(Exception b)
            {
                errXEng.Add(new Error(b.Message, b.Source));
            }
            return errXEng;
            
        }
    }
}
