﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimNeDio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SliderPartial()
        {
            return PartialView();
        }
        public ActionResult MainPartial()
        {
            return PartialView();
        }
    }
}