using BLL;
using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModaBlog.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Index()
        {
            GeneralRepository<Makale> brep = new GeneralRepository<Makale>();
            List<Makale> listem = brep.GetAll();
            return View(listem);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}