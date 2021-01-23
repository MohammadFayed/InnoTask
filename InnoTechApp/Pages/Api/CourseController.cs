using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnoTechApp.Core;
using InnoTechApp.Data;

namespace InnoTechApp.Pages.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepo _courseRepo;

        public CourseController(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            try
            {
                return Ok(_courseRepo.AllCourses());
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "DataBase Failure");
            }
        }
    }
}
