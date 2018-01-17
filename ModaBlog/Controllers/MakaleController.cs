using BLL;
using System.Data.Entity;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Collections.Generic;
using Entity.Models;
using System.Web.Helpers;

namespace ModaBlog.Controllers
{
    public class MakaleController : Controller
    {
        // GET: Makale

        public ActionResult Index()
        {
            GeneralRepository<Makale> bref = new GeneralRepository<Makale>();
            List<Makale> listem = bref.GetAll();
            return View(listem);
        }
     
        public ActionResult MakaleEkle()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult MakaleEkle(Makale k)
        {
                if (ModelState.IsValid)
                {
                    new MakaleRep().Insert(k);
                    return RedirectToAction("Index");
                }    
           return View(k); 
        }

        public ActionResult MakaleDetail(int id)
        {
            return View(new GeneralRepository<Makale>().GetById(id));
        }
    }
}