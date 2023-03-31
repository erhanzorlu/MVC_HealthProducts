using Project.ViewModels.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
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

        public ActionResult Register() //Üye ol
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AppUserVM appUser) //Üye ol
        {
            return View();
        }
        public ActionResult Login()// Giriş yap
        {

            return View();
        }
    }
}