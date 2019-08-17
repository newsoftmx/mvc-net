using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_1.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        /*public ActionResult Index()
        {
            return View();
        }*/
        /*public string Index()
        {
            return "Este es mi Controlador Home 2";
        }*/
        public ActionResult Index()
        {
            return RedirectToAction("TodosLosProveedores", "Proveedores");
        }
    }
}