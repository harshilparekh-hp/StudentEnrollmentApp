using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    /// <summary>
    /// Entities for Student
    /// </summary>
    public class Student
    {
        // primary key
        [Key]
        public int StudentId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }


        public string Email { get; set; }

        // one student can be enrolled in multiple courses - navigation property in EF
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
