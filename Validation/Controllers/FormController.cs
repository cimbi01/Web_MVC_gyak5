﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gyak5.Validation.Controllers
{
    public class FormController : Controller
    {
        public ActionResult FormHelper()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormHelper(Validation.Models.Diak d)
        {
            return View(d);
        }
        public ActionResult FormHtml()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FormHtml(Validation.Models.Diak d)
        {
            return View(d);
        }
        public ActionResult FormHelperRequest()
        {
            return View();
        }

    }
}