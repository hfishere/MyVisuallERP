using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using My.DAL;
using My.Repository.Repository;
using My.Repository.Interfaces;

namespace MyVisualERP.Web.Areas.Database.Controllers
{
    [Authorize]
    public class TutorialController : Controller
    {
        //private ERPEntities db = new ERPEntities();
        private IEntityRepository<dbtutorial, int> repoTutor;

        // Constructor #1
        // Bikin Constructor, caranya tinggal ketik 'ctor' trus pencet tab 2x
        public TutorialController()
        {
            repoTutor = new TutorialRepository();
        }

        // Constructor #2
        public TutorialController(IEntityRepository<dbtutorial, int> tutorRepo)
        {
            repoTutor = tutorRepo;
        }

        // GET: Database/Tutorial
        public ActionResult Index()
        {
            //return View(db.dbtutorials.ToList());
            // Ganti dengan ini
            var tutor = repoTutor.GetAllData();
            return View(tutor);
        }

        // GET: Database/Tutorial/Details/5
        // Ganti byte menjadi int (karena keynya int)
        public ActionResult Details(int id)
        {
            if (id == 0) // Ganti jadi 0 (karena int)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //dbtutorial dbtutorial = db.dbtutorials.Find(id);
            // Ganti dengan ini
            dbtutorial dbtutorial = repoTutor.Search(id);
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
                //db.dbtutorials.Add(dbtutorial);
                //db.SaveChanges();
                // Ganti dengan ini
                repoTutor.Insert(dbtutorial);
                return RedirectToAction("Index");
            }

            return View(dbtutorial);
        }

        // GET: Database/Tutorial/Edit/5
        // Ganti byte menjadi int (karena keynya int)
        public ActionResult Edit(int id)
        {
            if (id == 0) // Ganti jadi 0 (karena int)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //dbtutorial dbtutorial = db.dbtutorials.Find(id);
            // Ganti dengan ini
            dbtutorial dbtutorial = repoTutor.Search(id);
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
                //db.Entry(dbtutorial).State = EntityState.Modified;
                //db.SaveChanges();
                // Ganti dengan ini
                repoTutor.Update(dbtutorial);
                return RedirectToAction("Index");
            }
            return View(dbtutorial);
        }

        // Ganti byte menjadi int (karena keynya int)
        public ActionResult Delete(int id)
        {
            if (id == 0) // Ganti jadi 0 (karena int)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //dbtutorial dbtutorial = db.dbtutorials.Find(id);
            // Ganti dengan ini
            dbtutorial dbtutorial = repoTutor.Search(id);
            if (dbtutorial == null)
            {
                return HttpNotFound();
            }
            return View(dbtutorial);
        }

        // Ganti byte menjadi int (karena keynya int)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //dbtutorial dbtutorial = db.dbtutorials.Find(id);
            //db.dbtutorials.Remove(dbtutorial);
            //db.SaveChanges();
            // Ganti dengan ini
            dbtutorial dbtutorial = repoTutor.Search(id);
            repoTutor.Delete(id);
            return RedirectToAction("Index");
        }

        // Bagian ini komen aja dulu
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
