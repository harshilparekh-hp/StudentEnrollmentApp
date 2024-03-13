using Entities.Context;
using Entities.Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentEnrollmentRepository
    {
        StudentEnrollmentContext studentEnrollmentContext = new StudentEnrollmentContext();
        public List<StudentCourseVM> GetStudentCoursesForEnrollment()
        {
            List<Student> students = studentEnrollmentContext.Students.ToList();
            List<Course> courses = studentEnrollmentContext.Courses.ToList();
            List<Enrollment> enrollments = studentEnrollmentContext.Enrollments.ToList();


            var studentCourses = students.Select(x => new StudentCourseVM
            {
                StudentId = x.StudentId,
                FirstName = x.FirstName,
                Courses = courses.Select(x => x.CourseName).ToList(),
                CourseIds = courses.Select(x => x.CourseId).ToList(),
                Checked = courses.Select(course => enrollments.Any(enrollment => enrollment.CourseId == course.CourseId
                                                                    && enrollment.StudentId == x.StudentId)).ToList()

            }).ToList();


            return studentCourses;
        }

        public string UpdateEnrollments(Dictionary<int, List<int>> studentEnrollments)
        {
            studentEnrollmentContext.Enrollments.RemoveRange(studentEnrollmentContext.Enrollments.ToList());

            foreach(var studentEnrollment in studentEnrollments)
            {

                // removing all the existing enrollments from the Enrollment table so that,
                // we can insert newly selected enrollment ahead.

                int studentId = studentEnrollment.Key;
                // add newly selected enrollments

                foreach(var courseId in studentEnrollment.Value)
                {
                    var enrollment = new Enrollment
                    {
                        EnrolledDate = DateTime.Now,
                        CourseId = courseId,
                        StudentId = studentId
                    };
                    studentEnrollmentContext.Enrollments.Add(enrollment);
                }

            }
            studentEnrollmentContext.SaveChanges();

            return "success";
        }

    }
}
