using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

   
        // GET: Default1/Create
        public ActionResult Index()
        {
            return View();
        }

        // POST: Default1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,city,adress,time,mesage")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                db.MyModels.Add(myModel);
                db.SaveChanges();
                return RedirectToAction("About");
            }

            return View(myModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,city,adress,time,mesage")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                db.MyModels.Add(myModel);
                db.SaveChanges();
                return RedirectToAction("About");
            }

            return View(myModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application Details page.";

            return View(db.MyModels.ToList());

        }

        // GET: Home/Contact/5
        public ActionResult Contact(int? id)
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

        // POST: Home/Contact/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include = "Id,city,adress,time,mesage")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myModel);
        }
        //public ActionResult Contact(int id)
       // {
        //    var message = db.MyModels.FirstOrDefault(m => m.Id == id);
          //  if (message == null)
            //{
              //  return HttpNotFound();
            //}
            //return View(message);
        //}

    }
}