using System;
using System.Collections.Generic;
using System.Text;
using InnoTechApp.Core;

namespace InnoTechApp.Data
{
    public interface ICourseRepo
    {

        IEnumerable<Course> AllCourses();
        IEnumerable<Course> GetCourseswithEnrollments();
        Course GetCourseById(int id);
        public IEnumerable<Course> GetByName(string searchForm);
        Course AddCourse(Course createCourse);
        Course Update(Course course);
        Course DeleteCourse(int id);
        public int Commit();
    }
}
