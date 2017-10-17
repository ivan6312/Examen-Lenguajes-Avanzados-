using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ivan.Models;

namespace Ivan.Controllers
{
    public class CentralsController : Controller
    {
        private IvanContext db = new IvanContext();

        // GET: Centrals
        public ActionResult Index()
        {
            return View(db.Centrals.ToList());
        }

        // GET: Centrals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Central central = db.Centrals.Find(id);
            if (central == null)
            {
                return HttpNotFound();
            }
            return View(central);
        }

        // GET: Centrals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Centrals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Telefono")] Central central)
        {
            if (ModelState.IsValid)
            {
                db.Centrals.Add(central);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(central);
        }

        // GET: Centrals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Central central = db.Centrals.Find(id);
            if (central == null)
            {
                return HttpNotFound();
            }
            return View(central);
        }

        // POST: Centrals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Telefono")] Central central)
        {
            if (ModelState.IsValid)
            {
                db.Entry(central).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(central);
        }

        // GET: Centrals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Central central = db.Centrals.Find(id);
            if (central == null)
            {
                return HttpNotFound();
            }
            return View(central);
        }

        // POST: Centrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Central central = db.Centrals.Find(id);
            db.Centrals.Remove(central);
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
