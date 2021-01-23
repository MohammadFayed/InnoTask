using InnoTechApp.Core;
using InnoTechApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InnoTechApp.Pages.Courses
{
    public class DeleteModel : PageModel
    {
        private readonly ICourseRepo _courseRepo;
        public Course Course { get; set; }
        [TempData]
        public string Message { get; set; }

        public DeleteModel(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }
        public IActionResult OnGet(int courseId)
        {
            Course = _courseRepo.GetCourseById(courseId);
            if (Course == null)
                return RedirectToPage("./NotFound");

            _courseRepo.DeleteCourse(courseId);
            _courseRepo.Commit();

            Message = "Course deleted successfully";
            return RedirectToPage("./AllCourses");
        }
    }
}