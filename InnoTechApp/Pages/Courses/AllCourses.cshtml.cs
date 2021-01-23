using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnoTechApp.Core;
using InnoTechApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InnoTechApp.Pages.Courses
{
    public class AllCoursesModel : PageModel
    {
        public IEnumerable<Course> Courses;
        private readonly ICourseRepo _courseData;
        [BindProperty(SupportsGet = true)]
        public string SearchForm { get; set; }

        public AllCoursesModel(ICourseRepo courseData)
        {
            _courseData = courseData;
        }
        public void OnGet()
        {
            Courses = _courseData.GetCourseswithEnrollments();
        }
    }
}
