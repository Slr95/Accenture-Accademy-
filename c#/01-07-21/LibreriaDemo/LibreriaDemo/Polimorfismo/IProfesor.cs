using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDemo.Polimorfismo
{
    public interface IProfesor
    {
        void agregar(Profesor profesor);
        Profesor traerProfesor(int id);
    }
}
