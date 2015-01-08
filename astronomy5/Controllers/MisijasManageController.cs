using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using astronomy5.Models;

namespace astronomy5.Controllers
{
    public class MisijasManageController : Controller
    {
        private AstronomyEntities db = new AstronomyEntities();

        // GET: /MisijasManage/
        public ActionResult Index()
        {
            return View(db.Misijas.ToList());
        }

        // GET: /MisijasManage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misijas misijas = db.Misijas.Find(id);
            if (misijas == null)
            {
                return HttpNotFound();
            }
            return View(misijas);
        }

        // GET: /MisijasManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MisijasManage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool Create([Bind(Include="MisijaID,Nosaukums,Datums,Organizacija,Apraksts,Rezultats,Tips")] Misijas misijas)
        {
            if (ModelState.IsValid)
            {
                db.Misijas.Add(misijas);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return true;
            }

           // return View(misijas);
            return false;
        }

        // GET: /MisijasManage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misijas misijas = db.Misijas.Find(id);
            if (misijas == null)
            {
                return HttpNotFound();
            }
            return View(misijas);
        }

        // POST: /MisijasManage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool Edit([Bind(Include="MisijaID,Nosaukums,Datums,Organizacija,Apraksts,Rezultats,Tips")] Misijas misijas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misijas).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // GET: /MisijasManage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Misijas misijas = db.Misijas.Find(id);
            if (misijas == null)
            {
                return HttpNotFound();
            }
            return View(misijas);
        }

        // POST: /MisijasManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public bool DeleteConfirmed(int id)
        {
            Misijas misijas = db.Misijas.Find(id);
            db.Misijas.Remove(misijas);
            db.SaveChanges();
            //return RedirectToAction("Index");
            return true;
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
