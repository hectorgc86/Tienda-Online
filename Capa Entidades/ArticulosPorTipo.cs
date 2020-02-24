
using System.Collections.Generic;

namespace Capa_Entidades
{
    public class ArticulosPorTipo
    {
        private string nombre;
        private List<Articulo> listaArticulos;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Articulo> ListaArticulos { get => listaArticulos; set => listaArticulos = value; }
    }
}