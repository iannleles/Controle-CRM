﻿using ControleCRM.ViewModels;
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

        [HttpPost]
        public ActionResult Cadastro(ClienteViewModel clienteViewModel)
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

        public ActionResult Login()  
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}