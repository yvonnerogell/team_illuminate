using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Illuminate.Models;

namespace Illuminate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Inventory()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Inventory2()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AddEditClinic()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditClinic()
        {
            return View();
        }

        public ActionResult EditClinic1()
        {
            return View();
        }

        public ActionResult EditClinic2()
        {
            return View();
        }

        public ActionResult EditClinic3()
        {
            return View();
        }

        public ActionResult ClinicReport()
        {
            return View();
        }

     
    }
}