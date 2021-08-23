using SistemaWebEmpleados.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebEmpleados.Models
{
    public class Empleado
    {

        #region Constructores
        public Empleado() { }

        public Empleado(string nombre, string apellido, string DNI, string Email)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.DNI = DNI;
            this.Email = Email;
        }

        #endregion

        [Required]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)] 
        //[EmailValid]
        public string Email { get; set; }
    }
}