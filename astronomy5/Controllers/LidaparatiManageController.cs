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
        private AstroEntities db = new AstroEntities();

        // GET: /LidaparatiManage/
        public ActionResult Index()
        {
            return View(db.Lidaparati.ToList());
        }

        // GET: /LidaparatiManage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lidaparati lidaparati = db.Lidaparati.Find(id);
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
        public bool Create([Bind(Include="LidID,Nosaukums,Apraksts")] Lidaparati lidaparati)
        {
            if (ModelState.IsValid)
            {
                db.Lidaparati.Add(lidaparati);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return true;
            }
            return false;
            //return View(lidaparati);
        }

        // GET: /LidaparatiManage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lidaparati lidaparati = db.Lidaparati.Find(id);
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
        public bool Edit([Bind(Include="LidID,Nosaukums,Apraksts")] Lidaparati lidaparati)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lidaparati).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return true;
            }
            //return View(lidaparati);
            return false;
        }

        // GET: /LidaparatiManage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lidaparati lidaparati = db.Lidaparati.Find(id);
            if (lidaparati == null)
            {
                return HttpNotFound();
            }
            return View(lidaparati);
        }

        // POST: /LidaparatiManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public bool DeleteConfirmed(int id)
        {
            Lidaparati lidaparati = db.Lidaparati.Find(id);
            db.Lidaparati.Remove(lidaparati);
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
