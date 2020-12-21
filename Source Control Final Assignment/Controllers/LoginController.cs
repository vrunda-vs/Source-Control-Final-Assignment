using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Source_Control_Final_Assignment.Models;
namespace Source_Control_Final_Assignment.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login lg)
        {
            if (ModelState.IsValid)
            {
                Session["username"] = Request.Form["username"];
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}