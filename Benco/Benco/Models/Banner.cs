using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Banner
    {
        public int ID { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(250), Required(ErrorMessage = "Uptitle is not valid")]
        public string UpTitle { get; set; }
        [MaxLength(250), Required(ErrorMessage = "Title is not valid")]
        public string Title { get; set; }
        [Column("ntext")]
        public string Context { get; set; }        
    }
}
