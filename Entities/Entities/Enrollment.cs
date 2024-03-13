using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    /// <summary>
    /// Entities for Enrollment
    /// </summary>
    public class Enrollment
    {
        // primary key
        [Key]
        public int EnrollmentId { get; set; }

        public DateTime EnrolledDate { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }


        // lazy loading of entities in EF
        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}
