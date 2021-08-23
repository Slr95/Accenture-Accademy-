using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public abstract class Persona
    {
        private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
    private string dni;

    public string DNI
    {
        get { return dni; }
        set { dni = value; }
    }
}
}   

