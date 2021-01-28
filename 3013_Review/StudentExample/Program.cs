using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// @Author Instructor Ackerman's Project
/// </summary>

namespace StudentExample
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("studentDataRandom100Rows.csv");
            //Student s = new Student(5, "Joe", "Joe", "Blue");
            //Student s2 = new Student();
            //s2.FirstName = "Joe";
            //s2.LastName = "Joe";

            //foreach (var line in lines)
            //{

            //    Console.WriteLine(line);
            //}

            for (int i = 1; i < lines.Length; i++)
            {
                //   0          1   2    3
                //8203029752,Conni,Odo,Purple
                string line = lines[i];
                var pieces = line.Split(',');
                Int64 id = Convert.ToInt64(pieces[0]);

                Student currentStudent = new Student(Convert.ToInt64(pieces[0]), pieces[1], pieces[2], pieces[3]);

                students.Add(currentStudent);
            }

            PrintStudentsWithFavoriteColor("Blue");


            PrintStudentsWithFavoriteColor("Puce");

            //C:\Users\acke9387\Downloads\studentDataRandom100Rows.csv
        }

        private static void PrintStudentsWithFavoriteColor(string color)
        {
            Console.WriteLine(color);

            foreach (var student in students)
            {
                if (student.FavoriteColor.ToLower() == color.ToLower())
                {
                    Console.WriteLine(student.CreateFullName());
                }
            }
            Console.WriteLine();
        }
    }
}
