using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class Default1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Default1
        public ActionResult Index()
        {
            return View(db.MyModels.ToList());
        }

     


        // GET: Default1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyModel myModel = db.MyModels.Find(id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // GET: Default1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,city,adress,time,mesage")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                db.MyModels.Add(myModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myModel);
        }

        // GET: Default1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyModel myModel = db.MyModels.Find(id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // POST: Default1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,city,adress,time,mesage")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myModel);
        }

        // GET: Default1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyModel myModel = db.MyModels.Find(id);
            if (myModel == null)
            {
                return HttpNotFound();
            }
            return View(myModel);
        }

        // POST: Default1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyModel myModel = db.MyModels.Find(id);
            db.MyModels.Remove(myModel);
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
