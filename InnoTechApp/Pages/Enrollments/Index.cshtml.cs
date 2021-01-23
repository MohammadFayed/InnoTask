using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnoTechApp.Core;
using InnoTechApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InnoTechApp.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly IEnrollmentRepo _enrollmentRepo;
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public IndexModel(IEnrollmentRepo enrollmentRepo)
        {
            _enrollmentRepo = enrollmentRepo;
        }
        public void OnGet()
        {
            Enrollments = _enrollmentRepo.Enrollments();
        }
    }
}
