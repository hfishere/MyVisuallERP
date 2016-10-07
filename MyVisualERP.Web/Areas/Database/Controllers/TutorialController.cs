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
    public class TutorialController : Controller
    {
        private ERPEntities db = new ERPEntities();

        // GET: Database/Tutorial
        public ActionResult Index()
        {
            return View(db.dbtutorials.ToList());
        }

        // GET: Database/Tutorial/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbtutorial dbtutorial = db.dbtutorials.Find(id);
            if (dbtutorial == null)
            {
                return HttpNotFound();
            }
            return View(dbtutorial);
        }

        // GET: Database/Tutorial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Database/Tutorial/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pID,sName,sAddress")] dbtutorial dbtutorial)
        {
            if (ModelState.IsValid)
            {
                db.dbtutorials.Add(dbtutorial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbtutorial);
        }

        // GET: Database/Tutorial/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbtutorial dbtutorial = db.dbtutorials.Find(id);
            if (dbtutorial == null)
            {
                return HttpNotFound();
            }
            return View(dbtutorial);
        }

        // POST: Database/Tutorial/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pID,sName,sAddress")] dbtutorial dbtutorial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbtutorial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbtutorial);
        }

        // GET: Database/Tutorial/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbtutorial dbtutorial = db.dbtutorials.Find(id);
            if (dbtutorial == null)
            {
                return HttpNotFound();
            }
            return View(dbtutorial);
        }

        // POST: Database/Tutorial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            dbtutorial dbtutorial = db.dbtutorials.Find(id);
            db.dbtutorials.Remove(dbtutorial);
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
