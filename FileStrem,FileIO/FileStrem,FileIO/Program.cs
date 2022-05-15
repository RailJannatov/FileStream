using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileStrem_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Name = "Eli", Surname = "Eliyev", Degree = 51 };
            Student s2 = new Student { Name = "Akif", Surname = "Quliyev", Degree = 80 };
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            Group g1 = new Group { Name = "Ape4", Students = students };

            var json = JsonConvert.SerializeObject(g1);

            using(StreamWriter streamWriter = new StreamWriter(@"C:\Users\Rail\Desktop\AzTU_tasks\FileStrem,FileIO\FileStrem,FileIO\Files\json1.json"))
            {
                streamWriter.Write(json);
            }
            string result;
            using(StreamReader streamReader = new StreamReader(@"C:\Users\Rail\Desktop\AzTU_tasks\FileStrem,FileIO\FileStrem,FileIO\Files\json1.json"))
            {
                result = streamReader.ReadToEnd();
            }

            var json1 = JsonConvert.DeserializeObject(result);

            Console.WriteLine(json1);
     

        }
    }
}
