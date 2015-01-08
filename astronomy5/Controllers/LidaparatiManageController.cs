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
    public class LidaparatiManageController : Controller
    {
        private AstronomyEntities db = new AstronomyEntities();

        // GET: /LidaparatiManage/
        public ActionResult Index()
        {
            return View(db.Aparati.ToList());
        }

        // GET: /LidaparatiManage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lidaparati lidaparati = db.Aparati.Find(id);
            if (lidaparati == null)
            {
                return HttpNotFound();
            }
            return View(lidaparati);
        }

        // GET: /LidaparatiManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LidaparatiManage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="LidID,Nosaukums,Apraksts")] Lidaparati lidaparati)
        {
            if (ModelState.IsValid)
            {
                db.Aparati.Add(lidaparati);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lidaparati);
        }

        // GET: /LidaparatiManage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lidaparati lidaparati = db.Aparati.Find(id);
            if (lidaparati == null)
            {
                return HttpNotFound();
            }
            return View(lidaparati);
        }

        // POST: /LidaparatiManage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="LidID,Nosaukums,Apraksts")] Lidaparati lidaparati)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lidaparati).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lidaparati);
        }

        // GET: /LidaparatiManage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lidaparati lidaparati = db.Aparati.Find(id);
            if (lidaparati == null)
            {
                return HttpNotFound();
            }
            return View(lidaparati);
        }

        // POST: /LidaparatiManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lidaparati lidaparati = db.Aparati.Find(id);
            db.Aparati.Remove(lidaparati);
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
