using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer1
{
    public class Cliente
    {
        public Usuario Usuario { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
