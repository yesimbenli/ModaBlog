using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Uye
    {
        [Key]
        public int UyeID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string AdSoyad { get; set; }
        public string Fotograf { get; set; }
        //[ForeignKey("Uye")]
        public int YetkiID { get; set; }

    }
}
