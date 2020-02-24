using System;

namespace Capa_Entidades
{
    public class EArticulo
    {
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal? ImporteUnitario { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }
      
    }
}