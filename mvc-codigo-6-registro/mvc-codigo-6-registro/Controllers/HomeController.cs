using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//se debe de agregar el modelo, caso contrario no toma la llave
using mvc_codigo_6_registro.Models;

namespace mvc_codigo_6_registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registro obj)
        {
            //envia a la tabla registro el modelo quel eenvie/
            //comprobamos que la validación que vimos en formularios, se usa de forma valida
            //la propiedad ISValid, verifica que las validaciones de mi vista me devuelvan un valor true o false
            if (ModelState.IsValid)
            {
                //creamos una variable para que nos pueda guardar los datos
                //MiRegistroEntities db = new MiRegistroEntities();
                //la palabra MiRegistroEntities es el nombre de la conexion al servidor, en este caso 
                //yo use la llamada pruebaMVCEntities, la pueden ver en el webconfig en la sección de 
                //<connectionStrings>     < add name = "pruebaMVCEntities" c db = new mvc_codigo_6_registroEntities();
                pruebaMVCEntities1 db = new pruebaMVCEntities1();
                db.Registroes.Add(obj);
                db.SaveChanges();    
                    
            }
         //le indicamos que me regreso el objeto procesado
         return View(obj);
        }
    }
}