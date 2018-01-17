﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Kullanıcı:IdentityUser
    {
        [Required]
        [DisplayName("İsim Soyisim")]
        public string AdSoyad { get; set; }
        public string Meslek { get; set; }
        public string WebSitesi { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        public string Resim { get; set; }

    }
}
