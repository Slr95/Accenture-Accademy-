using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaFinal.Models
{
    [Table("Empleado")]
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "money")]
        public decimal Salario { get; set; }
    
        public DateTime Fecha { get; set; }


        public int CodOficina { get; set; }
        [ForeignKey("CodOficina")]
        public Oficina Oficina { get; set; }

        public List<Reserva> Reservas { get; set; }
    }
}
