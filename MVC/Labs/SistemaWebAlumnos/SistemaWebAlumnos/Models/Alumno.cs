using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebAlumnos.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int AlumnoID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string DNI { get; set; }
        [Required(ErrorMessage = "Ingresar email valido")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
    }
}