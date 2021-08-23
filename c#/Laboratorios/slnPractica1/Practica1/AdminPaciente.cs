using Entidades.Ejer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPaciente
{
    public static class AdminPaciente
    {
        public static List<Paciente> listPacientes = new List<Paciente>();
        public static int insertar(Paciente paciente)
        {
            if (paciente != null)
                listPacientes.Add(paciente);

            return paciente.id;
        }
        public static List<paciente> listar()
        {
            List<Paciente> listPaciente = new list<Paciente>;
            listPaciente.Add(new Paciente(4569, "Juanito", "Lopez", new DatoContacto("4352", 123456987, 7412), 852, null));
            List<Paciente> listPaciente = new list<Paciente>;
            listPaciente.Add(new Paciente(4569, "Pablo", "Ramirez", new DatoContacto("4352", 123456987, 7412), 852, null));
            List<Paciente> listPaciente = new list<Paciente>;
            listPaciente.Add(new Paciente(4569, "Jose", "Perez", new DatoContacto("4352", 123456987, 7412), 852, null));

            return listPaciente;
        }
        public static Paciente traerPorId(int id)
        {
            foreach(Paciente p in listPacientes)
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
