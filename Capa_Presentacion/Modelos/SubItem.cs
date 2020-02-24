using System.Windows.Controls;

namespace Capa_Presentacion
{
    public class SubItem
    {
        public SubItem(string nombre)
        {
            Nombre = nombre;
        }
        public SubItem(string nombre, UserControl ventana = null)
        {
            Nombre = nombre;
            Ventana = ventana;
        }

        public string Nombre { get; private set; }
        public UserControl Ventana { get; private set; }
    }
}