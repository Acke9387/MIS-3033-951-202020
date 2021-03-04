using System;
using System.Collections.Generic;
using System.Text;

namespace Classes3
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address();
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}";
        }

    }
}
