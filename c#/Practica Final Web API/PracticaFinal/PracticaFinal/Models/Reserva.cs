using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaFinal.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        public int Id { get; set; }
        
        public DateTime Fecha { get; set; }
        public string Destino { get; set; }
        public double Kilometros { get; set; }

        public int CodEmpleado { get; set; }
        [ForeignKey("CodEmpleado")]
        public Empleado Empleado { get; set; }

        public int CodVehiculo { get; set; }
        [ForeignKey("CodVehiculo")]
        public Auto Auto { get; set; }
    }
}
