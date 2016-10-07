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
    public class EmployeeStatController : Controller
    {
        private ERPEntities db = new ERPEntities();

        // GET: Database/EmployeeStat
        public ActionResult Index()
        {
            return View(db.dbempstats.ToList());
        }

        // GET: Database/EmployeeStat/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbempstat dbempstat = db.dbempstats.Find(id);
            if (dbempstat == null)
            {
                return HttpNotFound();
            }
            return View(dbempstat);
        }

        // GET: Database/EmployeeStat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Database/EmployeeStat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iEmpStat,sEmpStat")] dbempstat dbempstat)
        {
            if (ModelState.IsValid)
            {
                db.dbempstats.Add(dbempstat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbempstat);
        }

        // GET: Database/EmployeeStat/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbempstat dbempstat = db.dbempstats.Find(id);
            if (dbempstat == null)
            {
                return HttpNotFound();
            }
            return View(dbempstat);
        }

        // POST: Database/EmployeeStat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iEmpStat,sEmpStat")] dbempstat dbempstat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbempstat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbempstat);
        }

        // GET: Database/EmployeeStat/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbempstat dbempstat = db.dbempstats.Find(id);
            if (dbempstat == null)
            {
                return HttpNotFound();
            }
            return View(dbempstat);
        }

        // POST: Database/EmployeeStat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            dbempstat dbempstat = db.dbempstats.Find(id);
            db.dbempstats.Remove(dbempstat);
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
