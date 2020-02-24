using Capa_Entidades;
using System;
using System.Windows.Forms;


//<author> Héctor Granja <author>


namespace Capa_Presentacion
{
    public partial class Principal : Form
    {
        private DateTime contadorTiempoTranscurrido;

        public Principal(Usuario usuarioLogueado)
        {
            InitializeComponent();

            Utils.MdiParent = this;

            labelUsuarioLogueado.Text = usuarioLogueado.Nombre;


            contadorTiempoTranscurrido = DateTime.MinValue;

            timerReloj.Enabled = true;

            timerTiempoTranscurrido.Enabled = true;
        }

        private void usuariosInsertar_Click(object sender, EventArgs e)
        {

            UsuariosFormulario nuevoUsuariosFormulario;

            nuevoUsuariosFormulario = new UsuariosFormulario("Insertar", null);
            nuevoUsuariosFormulario.MdiParent = this;
            nuevoUsuariosFormulario.Show();
        }


        private void VentanaCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void VentanaHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VentanaVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }



        private void archivoSalir_Click(object sender, EventArgs e)
        {
            Utils.mostrarMensajeSalir();
        }



        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Utils.mostrarMensajeSalir())
            {
                e.Cancel = true;
            }

        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe nuevoAcercaDe;

            nuevoAcercaDe = new AcercaDe();
            nuevoAcercaDe.MdiParent = this;
            nuevoAcercaDe.Show();
        }

        private void usuariosModificar_Click(object sender, EventArgs e)
        {
            UsuariosBuscador nuevoUsuariosBuscador;

            nuevoUsuariosBuscador = new UsuariosBuscador("Modificar");
            nuevoUsuariosBuscador.MdiParent = this;
            nuevoUsuariosBuscador.Show();
        }

        private void usuariosEliminar_Click(object sender, EventArgs e)
        {
            UsuariosBuscador nuevoUsuariosBuscador;

            nuevoUsuariosBuscador = new UsuariosBuscador("Eliminar");
            nuevoUsuariosBuscador.MdiParent = this;
            nuevoUsuariosBuscador.Show();
        }

        private void productosConsultar_Click(object sender, EventArgs e)
        {
            ProductosFormulario nuevoProductosFormulario;

            nuevoProductosFormulario = new ProductosFormulario("Consultar");
            nuevoProductosFormulario.MdiParent = this;
            nuevoProductosFormulario.Show();
        }

        private void menuEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas nuevoEstadisticas;

            nuevoEstadisticas = new Estadisticas();
            nuevoEstadisticas.MdiParent = this;
            nuevoEstadisticas.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabelReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerTiempoTranscurrido_Tick(object sender, EventArgs e)
        {

            toolStripLabelContador.Text = contadorTiempoTranscurrido.ToString("HH:mm:ss");

            contadorTiempoTranscurrido = contadorTiempoTranscurrido.AddSeconds(1);

        }

        public void SetErrorText(string error)
        {

            toolStripLabelErroresBD.Text = error;

        }

        private void pedidosNuevo_Click(object sender, EventArgs e)
        {
            PedidosFormulario nuevoPedidosFormulario = new PedidosFormulario("Nuevo");
            nuevoPedidosFormulario.MdiParent = this;
            nuevoPedidosFormulario.Show();
        }

        private void pedidosConsultaYmod_Click(object sender, EventArgs e)
        {
            PedidosBuscador nuevoPedidoBuscador = new PedidosBuscador("Modificar");
            nuevoPedidoBuscador.MdiParent = this;
            nuevoPedidoBuscador.Show();
        }

        private void informesFactura_Click(object sender, EventArgs e)
        {
           PedidosBuscador nuevoPedidoBuscador = new PedidosBuscador("Informes");
            nuevoPedidoBuscador.MdiParent = this;
            nuevoPedidoBuscador.Show();
        }
    }
}
