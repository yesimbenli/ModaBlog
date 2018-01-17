using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Gallery
    {
        [Key]
        [Required]
        public int ImageID { get; set; }
        public string ImagePath { get; set; }
        public string DescriptionGallery { get; set; }
    }
}
