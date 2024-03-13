using DAL;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentEnrollmentService
    {
        StudentEnrollmentRepository studentEnrollmentRepository = new StudentEnrollmentRepository();
        public List<StudentCourseVM> GetStudentCourseForEnrollment()
        {
            return studentEnrollmentRepository.GetStudentCoursesForEnrollment();
        }


        public string UpdateEnrollment(Dictionary<int, List<int>> studentEnrollment)
        {
            return studentEnrollmentRepository.UpdateEnrollments(studentEnrollment);
        }
    }


}
