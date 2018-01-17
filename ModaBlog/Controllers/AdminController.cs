using BLL;
using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ModaBlog.Controllers
{
    public class AdminController : Controller
    {
        MyContext db = new MyContext();
        // GET: Admin
        public ActionResult AdminPanel()
        {
            MakaleRep rep = new MakaleRep();
            var model = rep.GetAll().ToList();
            return View(model);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makaleler.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

        // POST: Deneme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Makale makale = db.Makaleler.Find(id);
            db.Makaleler.Remove(makale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makaleler.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

    }
}