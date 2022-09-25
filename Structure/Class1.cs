using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Student 
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public Student(string fName, string lName, int grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }
        public void ShowStudent()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Grade}");
        }
    }
}
