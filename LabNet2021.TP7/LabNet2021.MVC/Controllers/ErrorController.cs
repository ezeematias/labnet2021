using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        public ActionResult Custom()
        {
            ViewBag.Message = "Custom pureba - Vacio";
            return View("Index");
        }
    }
}