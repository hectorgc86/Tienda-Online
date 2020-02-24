using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capa_Presentacion
{

    // Lógica de interacción para VistaLogin.xaml
   
    public partial class VistaLogin : Window
    {
        // Variables y constantes

        private const int NUMEROMAXIMODEINTENTOS = 3;

        private Negocio _neg;
        private List<Usuario> listaUsuarios;
        private Usuario usuarioLogueado;

        private int contadorFallosLogin;

        // Constructor

        public VistaLogin()
        {
            InitializeComponent();

            _neg = new Negocio();

            CrearUsuarioAdministrador();

            try
            {
                listaUsuarios = _neg.ListarUsuarios();
            }
            catch (Exception e) {

            }
           
            OcultarCamposObligatorios();
        }


        // Método de ocultación de campos obligatorios del formulario al iniciar

        private void OcultarCamposObligatorios()
        {
            asteriscoUsuario.Visibility = Visibility.Hidden;
            asteriscoContrasenya.Visibility = Visibility.Hidden;
            labelCamposObligatorios.Visibility = Visibility.Hidden;
        }

       
        // Método de aparición de campos obligatorios

        private void EnsenyaCamposObligatorios()
        {
            asteriscoUsuario.Visibility = Visibility.Visible;
            asteriscoContrasenya.Visibility = Visibility.Visible;
            labelCamposObligatorios.Visibility = Visibility.Visible;
        }

        
        // Evento del botón salir
      
        private void AccionBotonCerrar(object sender, RoutedEventArgs e)
        {
            Utils.MostrarDialogSalir();  
        }

        // Evento del botón de minimizado

        private void AccionBotonMinimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // Evento de acción del botón de acceder

        private void AccionBotonAcceder(object sender, RoutedEventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("El campo \"Usuario\" no puede estar vacío", "Error");
                EnsenyaCamposObligatorios();
            }
            else if (passBoxContrasenya.Password == "")
            {
                MessageBox.Show("El campo \"Contraseña\" no puede estar vacío", "Error");
                EnsenyaCamposObligatorios();
            }
            else
            {
                OcultarCamposObligatorios();

                try
                {
                    usuarioLogueado = _neg.Login(textBoxUsuario.Text, Utils.CalcularMD5(passBoxContrasenya.Password));
                }
                catch (Exception ex) {

                }

                if (usuarioLogueado != null)
                {
                    VistaPrincipal vistaPrincipal = new VistaPrincipal(usuarioLogueado);
                     vistaPrincipal.Show();
                     Close();
                }
                else
                {
                   Utils.MostrarDialogError("Error", "Error de inicio de sesión, usuario o contraseña incorrectos");

                        contadorFallosLogin++;

                        if (contadorFallosLogin == NUMEROMAXIMODEINTENTOS)
                        {

                        Utils.MostrarDialogError("Error", "Ha superado el número de intentos fallidos de inicio de sesion");
                       
                                Environment.Exit(0);
                    }
                }

            }
    }

        // Método de creación automática de un usuario administrador

        private void CrearUsuarioAdministrador()
        {

            Usuario usuarioAdministrador = new Usuario();
            usuarioAdministrador.Nombre = "cliente";
            usuarioAdministrador.Apellidos = "apellidoscliente";
            usuarioAdministrador.Password = Utils.CalcularMD5("1234");
            usuarioAdministrador.Calle = "c/1";
            usuarioAdministrador.Calle2 = "c/2";
            usuarioAdministrador.Email = "admin@tiendadam.es";
            usuarioAdministrador.Codpos = "00000";
            usuarioAdministrador.Dni = "53239222U";
            usuarioAdministrador.Nacido = new DateTime(1986, 10, 26);
            usuarioAdministrador.Telefono = "666000000";
            usuarioAdministrador.PuebloID = "2331";
            usuarioAdministrador.ProvinciaID = "46";

            usuarioAdministrador.Email = "admin@tiendadam.es";

            try
            {
                _neg.AnyadirUsuario(usuarioAdministrador);

            }
            catch (Exception e) {

            }
        }
    }
    
}
