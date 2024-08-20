using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        [ForeignKey("Dep_Id")]
        [InverseProperty("Students")]
        public Department Department { get; set; }

        [InverseProperty("Student")]
        public ICollection<Stud_course> Stud_Courses { get; set; }
    }
}
