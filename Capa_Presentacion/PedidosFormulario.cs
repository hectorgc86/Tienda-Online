using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class PedidosFormulario : Form
    {

        private TiendaOnline _neg;

        private string estado;

        private List<Linped> linpeds;
        private Pedido pedidoAModificar;
        private int pedidoId;
        private bool modificando;
        private Usuario usuarioSeleccionado;
        private Articulo articuloSeleccionado;
        BindingSource bs;


        public Usuario UsuarioSeleccionado { get => usuarioSeleccionado; set => usuarioSeleccionado = value; }

        public PedidosFormulario(string estado)
        {
            InitializeComponent();

            _neg = new TiendaOnline();



            linpeds = new List<Linped>();

            bs = new BindingSource(linpeds, null);
            this.estado = estado;

            if (estado == "Nuevo")
            {
                modificando = false;
                this.Text = "Nuevo Pedido";
                labelTituloPedidosForm.Text = "NUEVO PEDIDO";
                labelInfoPedidosForm.Text = "Seleccione un usuario y artículo/s q para crear una linea de pedido. Si esta conforme pulse en el botón \"Realizar pedido\"";
                btnPedidoVariable.Text = "Realizar pedido";

                pedidoId = _neg.PedidoMasAlto() + 1;

            }else if (estado == "Modificar")
            {
                cargarDatos();
                modificando = true;
                this.Text = "Modificar Pedido";
                labelTituloPedidosForm.Text = "MODIFICAR PEDIDO";
                labelInfoPedidosForm.Text = "Seleccione un usuario y artículo/s q para crear una linea de pedido. Si esta conforme pulse en el botón \"Realizar pedido\"";
                btnPedidoVariable.Text = "Modificar pedido";
            }



        }



        private void btnPedidosVariable_Click(object sender, EventArgs e)
        {
            try
            {
                if (estado == "Nuevo")
                {

                    if (_neg.AnyadirPedido(pedidoId, usuarioSeleccionado.UsuarioID, dateTimePickerFecha.Value))
                    {

                        if (linpeds.Count > 0)
                        {
                            foreach (Linped l in linpeds)
                            {
                                _neg.AnyadirLinped(l);
                            }
                        }

                        MessageBox.Show("Pedido " + pedidoId + " añadido correctamente");

                        ReseteaCampos();
                    }
                    else
                    {
                        MessageBox.Show("Pedido " + pedidoId + " no ha sido añadido");

                    }
                }
                else
                {
                    pedidoAModificar.Fecha = dateTimePickerFecha.Value;
                    pedidoAModificar.UsuarioID = Convert.ToInt32(pedidoId);

                    if (_neg.ModificarPed(pedidoAModificar))
                    {
                        if (linpeds.Count > 0)
                        {
                            foreach (Linped l in linpeds)
                            {
                                _neg.ModificarLinPed(l);

                            }
                        }

                        MessageBox.Show("Pedido " + pedidoId + " modificado correctamente");
                        ReseteaCampos();
                        //ventanaPed.actualizarPedidos();

                    }
                    else
                    {
                        MessageBox.Show("Pedido " + pedidoId + " no ha sido modificado");
                    }
                }

            }
            catch (Exception ex)
            {
                Utils.MostrarErroresBd(ex.Message);

            }

        }

        public void SeleccionaUsuario(Usuario usu)
        {
            usuarioSeleccionado = usu;
            textBox1.Text = usu.Nombre;
        }

        public void SeleccionaProducto(Articulo art)
        {
            articuloSeleccionado = art;
            textBox2.Text = art.Nombre;
        }

        public void ReseteaCampos()
        {
            usuarioSeleccionado = null;

           //TODO: Limpiar campos
            linpeds = new List<Linped>();
        }




        private void btnUsuario_Click(object sender, EventArgs e)
        {
            UsuariosBuscador nuevoUsuariosBuscador;
            Utils.FormPedidosSeleccionado = this;
            nuevoUsuariosBuscador = new UsuariosBuscador("Seleccionar");
            nuevoUsuariosBuscador.MdiParent = MdiParent;
            nuevoUsuariosBuscador.Show();
        }

        private void btnPedidoVariable_Click(object sender, EventArgs e)
        {
            try
            {

                if (!modificando)
                {
                    if (_neg.AnyadirPedido(pedidoId, usuarioSeleccionado.UsuarioID, dateTimePickerFecha.Value)){
                        if (linpeds.Count > 0) {
                            foreach (Linped l in linpeds) {
                                _neg.AnyadirLinped(l);                           
                            }

                        }

                        MessageBox.Show("Pedido " + pedidoId + " añadido correctamente");



                        ReseteaCampos();

                       // ventanaPed.actualizarPedidos();

                    }

                    else

                    {

                        MessageBox.Show("Pedido " + pedidoId + " no ha sido añadido");



                    }

                }

                else

                {

                  //  pedidoAModificar.Fecha = dateTimePicker1.Value;

                  //  pedidoAModificar.UsuarioID = Convert.ToInt32(comboBox1.SelectedValue.ToString());

                    if (_neg.ModificarPed(pedidoAModificar))

                    {

                        if (linpeds.Count > 0)
                        {

                            foreach (Linped l in linpeds)

                            {

                                _neg.ModificarLinPed(l);



                            }

                        }

                        MessageBox.Show("Pedido " + pedidoId + " modificado correctamente");

                        ReseteaCampos();

                    //    ventanaPed.actualizarPedidos();



                    }

                    else

                    {

                        MessageBox.Show("Pedido " + pedidoId + " no ha sido modificado");

                    }

                }
            }

            catch (Exception ex)
            {
                Utils.MostrarErroresBd(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnyadirLinped_Click(object sender, EventArgs e)
        {
            ProductosFormulario nuevoProductosFormulario;
            Utils.FormPedidosSeleccionado = this;
            nuevoProductosFormulario = new ProductosFormulario("Seleccionar");

            nuevoProductosFormulario.MdiParent = MdiParent;
            nuevoProductosFormulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)this.numericUpDown1.Value <= 0)

            {

                MessageBox.Show("Seleccione una cantidad mayor a 0");

            }
            else if (articuloSeleccionado == null)

            {

                MessageBox.Show("Seleccione un artículo");

            }

            else if (usuarioSeleccionado == null)

            {

                MessageBox.Show("Seleccione un usuario");

            }

            else
            {

                Linped linped = new Linped(articuloSeleccionado.ArticuloID, pedidoId, linpeds.Count + 1, (int)this.numericUpDown1.Value, articuloSeleccionado.Pvp.Value);

                linpeds.Add(linped);

                bs.ResetBindings(false);

                Totales totales = _neg.CalcularTotalPedido(linpeds);

                totalSinIVATextBox.Text = totales.TotalSinIVA.ToString();
                TotalTextBox.Text = totales.Total.ToString();
                IVATextBox.Text = totales.IVA.ToString();


            }
        }

        private void PedidosFormulario_Load(object sender, EventArgs e)
        {
            bs.ResetBindings(false);

            dataGridViewLinPeds.DataSource = null;

            bs.DataSource = null;

            bs.DataSource = linpeds;

            dataGridViewLinPeds.DataSource = bs;
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelFechaPedido_Click(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        internal void cargarDatos()

        {

            pedidoAModificar = Utils.PedidoSeleccionado;

            pedidoId = pedidoAModificar.PedidoID;

            dateTimePickerFecha.Value = pedidoAModificar.Fecha;
            usuarioSeleccionado = _neg.BuscarUsuario(pedidoAModificar.UsuarioID);
            textBox1.Text = usuarioSeleccionado.Nombre;
            linpeds = pedidoAModificar.LineasPedido;

    

            bs.ResetBindings(false);

            dataGridViewLinPeds.DataSource = null;

            bs.DataSource = null;

            bs.DataSource = linpeds;

            dataGridViewLinPeds.DataSource = bs;



        }
    }
}
