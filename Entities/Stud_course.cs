using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    [Keyless]
    internal class Stud_course
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public double Grade { get; set; }
    }
}
