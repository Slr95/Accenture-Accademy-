using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaWebEmpleados.Data;
using SistemaWebEmpleados.Models;

namespace SistemaWebEmpleados.Initializer
{
    public class EmpleadoDBInitializer : DropCreateDatabaseAlways<EmpleadoDbContext> //se crea y se elimina cada vez que compilo
    {
        protected override void Seed(EmpleadoDbContext context)
        {
            //base.Seed(context);

            var empleados= new List<Empleado>()
            {
                new Empleado("Matias", "Adrogue", "43997332","matiasadro@gmail.com"),
                new Empleado("Ivan", "Adrogue", "43932632","elivo@gmail.com"),
                new Empleado("Ana", "Gomez", "17254140","licgomez@gmail.com"),
                new Empleado("Nora", "Valva", "24533444","norita@gmail.com")
               
            };

            //recorrer la lista y cargo la lista en memoria
            empleados.ForEach(s => context.Empleados.Add(s));
            context.SaveChanges();
        }
    }
}