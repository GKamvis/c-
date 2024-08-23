using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_delivery.Models;

namespace WebApplication3_delivery.Controllers
{
    public class HomeController : Controller
    {
        KamDBEntities db = new KamDBEntities();

        public ActionResult Index()
        {
            var sorgu1 = db.Logins.ToList();
            //@model IEnumerable<WebApplication3_delivery.Models.Login>


            return View(sorgu1);
        }

        public ActionResult About()
        {

            var sorgu = db.Logins.ToList();

            return View(sorgu);
        }

        //  public ActionResult About(Login User_name)
        //{
        //  using (KamDBEntities entities = new KamDBEntities())
        //{
        //  entities.Logins.Add(User_name);
        //entities.SaveChanges();
        // int id = Login.UserId;
        //}
        //return View(User_name);
        //}


        [HttpPost]
        public ActionResult SaveResult(string teamName, string result)
        {
           // using (var db = new KamDBEntities())
            
                var login = new Login
                {
                    User_name = teamName,
                    Password = result
                };

                db.Logins.Add(login);

                db.SaveChanges();
            

            return RedirectToAction("Index");
        }

        public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }


        }

//
/// bu aradaki koldar ----------------
    public ActionResult Login(string username, string password)
    {
        using (var db = new ApplicationDbContext())
        {
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Session["LoggedInUser"] = username;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Username or password is incorrect";
                return View("Contact");
            }
        }
    }
    ////









}
}