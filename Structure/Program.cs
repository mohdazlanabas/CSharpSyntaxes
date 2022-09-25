using Structure;
using System;
using System.Data.SqlTypes;

namespace AlgoSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Ervis";
            s1.LastName = "Truja";
            s1.Grade = 67;

            Student s2 = new Student();
            s2.FirstName = "John";
            s2.LastName = "Doe";
            s2.Grade = 85;

            Console.WriteLine($"{s1.FirstName} {s1.LastName} - {s1.Grade}");
            Console.WriteLine($"{s2.FirstName} {s2.LastName} - {s2.Grade}");

            Student s3 = new Student("Jane", "Sminth", 93);
            s3.ShowStudent();
        }
    }
}