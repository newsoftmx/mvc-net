using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_1.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Clientes()
        {
            return View();
            //return "Clientes Chingon";
        }
        /*public string ListadoClientes()
        {
            return "Clientes Chingon";
        }*/
        //action del curso
        /*public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode(nombre) + " Bienvenido";
            return Content(input);
        }*/
    }
}