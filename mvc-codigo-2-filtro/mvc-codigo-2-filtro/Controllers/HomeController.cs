using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_2_filtro.Controllers
{
    public class HomeController : Controller
    {
        //defino filtro Authorize, cada vez que se declare antes del Action o  Método, significa
        //que el metodo que sigue, solo se puede acceder con autenticación
        //[Authorize]
        // GET: Home
        public string Index()
        {
            return "Este es mi controlador HOME/INICIO";
        }

        //defino que solo los roles de Admin pueden acceder a estos metodos
        //[Authorize (Roles ="Admin")]
        //probamos el funcionamiento de OutputCache
        //[OutputCache (Duration = 10)]
        //añadimos la funcion de ActionName
        //[ActionName("Hora")]//si se coloca así, no funciona el metodo
        /*public string HoraActual()
        {
            return DateTime.Now.ToString("T");
        }*/

        //ahora usamos el NonAction, para que le usuario no pueda acceder a este metodo comportamiento
        public string HoraActual()
        {
            return CadenaHora();
        }
        //le añado el NonAction, para impedir que no pueda ser accesible por el usuario desde la WEB
        [NonAction]
        public string CadenaHora()
        {
            return "Son las " + DateTime.Now.ToString("T");
        }
    }
}
