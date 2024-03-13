using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    /// <summary>
    /// Entities for course
    /// </summary>
    public class Course
    {
        // primary key
        [Key]
        public int CourseId { get; set; }

        [MaxLength(100)]
        public string CourseName { get; set; }

        public DateTime StartDate {  get; set; }
        
        public DateTime EndDate { get; set; }

        // multiple enrollments with one course - Navigation Property

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
