using ControleCRM.ViewModels;
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
        public ActionResult RecuperarSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarSenha(RecuperarSenhaViewModel recuperarSenhaViewModel)
        {
            if (ModelState.IsValid)
            {
                TempData["RecuperarSenha"] = "Um E-mail foi enviado para ....";
                return View();
            }
            else
            {
                TempData["RecuperarSenha"] = "Informe um e-mail para que possamos recuperar sua senha";

                return View();
            }
                
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

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                if (loginViewModel.Email == "teste@teste.com" && loginViewModel.Senha == "1234")
                {
                    return RedirectToAction("Index");
                }
                else 
                {
                    TempData["Login"] = "E-mail ou senha inválidos";
                    return View();
                }
            }
            else 
            {
                return View();
            }

        }
    }
}