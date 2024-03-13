using Entities.Context;
using Entities.Entities;

namespace DAL
{
    public class StudentRepository
    {
        StudentEnrollmentContext studentEnrollmentContext = new StudentEnrollmentContext();
        public string AddStudent(Student studentFormData)
        {
            if(studentFormData != null)
            {
                studentEnrollmentContext.Students.Add(studentFormData);
                studentEnrollmentContext.SaveChanges();
                return "success";
            }
            return "error";
        }


    }
}
