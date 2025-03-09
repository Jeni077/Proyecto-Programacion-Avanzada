using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AdvancedProgramming.Controllers
{
    using System.Web.Mvc;

    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Esta quemado
            if (username == "admin" && password == "1234")
            {
                Session["User"] = username;
                return RedirectToAction("Index", "Home"); 
            }
            else
            {
                ViewBag.Error = "Usuario o contraseña incorrectos";
                return View(); 
            }
        }

        // Cerrar sesión
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login", "Account"); 
        }
    }
}