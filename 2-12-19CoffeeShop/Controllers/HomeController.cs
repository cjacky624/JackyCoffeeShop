using _2_12_19CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_12_19CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Result(User u)
        {
            ViewBag.FirstName = u.FirstName;
            ViewBag.LastName = u.LastName;
            ViewBag.Email = u.Email;
            ViewBag.PhoneNumber = u.PhoneNumber;
            ViewBag.Password = u.Password;
            ViewBag.BirthDate = u.BirthDate;

            return View();
        }
    }
}