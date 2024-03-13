using DAL;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseService
    {
        CourseRepository courseRepository = new CourseRepository();

        public string AddCourseService(Course courseFormData)
        {
            return courseRepository.AddCourse(courseFormData);
        }

    }
}
