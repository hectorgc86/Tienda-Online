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
    public partial class PedidosBuscador : Form
    {
        private TiendaOnline _neg;
        private List<Pedido> listaPedidos;
        private Pedido pedidoSeleccionado;
        private int indexOpcionBusqueda;
        private string estado;
        private Usuario usuarioSeleccionado;

        public PedidosBuscador(string estado)
        {
            InitializeComponent();
            this.estado = estado;
            _neg = new TiendaOnline();
            ActualizarListaPedidos();
           
        }

        private void PedidosBuscador_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuariosBuscador_Click(object sender, EventArgs e)
        {
            if (estado != "Informes")
            {
                PedidosFormulario modificatPedidoForm;


                Utils.PedidoSeleccionado = pedidoSeleccionado;
                modificatPedidoForm = new PedidosFormulario("Modificar");
                modificatPedidoForm.MdiParent = MdiParent;
                modificatPedidoForm.Show();
            }
            else
            {
                PrepararInforme();
            }
        }

        private void PrepararInforme()
        {
           string titulo = "FACTURA";
            string empresa = "Tienda DAM";
            Efactura factura = new Efactura();
            List<EArticulo> articulos = new List<EArticulo>();
            Usuario usu = _neg.BuscarUsuario(pedidoSeleccionado.UsuarioID);
            Localidad loc = _neg.BuscarLocalidad(usu.PuebloID, usu.ProvinciaID);
            factura.NumeroFactura = pedidoSeleccionado.PedidoID;
            factura.Direccion = usu.Calle + " " + usu.Codpos;
            factura.Localidad = loc.Nombre;
            factura.Dni = usu.Dni;
            factura.Fecha = pedidoSeleccionado.Fecha;
            factura.Nombre = usu.Nombre;

            foreach (Linped l in pedidoSeleccionado.LineasPedido)
            {
                EArticulo eart = new EArticulo();

                Articulo art = _neg.ObtenerArticulo(l.ArticuloID);
                eart.Fecha = factura.Fecha;
                eart.Cantidad = l.Cantidad;
                eart.Descripcion = art.Nombre;
                eart.Importe = l.Importe;
                articulos.Add(eart);

            }
            factura.Detail = articulos;

            FacturaRpt informe = new FacturaRpt();
            informe.Invoice.Add(factura);
            informe.Detail = factura.Detail;
            informe.Titulo = titulo;
            informe.Empresa = empresa;
            informe.MdiParent = MdiParent;
            informe.MdiParent.Show();

          

        }

        private void prepararInforme(Pedido pedidoSeleccionado)
        {
           
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsuariosBuscador nuevoUsuariosBuscador;
            Utils.FormPedidosBuscador1 = this;
            nuevoUsuariosBuscador = new UsuariosBuscador("Buscador Pedidos");
            nuevoUsuariosBuscador.MdiParent = MdiParent;
            nuevoUsuariosBuscador.Show();
        }
        public void SeleccionaUsuario(Usuario usu)
        {
            usuarioSeleccionado = usu;
            textBox1.Text = usu.Nombre;
            filtrarPedidos();
        }

        private void filtrarPedidos()
        {
            List <Pedido> pedidos=(List<Pedido>) dataGridViewUsuarios.DataSource;
            pedidos =  pedidos.Where(p => p.UsuarioID == usuarioSeleccionado.UsuarioID || p.Fecha.Equals(dateTimePickerFecha.Value)).ToList();
            dataGridViewUsuarios.DataSource = pedidos;
            pedidoSeleccionado = (Pedido)dataGridViewUsuarios.Rows[0].DataBoundItem;
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            filtrarPedidos();
        }

        private void ActualizarListaPedidos()
        {
            //Muestro para empezar toda la lista sin filtros
            dataGridViewUsuarios.DataSource = _neg.ListarPedidos();

            //Hago que el primer usuario que se muestra por defecto sea el usuario seleccionado al iniciar
            pedidoSeleccionado = (Pedido)dataGridViewUsuarios.Rows[0].DataBoundItem;
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pedidoSeleccionado = (Pedido)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;

        }

        private void labelUsuarios_Click(object sender, EventArgs e)
        {

        }
    }
}
