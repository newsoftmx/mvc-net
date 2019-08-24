using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_codigo_8_lista_jquery.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            //creamos una lista que contiene los paises
            List<string> Lista = new List<string>();
            Lista.Add("Seleccionar");
            Lista.Add("USA");
            Lista.Add("México");
            Lista.Add("Brasil");
            Lista.Add("Uruguay");

            //se crea el selector de paises, el cual se llena con la lista anterior
            SelectList Paises = new SelectList(Lista);
            //creamos un viewData para que contenga los paises del selector pasado
            ViewData["Paises"] = Paises;
            return View();
        }

        //creamos el metodo de accion que e sun jresult, se llama jresult porqu eusa JQuery
        //segun el pais que le mandemos nos mandara un lista do provincias
        public JsonResult Provincias(string Pais)
        {
            //creamos la lista de provincias que contendra las provincia sa mostrar seun el pais seleccionado
            List<string> ListaProvincias = new List <string>();
            //creamos un selector de casos, donde segun el país nos mandara las provincias
            switch (Pais)
            {
                case "USA":
                    ListaProvincias.Add("Los Angeles");
                    ListaProvincias.Add("Chicago");
                    ListaProvincias.Add("Texas");
                    break;
                case "México":
                    ListaProvincias.Add("Jalisco");
                    ListaProvincias.Add("Guanajuato");
                    ListaProvincias.Add("Aguascalientes");
                    break;
                case "Brasil":
                    ListaProvincias.Add("Brasilia");
                    ListaProvincias.Add("Amazonas");
                    ListaProvincias.Add("Rio de Janeiro");
                    break;
                case "Uruguay":
                    ListaProvincias.Add("Montevideo");
                    ListaProvincias.Add("Uris");
                    ListaProvincias.Add("Alves");
                    break;
                /*default:
                    ListaProvincias.Add("No ha seleccionado país");
                    break;*/
            }
            //retornamos una cadena Json con la lista de provincias
            return Json(ListaProvincias);
        }
    }
}