using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Kisi
    {
        [Key]
        public int KisiID { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
