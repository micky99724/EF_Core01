using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Entities
{
    internal class Stud_course
    {

        public int Stud_ID { get; set; }

        public int Course_ID { get; set; }
        public double Grade { get; set; }

        [ForeignKey("Course_ID")]
        [InverseProperty("Stud_Courses")]
        public Course Course { get; set; }

        [ForeignKey("stud_ID")]
        [InverseProperty("Stud_Courses")]
        public Student Student { get; set; }
    }
}
