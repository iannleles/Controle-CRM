using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleCRM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

<<<<<<< HEAD
        public ActionResult Login()  
=======
        public ActionResult Login()
>>>>>>> c9c9c0d41f0b4406a0127179856130d2ee7aa3c8
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}