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
    public class EditModel : PageModel
    {
        private readonly ICourseRepo _courseRepo;
        [BindProperty(SupportsGet = true)]
        public Course Course { get; set; }

        public EditModel(ICourseRepo course)
        {
            _courseRepo = course;
        }
        public IActionResult OnGet(int? courseId)
        {
            if (courseId.HasValue)
            {
                Course = _courseRepo.GetCourseById(courseId.Value);
                if (Course == null)
                {
                    return RedirectToPage("./NotFound");
                }
            }
            else
            {
                Course = new Course();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Course.CourseId > 0)
            {
                _courseRepo.Update(Course);
                _courseRepo.Commit();
                TempData["message"] = "Course updated successfully";
            }
            else
            {
                _courseRepo.AddCourse(Course);
                _courseRepo.Commit();
                TempData["message"] = "Course Added successfully";
            }
            
            return RedirectToPage("./AllCourses");
        }
    }
}
