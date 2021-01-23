using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InnoTechApp.Core;
using Microsoft.EntityFrameworkCore;

namespace InnoTechApp.Data
{
    public class SqlCourse : ICourseRepo
    {
        private readonly InnoTechAppDbContext _context;

        public SqlCourse(InnoTechAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> AllCourses()
        {
            return _context.Courses.ToList();
        }
        public IEnumerable<Course> GetCourseswithEnrollments()
        {
            return _context.Courses.Include(c => c.Enrollments).ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public IEnumerable<Course> GetByName(string searchForm)
        {
            return _context.Courses
                .Where(c => c.Name.StartsWith(searchForm) || string.IsNullOrEmpty(searchForm))
                .ToList();
        }

        public Course AddCourse(Course createCourse)
        {
            var course = _context.Add(createCourse);
            return createCourse;
        }
        public Course Update(Course course)
        {
            var entry = _context.Courses.Attach(course);
            entry.State = EntityState.Modified;
            return course;
        }

        public Course DeleteCourse(int id)
        {
            var course = GetCourseById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }

            return course;
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
