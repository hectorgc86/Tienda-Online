using Capa_Entidades;
using Capa_Negocio;
using Capa_Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

//<author> Héctor Granja <author>

namespace Capa_Presentacion
{
    public partial class UsuariosBuscador : Form
    {
        //Variables
        private TiendaOnline _neg;
        private List<Usuario> listaUsuarios;
        private Usuario usuarioSeleccionado;
        private int indexOpcionBusqueda;
        private string estado;

        public UsuariosBuscador(string estado)
        {
            InitializeComponent();

            //Inicializo la conexión con la capa Negocio
            _neg = new TiendaOnline();

         
            //Asigno lista de usuarios
            try
            {
                listaUsuarios = _neg.ListarUsuarios();
            }
            catch (Exception e)
            {
                Utils.MostrarErroresBd(e.Message);
            }

            //Relleno el comboBox de búsqueda con los tres posibles valores
            comboBoxOpcionBusqueda.Items.Add("Nombre o apellidos");
            comboBoxOpcionBusqueda.Items.Add("DNI");
            comboBoxOpcionBusqueda.Items.Add("Email");

            //Selecciono primera opción de las opciónes de búsqueda
            comboBoxOpcionBusqueda.SelectedIndex = 0;
            labelBusqueda.Text = "Nombre o apellidos:";

            ActualizarListaUsuarios();

            //Averiguo en que estado debe mostrarse el buscador
            if (estado == "Modificar")
            {
                this.Text = "Modificar Usuario";
                labelTituloUsuariosBuscador.Text = "MODIFICAR USUARIO";
                labelInfoUsuariosBuscador.Text = "Seleccione una opción de búsqueda para encontrar un usuario a modificar";
                btnUsuariosBuscador.Text = "Modificar";

            }
            else if (estado == "Eliminar")
            {
                this.Text = "Eliminar Usuario";
                labelTituloUsuariosBuscador.Text = "ELIMINAR USUARIO";
                labelInfoUsuariosBuscador.Text = "Seleccione una opción de búsqueda para encontrar un usuario a eliminar";
                btnUsuariosBuscador.Text = "Eliminar";

            }else if (estado == "Seleccionar" || estado == "Buscador Pedidos")
            {
                this.Text = "Seleccionar Usuario";
                labelTituloUsuariosBuscador.Text = "SELECCIONAR USUARIO";
                labelInfoUsuariosBuscador.Text = "Seleccione una opción de búsqueda para obtener el usuario que realizará el pedido";
                btnUsuariosBuscador.Text = "Seleccionar";
            }
           

            this.estado = estado;
        }

        private void ActualizarListaUsuarios()
        {
            //Muestro para empezar toda la lista sin filtros
            dataGridViewUsuarios.DataSource = _neg.ListarUsuarios();

            //Hago que el primer usuario que se muestra por defecto sea el usuario seleccionado al iniciar
            usuarioSeleccionado = (Usuario)dataGridViewUsuarios.Rows[0].DataBoundItem;
        }

        private void textBoxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            List<Usuario> usuariosCoincidentes = null;

            if (indexOpcionBusqueda == 0)
            { 
                usuariosCoincidentes = listaUsuarios.Where(p => p.Nombre.ToUpper().StartsWith(textBoxBusqueda.Text.ToUpper())
               || p.Apellidos.ToUpper().StartsWith(textBoxBusqueda.Text.ToUpper())).ToList();
            }else if (indexOpcionBusqueda == 1)
            {   
                usuariosCoincidentes = listaUsuarios.Where(p => p.Dni.StartsWith(textBoxBusqueda.Text)).ToList();
            }
            else
            {
                usuariosCoincidentes = listaUsuarios.Where(p => p.Email.StartsWith(textBoxBusqueda.Text)).ToList();
            }

            if (usuariosCoincidentes.Count != 0)
            {
                dataGridViewUsuarios.DataSource = usuariosCoincidentes;
            }
            else { dataGridViewUsuarios.DataSource = ""; }
               
        }

        private void comboBoxOpcionBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

            indexOpcionBusqueda = comboBoxOpcionBusqueda.SelectedIndex;

            if (indexOpcionBusqueda == 0)
            {
                labelBusqueda.Text = "Nombre o apellidos:";
            }
            else if(indexOpcionBusqueda == 1)
            {
                labelBusqueda.Text = "Introduzca dni:";
            }
            else
            {
                labelBusqueda.Text = "Introduzca email:";
            }
           
        }

        private void btnUsuariosBuscador_Click(object sender, EventArgs e)
        {

            if (usuarioSeleccionado != null)
            {
                if (estado == "Modificar")
                {
                    UsuariosFormulario nuevoUsuariosFormulario;

                    nuevoUsuariosFormulario = new UsuariosFormulario("Modificar",usuarioSeleccionado);
                    nuevoUsuariosFormulario.MdiParent = MdiParent;
                    nuevoUsuariosFormulario.Show();
                }
                else if (estado == "Eliminar")
                {
                    try
                    {
                        if (!_neg.UsuarioTienePedidos(usuarioSeleccionado))
                        {
                            var result = MessageBox.Show("¿Desea eliminar al usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Usuario eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _neg.BorrarUsuario(usuarioSeleccionado.UsuarioID.ToString());
                                ActualizarListaUsuarios();
                            }
                        }

                        else
                        {
                            MessageBox.Show("No se puede eliminar un usuario con pedidos registrados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {

                        Utils.MostrarErroresBd(ex.Message);

                    }

                }
                else if (estado == "Seleccionar")
                {
                    Utils.UsuarioSeleccionado = usuarioSeleccionado;
                    Utils.FormPedidosSeleccionado.SeleccionaUsuario(usuarioSeleccionado);
                    this.Close();

                }else if (estado == "Buscador Pedidos")
                {
                    Utils.UsuarioSeleccionado = usuarioSeleccionado;
                    Utils.FormPedidosBuscador1.SeleccionaUsuario(usuarioSeleccionado);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero un usuario de la lista", "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioSeleccionado = (Usuario)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
        }
    }

}