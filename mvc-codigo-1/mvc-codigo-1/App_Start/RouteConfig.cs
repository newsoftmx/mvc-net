using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc_codigo_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*creo mis propias rutas*/
            routes.MapRoute(
                "Procesos",
                "Procesos/{action}/{id}",
                defaults: new { controller =  "Procesos", action =  "Listado", id = UrlParameter.Optional }
                );
            //fin de creacion de rutas propias

            /*creo ruta de Clientes*/
            /*routes.MapRoute(
                "Clientes",
                /*"Clientes/{action}/{id}",
                defaults: new { controller = "Clientes", action = "ListadoClientes", id = UrlParameter.Optional }*/
                /*"Clientes/{controller}/{action}/{id}",
                defaults: new { controller = "Clientes", action = "Clientes", id = UrlParameter.Optional }
                );*/
            //fin de creacion de rutas Clientes
            /*ruta del curso*/
            routes.MapRoute(
                "ClientesBuscar",
                "Clientes/{nombre}",
                defaults: new { controller = "Clientes", action = "Buscar", nombre = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
