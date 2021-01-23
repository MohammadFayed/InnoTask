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
    public class DetailsModel : PageModel
    {
        private readonly ICourseRepo _courseRepo;
        public Course Course { get; set; }

        public DetailsModel(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        public IActionResult OnGet(int courseId)
        {
            Course = _courseRepo.GetCourseById(courseId);
            if (Course == null)
                return RedirectToPage("./NotFound");
            return Page();
        }
    }
}
