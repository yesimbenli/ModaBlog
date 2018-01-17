using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MakaleRep : GeneralRepository<Makale> { }
    public class KategoriRep : GeneralRepository<Kategori> { }
    public class EtiketRep : GeneralRepository<Etiket> { }
    public class UyeRep : GeneralRepository<Uye> { }
    public class KisiRep : GeneralRepository<Kisi> { }
    public class YetkiRep : GeneralRepository<Yetki> { }
    public class YorumRep : GeneralRepository<Yorum> { }
  
}