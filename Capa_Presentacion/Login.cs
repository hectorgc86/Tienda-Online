using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        private const int NUMEROMAXIMODEINTENTOS = 3;

        private TiendaOnline _neg;
        private List<Usuario> listaUsuarios;
       
        private int contadorFallosLogin;


        public Login()
        {
            InitializeComponent();
            _neg = new TiendaOnline();
            CrearUsuarioAdministrador();
            listaUsuarios = _neg.ListarUsuarios();

            //Escondo aviso de campos obligatorios
            OcultarCamposObligatorios();

         

        }

        private void OcultarCamposObligatorios()
        {
            labelCamposObligatorios.Hide();
            labelAsteriscoRojo.Hide();
            labelAsteriscoRojo2.Hide();
        }

        private void EnsenyaCamposObligatorios()
        {
            labelCamposObligatorios.Show();
            labelAsteriscoRojo.Show();
            labelAsteriscoRojo2.Show();
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("El campo \"Usuario\" no puede estar vacío", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EnsenyaCamposObligatorios();
            }
            else if (textBoxContrasenya.Text == "")
            {
                MessageBox.Show("El campo \"Contraseña\" no puede estar vacío", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EnsenyaCamposObligatorios();
            }
            else
            {

               Usuario usuarioLogueado = _neg.Login(textBoxUsuario.Text, textBoxContrasenya.Text);

                if (usuarioLogueado != null)
                {
                   
                        contadorFallosLogin = 0;
                        IrAFormPrincipal(usuarioLogueado);

                }
                else
                {

                    var result = MessageBox.Show("Error de inicio de sesión", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (result == DialogResult.OK)
                    {
                        contadorFallosLogin++;

                        if (contadorFallosLogin == NUMEROMAXIMODEINTENTOS)
                        {
                            var result2 = MessageBox.Show("Ha superado el número de intentos fallidos de inicio de sesion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            if (result == DialogResult.OK)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }

                }

            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            Utils.mostrarMensajeSalir();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Utils.mostrarMensajeSalir())
            {
                e.Cancel = true;
            }
        }

        private void IrAFormPrincipal(Usuario usuarioLogueado)
        {

            Principal nuevoPrincipal;

            nuevoPrincipal = new Principal(usuarioLogueado);
            nuevoPrincipal.Show();
            this.Hide();
        }

        private void CrearUsuarioAdministrador()
        {

            Usuario usuarioAdministrador = new Usuario();
            usuarioAdministrador.Nombre = "cliente";
            usuarioAdministrador.Apellidos = "apellidoscliente";
            usuarioAdministrador.Password = "1234";
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

            _neg.AnyadirUsuario(usuarioAdministrador);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
