using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class WorkingHour
    {
        public int ID { get; set; }
        [MaxLength(20), Required]
        public string BeginDayOfWeek { get; set; }
        [MaxLength(20), Required]
        public string EndDayOfWeek { get; set; }
        [Required]
        public DateTime BeginHour { get; set; }
        [Required]
        public DateTime EndHour { get; set; }
    }
}
