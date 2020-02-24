using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class ItemPedido
    {
        private int numPedido;
        private string nombreUsuario;
        private string apellidosUsuario;
        private string fechaPedido;

        public int NumPedido { get => numPedido; set => numPedido = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public string ApellidosUsuario { get => apellidosUsuario; set => apellidosUsuario = value; }
    }
}
