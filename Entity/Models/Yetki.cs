using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Yetki
    {
        [Key]
        public int YetkiID { get; set; }
        public string Yetkisi { get; set; }

    }
}
