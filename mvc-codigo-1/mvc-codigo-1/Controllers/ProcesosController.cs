using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_1.Controllers
{
    public class ProcesosController : Controller
    {
        // GET: Procesos
        /*public ActionResult Index()
        {
            return View();
        }*/
        public string Listado()
        {
            return "Listado de Pocesos";
        }
    }
}