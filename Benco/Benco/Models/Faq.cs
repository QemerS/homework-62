using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Faq
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string Question { get; set; }
        [Column("ntext")]
        public string Answer { get; set; }
    }
}
