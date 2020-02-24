using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Efactura
    {

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Dni { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }

        public List<EArticulo> Detail = new List<EArticulo>();
    }
   
 

  
}
