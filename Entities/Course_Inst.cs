using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core.Entities
{

    internal class Course_Inst
    {

        public int Inst_ID { get; set; }


        public int Course_ID { get; set; }
        public int Evaluate { get; set; }

        [ForeignKey("inst_ID")]
        [InverseProperty("Course_Insts")]
        public Instructor Instructor { get; set; }

        [ForeignKey("Course_ID")]
        [InverseProperty("Course_Insts")]
        public Course Course { get; set; }
    }
}
