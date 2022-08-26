using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XssDemo.Controllers
{ 
    public class DemoController : Controller
    {
        [ValidateInput(false)]
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
    }
}