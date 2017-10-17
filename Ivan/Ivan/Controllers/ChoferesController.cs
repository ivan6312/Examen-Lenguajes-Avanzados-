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
    public class ChoferesController : Controller
    {
        private IvanContext db = new IvanContext();

        // GET: Choferes
        public ActionResult Index()
        {
            return View(db.Choferes.ToList());
        }

        // GET: Choferes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Choferes choferes = db.Choferes.Find(id);
            if (choferes == null)
            {
                return HttpNotFound();
            }
            return View(choferes);
        }

        // GET: Choferes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Choferes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Apellido,Direccion")] Choferes choferes)
        {
            if (ModelState.IsValid)
            {
                db.Choferes.Add(choferes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(choferes);
        }

        // GET: Choferes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Choferes choferes = db.Choferes.Find(id);
            if (choferes == null)
            {
                return HttpNotFound();
            }
            return View(choferes);
        }

        // POST: Choferes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Apellido,Direccion")] Choferes choferes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(choferes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(choferes);
        }

        // GET: Choferes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Choferes choferes = db.Choferes.Find(id);
            if (choferes == null)
            {
                return HttpNotFound();
            }
            return View(choferes);
        }

        // POST: Choferes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Choferes choferes = db.Choferes.Find(id);
            db.Choferes.Remove(choferes);
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
