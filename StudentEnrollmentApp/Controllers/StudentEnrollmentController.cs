using BLL;
using Microsoft.AspNetCore.Mvc;

namespace StudentEnrollmentApp.Controllers
{
    public class StudentEnrollmentController : Controller
    {
        StudentEnrollmentService studentEnrollmentService = new StudentEnrollmentService();

        public IActionResult Index()
        {

            var response = studentEnrollmentService.GetStudentCourseForEnrollment();
            return View(response);
        }

        [HttpPost]
        public IActionResult UpdateStudentEnrollments([FromBody] Dictionary<int, List<int>> studentEnrollments)
        {
            var response = studentEnrollmentService.UpdateEnrollment(studentEnrollments);
            return View(response);
        }

    }
}
