using Microsoft.EntityFrameworkCore;
using PracticaFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaFinal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Oficina> Oficinas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
