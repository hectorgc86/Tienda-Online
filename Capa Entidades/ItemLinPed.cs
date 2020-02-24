using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class ItemLinPed
    {
        private int linea;
        private int cantidad;
        private string marca;
        private string nombre;
        private decimal importe;

        public int Linea { get => linea; set => linea = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Importe { get => importe; set => importe = value; }
    }
}
