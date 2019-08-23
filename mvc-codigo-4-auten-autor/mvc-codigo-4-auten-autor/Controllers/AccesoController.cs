using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_4_auten_autor.Controllers
{
    //convierte privado todo mi controlador, al haber dejado antes de la clase del controlador, si agrego el users
    //le indico que solo el usuario que se logue con el usuario indicado, podra ver esta información
    [Authorize (Users = "tecsiscom2@hotmail.com")]
    public class AccesoController : Controller
    {
        
        // GET: Acceso
        [HttpGet]
        public ContentResult Privado()
        {
            return Content("Esto es privado");
        }
        //permite que este metodo se pueda acceder/ver sin haber iniciado sesion, es puiblico
        [HttpGet]
        [AllowAnonymous]
        public ContentResult Publico()
        {
            return Content("Publico, esto es publico");
        }
    }
}