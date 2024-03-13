using BLL;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace StudentEnrollmentApp.Controllers
{
    public class CourseController : Controller
    {
        CourseService courseService = new CourseService();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterCourse([FromBody] Course courseFormData)
        {
            var response = courseService.AddCourseService(courseFormData);
            return Json(response);
        }

    }
}
