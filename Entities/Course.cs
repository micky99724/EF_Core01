using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Course
    {
        public int ID { get; set; }
        public Double Duration { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public int Top_ID { get; set; }
        [ForeignKey("Top_ID")]
        [InverseProperty("Course")]
        public Topic Topic { get; set; }

        [InverseProperty("Course")]
        public ICollection<Course_Inst> Course_Insts { get; set; }= new HashSet<Course_Inst>();

        [InverseProperty("Course")]
        public ICollection<Stud_course> Stud_Courses { get; set; }=new HashSet<Stud_course>();
    }
}
