﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WinfocusLearningApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description view.";

            return View();
        }
        public ActionResult AboutSamad()
        {
            ViewBag.Message = "Your application description view. testing from Mac";

            return View();
        }
        public ActionResult About2()
        {
            ViewBag.Message = "Your application description view.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}