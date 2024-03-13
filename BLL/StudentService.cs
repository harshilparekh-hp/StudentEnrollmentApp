using DAL;
using Entities.Entities;

namespace BLL
{
    public class StudentService
    {
        StudentRepository studentRepository = new StudentRepository();
        public string AddStudentService(Student studentFormData)
        {
            return studentRepository.AddStudent(studentFormData);
        }


    }
}
