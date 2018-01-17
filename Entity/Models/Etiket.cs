using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Etiket
    {
        [Key]
        public int EtiketID { get; set; }
        public string EtiketAdi { get; set; }
    }
}
