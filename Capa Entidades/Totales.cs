using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Totales
    {
        private decimal total;
        private decimal iVA;
        private decimal totalSinIVA;

        public decimal Total { get => total; set => total = value; }
        public decimal IVA { get => iVA; set => iVA = value; }
        public decimal TotalSinIVA { get => totalSinIVA; set => totalSinIVA = value; }
    }
}
