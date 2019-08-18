using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_codigo_3_modelo.Models
{
    public class Clientes
    {
        //definimos con que propiedades va a trabajar nuestro modelo
        public int ID { get; set; }
        public string nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public int edad { get; set; }
    }
}