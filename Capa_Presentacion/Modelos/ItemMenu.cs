using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Capa_Presentacion
{
    public class ItemMenu
    {
        public ItemMenu(string cabecera, List<SubItem> subItems, PackIconKind icono)
        {
            Cabecera = cabecera;
            SubItems = subItems;
            Icono = icono;
        }

        public string Cabecera { get; private set; }
        public PackIconKind Icono { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public UserControl Ventana { get; private set; }
    }
}
