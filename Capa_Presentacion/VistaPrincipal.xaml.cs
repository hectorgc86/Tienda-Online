using Capa_Entidades;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Animation;

namespace Capa_Presentacion
{
    // Integración lógica para VistaPrincipal.xaml

    public partial class VistaPrincipal : Window
    {
       // Variables

       private Usuario usuarioLogueado;
       private bool menuAbierto;

        //Constructor

        public VistaPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();

            this.usuarioLogueado = usuarioLogueado;

            menuAbierto = false;

            nombreUsuarioLogueado.Text = usuarioLogueado.Nombre;

            CrearMenuLateral();
        }

        //Método de creación de botones del menu lateral en tiempo de ejecución

        private void CrearMenuLateral()
        {
            List<SubItem> menuVistaUsuarios = new List<SubItem>();
            menuVistaUsuarios.Add(new SubItem("Insertar", new VistaUsuarios("Insertar")));
            menuVistaUsuarios.Add(new SubItem("Modificar", new VistaUsuarios("Modificar")));
            menuVistaUsuarios.Add(new SubItem("Eliminar", new VistaUsuarios("Eliminar")));
            ItemMenu item1 = new ItemMenu("Usuarios", menuVistaUsuarios, PackIconKind.Account);

            List<SubItem> menuProductos = new List<SubItem>();
            menuProductos.Add(new SubItem("Consultar", new VistaProductos("Consultar")));
            ItemMenu item2 = new ItemMenu("Productos", menuProductos, PackIconKind.Camera);

            List<SubItem> menuPedidos = new List<SubItem>();
            menuPedidos.Add(new SubItem("Nuevo", new VistaPedidos("Nuevo")));
            menuPedidos.Add(new SubItem("Búsqueda y modificación", new VistaPedidos("Modificar")));
            ItemMenu item3 = new ItemMenu("Pedidos", menuPedidos, PackIconKind.Cart);

            List<SubItem> menuEstadisticas = new List<SubItem>();
            menuEstadisticas.Add(new SubItem("Estadísticas", new VistaEstadisticas()));
            ItemMenu item4 = new ItemMenu("Estadísticas", menuEstadisticas, PackIconKind.ChartBar);

            List<SubItem> menuInformes = new List<SubItem>();
            menuInformes.Add(new SubItem("Factura", new VistaPedidos("Seleccionar")));
            ItemMenu item5 = new ItemMenu("Informes", menuInformes, PackIconKind.FileDocumentBox);

            List<SubItem> menuSalir = new List<SubItem>();
            menuSalir.Add(new SubItem("Salir"));
            ItemMenu item6 = new ItemMenu("Archivo", menuSalir, PackIconKind.ExitToApp);

            Menu.Children.Add(new ControladorMenuItem(item1, this));
            Menu.Children.Add(new ControladorMenuItem(item2, this));
            Menu.Children.Add(new ControladorMenuItem(item3, this));
            Menu.Children.Add(new ControladorMenuItem(item4, this));
            Menu.Children.Add(new ControladorMenuItem(item5, this));
            MenuSalir.Children.Add(new ControladorMenuItem(item6, this));
        }

       

        //Método que realiza el cambio de vistas

        internal void CambiarVentana(object sender)
        {
            UserControl ventana = ((UserControl)sender);
           
            if (ventana != null)
            {
                if (!menuAbierto)
                {
                    AbrirMenu();
                }
                else
                {
                    Storyboard myStoryboard = (Storyboard)FindResource("CerrarMenu");
                    myStoryboard.Begin();
                }

                GridVistaPrincipal.Children.Clear();
                GridVistaPrincipal.Children.Add(ventana);

                CerrarMenu();
            }
    }


        //Evento de acción del boton de apertura de menu

        private void BotonAbrirMenu_Click(object sender, RoutedEventArgs e)
        {
            AbrirMenu();
        }

        //Evento de acción del boton de cierre de menu

        private void BotonCerrarMenu_Click(object sender, RoutedEventArgs e)
        {
            CerrarMenu();
        }

        //Lógica de apertura de menu
        internal void AbrirMenuDesdeExpander()
        {
            if (!menuAbierto)
            {
                AbrirMenu();
                Storyboard myStoryboard = (Storyboard)FindResource("AbrirMenu");
                myStoryboard.Begin();
            }
        }
        internal void AbrirMenu()
        {
            BotonCerrarMenu.Visibility = Visibility.Visible;
            BotonAbrirMenu.Visibility = Visibility.Collapsed;
            menuAbierto = true;
        }

        //Lógica de cierre de menu
        internal void CerrarMenu()
        {
            BotonCerrarMenu.Visibility = Visibility.Collapsed;
            BotonAbrirMenu.Visibility = Visibility.Visible;
            menuAbierto = false;
        }

        //Evento de cierre de sesion (vuelta a Login)

        private void AccionCerrarSesion(object sender, RoutedEventArgs e)
        {
            if (Utils.MostrarDialogLogout())
            {
                VistaLogin vistaLogin = new VistaLogin();
                vistaLogin.Show();
                Close();

            }
           
        }

        //Evento de salida del programa

        private void AccionSalir(object sender, RoutedEventArgs e)
        {
            Utils.MostrarDialogSalir();
        }

        //Propiedad estática de la barra de errores de conexión con la base de datos

        public static StatusUpdate Status { get; set; } = new StatusUpdate();
    }
}
