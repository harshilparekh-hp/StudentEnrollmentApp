using Entities.Context;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseRepository
    {
        StudentEnrollmentContext studentEnrollmentContext = new StudentEnrollmentContext();

        public string AddCourse(Course courseFormData)
        {
            if (courseFormData != null)
            {
                studentEnrollmentContext.Courses.Add(courseFormData);
                studentEnrollmentContext.SaveChanges();
                return "success";
            }
            return "error";
        }
    }
}
