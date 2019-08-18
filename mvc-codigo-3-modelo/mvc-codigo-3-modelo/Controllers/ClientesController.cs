using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_codigo_3_modelo.Models;

namespace mvc_codigo_3_modelo.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Clientes> emplist = new List<Clientes> {

            new Clientes {
                ID = 1,
                nombre = "Juan Victor",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 30
            },
            new Clientes {
                ID = 2,
                nombre = "Karla Alejandra",
                FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 37
            },

            };
        // GET: Clientes
        //modifico mi metodo del actionresult Index
        public ActionResult Index()
        {
            //return View();
            /*var Clientes = from e in TodosLosClientes()
                           orderby e.ID
                           select e;
            return View(Clientes);*/
            var Clientes = from e in emplist
                           orderby e.ID
                           select e;
            return View(Clientes);

        }

        // GET: Clientes/Details/5 muestra el detalle de los datos
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create permite crear un cliente
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create permite crear un cliente
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        //I**** IMPORTANTE ESTE ES EL MÉTODO POR GET *****//
        //a la ActionResult se le añade su Vista para poder Trabajar
        public ActionResult Edit(int id)
        {
            //return View();
            List<Clientes> empList = TodosLosClientes();
            //cuando se le dice m => se le indica que seleccione el registro del modelo, donde debe 
            //de coincidir el ID que tiene con el modelo que le pasamos
            var Clientes = empList.Single(m => m.ID == id);
            //finalmente mandamos llamar la Lista Clientes
            return View(Clientes);
        }

        // POST: Clientes/Edit/5
        //MODIFICAMOS EL METODO EDIT CUANDO TRABAJA POR POST
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                //return RedirectToAction("Index");
                //la variable Clientes toma la variable que se obtiene como ID
                var Clientes = emplist.Single(m => m.ID == id);
                //verifica que si mientras se actualice el modelo, nos regrese al Index o pagina de inicio, 
                //esto lo hace solo si se actualiza o hace el update
                if (TryUpdateModel(Clientes))
                    //nos regresa al Index o página de Inicio solo si se actualiza o hace el update del Cliente
                    return RedirectToAction("Index");
                return View(Clientes);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        //agregamos un listado de clientes para poderlo trabajar
        //pero es necesario agregar una referencia al modelo con el cual trabajara mi controlador
        public List<Clientes> TodosLosClientes()
        {
            return new List<Clientes>
            {
                new Clientes{

                    ID =1,
                    nombre = "Juan Victor",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad  =30
                 },
                new Clientes
                {
                    ID =2,
                    nombre = "Karla Alejandra",
                    FechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                    edad = 35
                },

            };
        }
    }
}
