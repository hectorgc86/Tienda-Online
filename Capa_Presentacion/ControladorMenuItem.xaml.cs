using System.Windows;
using System.Windows.Controls;

namespace Capa_Presentacion
{
    
    // Logica de interacción para ControladorMenuItem.xaml

    public partial class ControladorMenuItem : UserControl
    {
        //Variables

        private VistaPrincipal _contexto;

        //Constructor, recibe el item y el contexto desde principal

        public ControladorMenuItem(ItemMenu itemMenu, VistaPrincipal contexto)
        {
            InitializeComponent();

            _contexto = contexto;

            ExpansivoMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }

        //Evento ejecutado al pulsar en el botón

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _contexto.CambiarVentana(((SubItem)((ListView)sender).SelectedItem).Ventana);
        }

        //Evento que da la orden de cambiar ventana a principal en función a donde se ha clicado

        private void ListViewMenu_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var listView = sender as ListView;
            var item = listView.SelectedItem;

            if (item != null) {
             
                if (((SubItem)((ListView)sender).SelectedItem).Nombre == "Salir")
                {
                    Utils.MostrarDialogSalir();
                }
                else
                {
                    _contexto.CambiarVentana(((SubItem)((ListView)sender).SelectedItem).Ventana);
                }
            }

           
        }

        //Evento que crea un efecto óptico plegado automático en el menu

        private void ExpansivoMenu_LostFocus(object sender, RoutedEventArgs e)
        {
            ((Expander)sender).IsExpanded = false;
        }

        //Evento que se ejecuta al expandir el desplegable para crear otro efecto visual
        private void ExpansivoMenu_Expanded(object sender, RoutedEventArgs e)
        {
            _contexto.AbrirMenuDesdeExpander();

        }
    }

    
}
