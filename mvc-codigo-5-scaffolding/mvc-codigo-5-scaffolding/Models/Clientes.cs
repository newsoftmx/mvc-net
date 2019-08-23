using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvc_codigo_5_scaffolding.Models
{
    public class Clientes
    {
        //añadimos propiedas
        public int ID { get; set; }
        public string nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public int edad { get; set; }
    }
    //agregamos la clase que tiene los daos que vamos a consultar
    //esta clase hace posible el acceso de la información
    public class EmpDBContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        //public System.Data.Entity.DbSet<mvc_codigo_5_scaffolding.Models.Clientes> Clientes { get; set; }
    }
}