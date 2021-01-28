using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExample
{
    public class Student
    {
        private string MadeUpThingForExample;
        public Int64 ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FavoriteColor { get; set; }

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Student()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="color"></param>
        public Student(Int64 id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }

        public Student(Int64 id) : this()
        {
            ID = id;
            //FirstName = string.Empty;
            //LastName = string.Empty;
            //FavoriteColor = string.Empty;
        }

        public string CreateFullName()
        {
            // return LastName + ", " + FirstName
            return $"{LastName}, {FirstName}";
        }

    }
}
