using System;
using System.Collections.Generic;

namespace InnoTechApp.Core
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
