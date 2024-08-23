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
    public class Table3Controller : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: Table3
        public ActionResult Index()
        {
            return View(db.Table3.ToList());
        }

        // GET: Table3/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table3 table3 = db.Table3.Find(id);
            if (table3 == null)
            {
                return HttpNotFound();
            }
            return View(table3);
        }

        // GET: Table3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,qebul_edilsin,teklif_miqdari")] Table3 table3)
        {
            if (ModelState.IsValid)
            {
                db.Table3.Add(table3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table3);
        }

        // GET: Table3/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table3 table3 = db.Table3.Find(id);
            if (table3 == null)
            {
                return HttpNotFound();
            }
            return View(table3);
        }

        // POST: Table3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,qebul_edilsin,teklif_miqdari")] Table3 table3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table3);
        }

        // GET: Table3/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table3 table3 = db.Table3.Find(id);
            if (table3 == null)
            {
                return HttpNotFound();
            }
            return View(table3);
        }

        // POST: Table3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table3 table3 = db.Table3.Find(id);
            db.Table3.Remove(table3);
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
