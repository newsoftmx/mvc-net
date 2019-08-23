using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//añadimos el espacio de nombres para validaciones
using System.ComponentModel.DataAnnotations;

namespace mvc_codigo_3_modelo.Models
{
    public class Clientes
    {
        //definimos con que propiedades va a trabajar nuestro modelo
        public int ID { get; set; }
        //añado atributos de validación al nombre
        [StringLength (60, MinimumLength =3)]
        public string nombre { get; set; }

        [DataType (DataType.Date)]
        [DisplayFormat (DataFormatString = "0:YYYY-MM-dd", ApplyFormatInEditMode = true)]
        [Display (Name ="Fecha de alta")]
        
        public DateTime FechaAlta { get; set; }
        [Range(18, 70)]
        public int edad { get; set; }
    }
   // el Entity Framework genera una base de datos con el nombre que le demos al DbContext
    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
        //la cadena de conexion s epuede hacer usando la configuracion en el WEBConfig
    }
}