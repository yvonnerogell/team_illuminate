﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}