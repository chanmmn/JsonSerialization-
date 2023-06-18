using System;
using System.Collections.Generic;

namespace ConAppNewtonsoftJson
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndParseJsonFileWithNewtonsoftJson readAndParseJsonFile = new ReadAndParseJsonFileWithNewtonsoftJson("Teacher.json");
            Console.WriteLine("Hello Start!");

            List<Teacher> teachers = new List<Teacher>();
            teachers = readAndParseJsonFile.UseUserDefinedObjectWithNewtonsoftJson();
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine(teacher.Courses[0].Name);
            }
            teachers.Clear();
            Console.WriteLine();
            teachers = new List<Teacher>();
            teachers = readAndParseJsonFile.UseJsonTextReaderInNewtonsoftJson();
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine(teacher.Courses[0].Name);
            }
            teachers.Clear();
            Console.WriteLine();
            teachers = new List<Teacher>();
            teachers = readAndParseJsonFile.UseJArrayParseInNewtonsoftJson();
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine(teacher.Courses[0].Name);
            }
            Console.WriteLine("Hello End!");
        }
    }
}
