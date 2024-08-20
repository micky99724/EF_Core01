using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }


        [InverseProperty("Topic")]
        public Course Course { get; set; }
    }
}
