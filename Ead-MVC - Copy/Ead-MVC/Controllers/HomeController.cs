using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ead_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
         
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult RegisterVendor()
        {
            return View();
        }
        public ActionResult RegisterCustomer()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View("PasswordReset");
        }
    }
}