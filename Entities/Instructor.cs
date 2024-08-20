using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int Dep_ID { get; set; }

        [ForeignKey("Dept_ID")]
        [InverseProperty("Instructor")]
        public Department Department { get; set; }

        [InverseProperty("DepartmentManged")]
        public Department DepartmentManager { get; set; }

        [InverseProperty("Instructor")]
        public ICollection<Course_Inst> Course_Insts { get; set; }= new HashSet<Course_Inst>();
    }
}
