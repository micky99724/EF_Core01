using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

       
        public int Ins_ID { get; set; }

        [ForeignKey("Ins_ID")]
        [InverseProperty("DepartmentManager")]
        public Instructor DepartmentManged { get; set; }

        public DateTime HiringDate { get; set; }

        [InverseProperty("Department")]
        public ICollection<Instructor> Instructor { get; set; }= new HashSet<Instructor>();

        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; }=new HashSet<Student>();
    }
}
