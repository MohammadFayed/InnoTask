using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InnoTechApp.Core
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
