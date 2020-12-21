using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Source_Control_Final_Assignment.Models;
using log4net;

namespace Source_Control_Final_Assignment.Controllers
{
    public class RegistrationController : Controller
    {
       private static log4net.ILog log { get; set; }
        ILog Log = log4net.LogManager.GetLogger(typeof(Registration));
        // GET: Registration
        public ActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registration reg,HttpPostedFileBase image)
        {
            log.Debug("debug messege");
            log.Warn("warn messege");
            log.Error("error messege");
            log.Fatal("fatal messege");
           /* string us = reg.UploadUserFile(image);
            if (us != null)
            {
                ViewBag.ResultErrorMessage = reg.ErrorMessage;
            }*/

            if (ModelState.IsValid)
            {
                log.Info("Your Data has been succesfully saved");
                Session["username"] = Request.Form["firstname"];
                return RedirectToAction("Index", "Home");
            }
          
                return View();
          
          
        }

    }
}