using Entity.Models;
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
    //public class Makale:Icerik
    //{
    //    [Key]
    //    public int MakaleID { get; set; }
    //    [DisplayName("Makale Başlığı")]
    //    public string MakaleBaslik { get; set; }
    //    [DisplayName("Makale İçeriği")]
    //    public string MakaleIcerik { get; set; }
    //    public string MakaleKonusu { get; set; }
    //    public string YazarAdi { get; set; }
    //    [DisplayName("Makale Eklenme Tarihi")]
    //    public DateTime EklenmeTarihi { get; set; }
    //    public string ResimURL { get; set; }
    //    public Makale()
    //    {
    //        EklenmeTarihi = DateTime.Now;
    //    }
    //}
    public class Makale
    {
        [Key]
        public int MakaleID { get; set; }
        [DisplayName("Makale Başlık")]
        public string Baslik { get; set; }
        [DisplayName("Makale İçerik")]
        public string Icerik { get; set; }
        public string Yazar { get; set; }
        public string ResimURL { get; set; }
        public DateTime Tarih { get; set; }
        //[ForeignKey("KategoriID")]
        public int KategoriID { get; set; }
        public int UyeID { get; set; }
        public int Okuma { get; set; }
        public Makale()
        {
            Tarih = DateTime.Now;
        }
    }
    public abstract class SEOIcerik
    {
        [DisplayName("SEO Title")]
        public string Title { get; set; }
        [DisplayName("SEO Description")]
        public string Description { get; set; }
        [DisplayName("SEO Keywords")]
        public string Keywords { get; set; }
    }
}
