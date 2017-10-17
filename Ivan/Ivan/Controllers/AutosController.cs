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
    public class AutosController : Controller
    {
        private IvanContext db = new IvanContext();

        // GET: Autos
        public ActionResult Index()
        {
            return View(db.Autos.ToList());
        }

        // GET: Autos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autos autos = db.Autos.Find(id);
            if (autos == null)
            {
                return HttpNotFound();
            }
            return View(autos);
        }

        // GET: Autos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Numero_Unidad,Tipo")] Autos autos)
        {
            if (ModelState.IsValid)
            {
                db.Autos.Add(autos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autos);
        }

        // GET: Autos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autos autos = db.Autos.Find(id);
            if (autos == null)
            {
                return HttpNotFound();
            }
            return View(autos);
        }

        // POST: Autos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Numero_Unidad,Tipo")] Autos autos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autos);
        }

        // GET: Autos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autos autos = db.Autos.Find(id);
            if (autos == null)
            {
                return HttpNotFound();
            }
            return View(autos);
        }

        // POST: Autos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autos autos = db.Autos.Find(id);
            db.Autos.Remove(autos);
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
