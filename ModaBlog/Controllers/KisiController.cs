using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ModaBlog.Controllers
{
    public class KisiController : Controller
    {
        private MyContext db = new MyContext();
        // GET: Kisi
        public ActionResult Index()
        {
            return View(db.Kisiler.ToList());
        }
        public ActionResult KisiEkle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KisiEkle([Bind(Include = "KisiID,AdSoyad,Telefon,Email")] Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                db.Kisiler.Add(kisi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kisi);

        }
        
        public ActionResult Detaylar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisiler.Find(id);
            if (kisi == null)
            {
                return HttpNotFound();
            }
            return View(kisi);
        }
        public ActionResult KisiDuzenle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisiler.Find(id);
            if (kisi == null)
            {
                return HttpNotFound();
            }
            return View(kisi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KisiDuzenle([Bind(Include = "KisiID,AdSoyad,Telefon,Email")] Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kisi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kisi);
        }
        public ActionResult KisiSil(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisiler.Find(id);
            if (kisi == null)
            {
                return HttpNotFound();
            }
            return View(kisi);
        }
        [HttpPost, ActionName("KisiSil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilmeOnay(int id)
        {
            Kisi kisi = db.Kisiler.Find(id);
            db.Kisiler.Remove(kisi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}