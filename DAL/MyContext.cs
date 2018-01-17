using Entity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyContext : IdentityDbContext<IdentityUser>
    {
        public virtual DbSet<Makale> Makaleler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Etiket> Etiketler { get; set; }
        public virtual DbSet<Uye> Uyeler { get; set; }
        public virtual DbSet<Kisi> Kisiler { get; set; }
        public virtual DbSet<Yetki> Yetkiler { get; set; }
        public virtual DbSet<Yorum> Yorumlar { get; set; }
 
    }
}
