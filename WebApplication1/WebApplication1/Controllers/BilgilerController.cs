﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BilgilerController : Controller
    {
        // GET: Bilgiler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Egitim()
        {
            return View();
        }
    }
}