using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{ 
    public class Table4Controller : Controller
    {
        private Database1Entities2 db = new Database1Entities2();

        // GET: Table4
        public ActionResult Index()
        {
            return View(db.Table4.ToList());
        }

        // GET: Table4/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table4 table4 = db.Table4.Find(id);
            if (table4 == null)
            {
                return HttpNotFound();
            }
            return View(table4);
        }

        // GET: Table4/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,city,adress,time,mesage,qiymet,qebul_edilsin")] Table4 table4)
        {
            if (ModelState.IsValid)
            {
                db.Table4.Add(table4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table4);
        }

        // GET: Table4/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table4 table4 = db.Table4.Find(id);
            if (table4 == null)
            {
                return HttpNotFound();
            }
            return View(table4);
        }

        // POST: Table4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,city,adress,time,mesage,qiymet,qebul_edilsin")] Table4 table4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table4);
        }

        // GET: Table4/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table4 table4 = db.Table4.Find(id);
            if (table4 == null)
            {
                return HttpNotFound();
            }
            return View(table4);
        }

        // POST: Table4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table4 table4 = db.Table4.Find(id);
            db.Table4.Remove(table4);
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
