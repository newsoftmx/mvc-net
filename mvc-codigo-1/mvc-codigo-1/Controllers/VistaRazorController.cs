using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_1.Controllers
{
    public class VistaRazorController : Controller
    {
        // GET: VistaRazor
        public ActionResult Index()
        {
            return View();
        }
    }
}