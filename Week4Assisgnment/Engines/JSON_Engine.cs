using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Linq;
using static System.Console;
using Newtonsoft.Json;
using Week4Assisgnment.JSON;

namespace Week4Assisgnment.Engines
{
    class JSON_Engine : Engine
    {
        static List<Error> errorJEng = new List<Error>();
        bool hasError => errorJEng.Any();
        
        public static List<Error> JsonProcess(List<IDelimitedFile> filestoParser)
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
                    using (StreamReader sr = new StreamReader(chop.path))
                    {
                        Student myStudent = JsonConvert.DeserializeObject<Student>(sr.ReadToEnd());
                        using (StreamWriter sw = new StreamWriter(writing, true))
                        {
                            sw.WriteLine($"Name: {myStudent.FirstName} {myStudent.LastName}");
                            sw.WriteLine(myStudent.IsEnrolled, "student is enrolled");
                            sw.WriteLine($"Enrolled for {myStudent.YearsEnrolled} yrs");
                            sw.WriteLine($"First Adress: {myStudent.Address1}");
                            sw.WriteLine(myStudent.Address2 == null);
                            sw.WriteLine($"Phone Number 1: {myStudent.PhoneNumbers[0]}");
                            sw.WriteLine($"Phone Number 1: {myStudent.PhoneNumbers[1]}");
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                errorJEng.Add(new Error(e.Message, e.Source));
            }




            return errorJEng;
            
             
        }

    }
}
