﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlogProject.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Home()
        {
            return View();
        }
    }
}