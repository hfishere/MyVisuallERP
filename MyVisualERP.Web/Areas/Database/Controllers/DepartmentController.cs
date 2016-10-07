using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using My.DAL;

namespace MyVisualERP.Web.Areas.Database.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private ERPEntities db = new ERPEntities();

        // GET: Database/Department
        public ActionResult Index()
        {
            return View(db.dbtodepts.ToList());
        }

        // GET: Database/Department/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbtodept dbtodept = db.dbtodepts.Find(id);
            if (dbtodept == null)
            {
                return HttpNotFound();
            }
            return View(dbtodept);
        }

        // GET: Database/Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Database/Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iDept,sDept,sNotes,sFile")] dbtodept dbtodept)
        {
            if (ModelState.IsValid)
            {
                db.dbtodepts.Add(dbtodept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbtodept);
        }

        // GET: Database/Department/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbtodept dbtodept = db.dbtodepts.Find(id);
            if (dbtodept == null)
            {
                return HttpNotFound();
            }
            return View(dbtodept);
        }

        // POST: Database/Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iDept,sDept,sNotes,sFile")] dbtodept dbtodept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbtodept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbtodept);
        }

        // GET: Database/Department/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbtodept dbtodept = db.dbtodepts.Find(id);
            if (dbtodept == null)
            {
                return HttpNotFound();
            }
            return View(dbtodept);
        }

        // POST: Database/Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            dbtodept dbtodept = db.dbtodepts.Find(id);
            db.dbtodepts.Remove(dbtodept);
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
