using BLL;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace StudentEnrollmentApp.Controllers
{
    public class StudentController : Controller
    {

        StudentService studentService = new StudentService();
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// post method to register new student
        /// </summary>
        /// <param name="studentFormData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RegisterStudent([FromBody] Student studentFormData)
        {
            var response = studentService.AddStudentService(studentFormData);
            return Json(response);
        }
    }
}
