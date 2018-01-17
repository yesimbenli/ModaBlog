using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string Icerik { get; set; }
        //[ForeignKey("Uye")]
        public int UyeID { get; set; }
        //[ForeignKey("Makale")]
        public int MakaleID { get; set; }
        public DateTime Tarih { get; set; }
        public Yorum()
        {
            Tarih = DateTime.Now;
        }
    }
}
