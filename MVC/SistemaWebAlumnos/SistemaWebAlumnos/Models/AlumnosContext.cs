using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaWebAlumnos.Models
{
    public class AlumnosContext: DbContext{
    public AlumnosContext() : base("keyDB") { }
    public DbSet<Alumno> Alumnos { get; set; }
}

}