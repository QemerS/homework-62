using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Servise
    {
        public int ID { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Icon { get; set; }
        [Column("ntext")]
        public string Context { get; set; }
    }
}
