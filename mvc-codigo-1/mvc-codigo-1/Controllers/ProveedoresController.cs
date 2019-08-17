using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_1.Controllers
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        /*public ActionResult Index()
        {
            return View();
        }*/
        public string TodosLosProveedores()
        {
            return @"<ul>
                    <li> Enrique Aguilar </li>
                    <li> Miguel de Icaza </li>
                    <li> Hugo Gómez </li>
                    </ul>";
        }
    }
}