using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Example.Controllers
{
    public class StudentsController : ApiController
    {

        // GET api/Students

        [Route("api/Students")]
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Classification = "Super Senior", Name = "Instructor Ackerman" });
            students.Add(new Student() { Classification = "Senior", Name = "Talia Dean" });

            return students;
        }

        [Route("api/Students/Best")]
        [HttpGet]
        public Student Puppy()
        {
            return new Student() { Classification = "Senior", Name = "Talia Dean" };

        }


    }

    public class Student
    {
        public string Name { get; set; }

        public string Classification { get; set; }

    }
}
