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
    public partial class ProductosFormulario : Form
    {
        //Variables
        private TiendaOnline _neg;
        private List<Articulo> listaArticulos;
        List<Articulo> articulosCoincidentes = null;
        private Articulo articuloSeleccionado;
        private int indexOpcionFiltrar;
        private string estado;
      

        public ProductosFormulario(string estado) {
         this.estado = estado;
        
            InitializeComponent();

            //Inicializo la conexión con la capa Negocio
            _neg = new TiendaOnline();


            //Asigno lista de articulos
            try
            {
                listaArticulos = _neg.ListarArticulos();
            }
            catch (Exception e)
            {

                Utils.MostrarErroresBd(e.Message);

            }


            //Relleno el comboBox de filtrado con los posibles valores
            comboBoxOpcionFiltrar.Items.Add("Camara");
            comboBoxOpcionFiltrar.Items.Add("Objetivo");
            comboBoxOpcionFiltrar.Items.Add("Memoria");
            comboBoxOpcionFiltrar.Items.Add("Tv");

            //Selecciono primera opción de las opciónes de filtrado
            comboBoxOpcionFiltrar.SelectedIndex = 0;


            //Escondo el panel de propiedades
            flowLayoutPanelPropiedadesProductos.Hide();

           
            if (estado == "Consultar") {
                labelTituloProductos.Text = "CONSULTAR PRODUCTO";
                btnProductos.Text = "Modificar";
            }
            else if (estado == "Seleccionar")
            {
                labelTituloProductos.Text = "SELECCIONAR PRODUCTO";
                btnProductos.Text = "Seleccionar";
            }

        }


        private void textBoxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {

            articulosCoincidentes = listaArticulos.Where(p => p.Nombre.ToUpper().StartsWith(textBoxBusquedaNombre.Text.ToUpper())).ToList();


            if (articulosCoincidentes.Count != 0)
            {
                dataGridViewProductos.DataSource = articulosCoincidentes;
            }
            else { dataGridViewProductos.DataSource = ""; }

        }

        private void comboBoxOpcionFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {

            indexOpcionFiltrar = comboBoxOpcionFiltrar.SelectedIndex;

            if (indexOpcionFiltrar == 0)
            {
                articulosCoincidentes = listaArticulos.Where(p => p.TipoArticuloID == 3).ToList();
            }
            else if (indexOpcionFiltrar == 1)
            {
                articulosCoincidentes = listaArticulos.Where(p => p.TipoArticuloID == 4).ToList();
            }
            else if (indexOpcionFiltrar == 2)
            {
                articulosCoincidentes = listaArticulos.Where(p => p.TipoArticuloID == 2).ToList();
            }
            else if (indexOpcionFiltrar == 3)
            {
                articulosCoincidentes = listaArticulos.Where(p => p.TipoArticuloID == 1).ToList();
            }

            dataGridViewProductos.DataSource = articulosCoincidentes;
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            articuloSeleccionado = (Articulo)dataGridViewProductos.SelectedRows[0].DataBoundItem;
            flowLayoutPanelPropiedadesProductos.Show();
            ModificarPanelPropiedades();
        }


        private void ModificarPanelPropiedades()
        {

            if (articuloSeleccionado.TipoArticuloID == 1)
            {

               
                    Utils.LimpiarErroresBd();

                    try
                    {
                        Tv tv = _neg.ObtenerTv(articuloSeleccionado.ArticuloID);

                        string[] propiedadesTv = tv.GetType().GetProperties().Select(p => p.Name).ToArray();

                        for (int i = 0; i < propiedadesTv.Length; i++)
                        {

                            Label lb = new Label();

                            lb.Text = propiedadesTv[i];

                            lb.Location = new Point(0, 0);

                            flowLayoutPanelPropiedadesProductos.Controls.Add(lb);



                            TextBox tb = new TextBox();


                            tb.Location = new Point(0, 0);

                            tb.Size = new Size(200, 20);

                            flowLayoutPanelPropiedadesProductos.Controls.Add(tb);

                            labelTituloPropiedades.Text = "Propiedades televisión:";

                        }
                    }
                    catch (Exception e)
                    {

                        Utils.MostrarErroresBd(e.Message);

                    }



            }
            else if (articuloSeleccionado.TipoArticuloID == 2)
            {
                try
                {

                    Utils.LimpiarErroresBd();

                    Memoria memoria = _neg.ObtenerMemoria(articuloSeleccionado.ArticuloID);

                    labelTituloPropiedades.Text = "Propiedades memoria:";
                }
                catch (Exception e)
                {

                    Utils.MostrarErroresBd(e.Message);

                }

                /*
            labelProp1.Text = "ID:";
            labelProp2.Text = "Panel:";
            labelProp3.Text = "";
            labelProp4.Text = "";
            labelProp5.Text = "";
            labelProp6.Text = "";
            labelProp7.Text = "";
            textBoxProp1.Text = memoria.MemoriaID;
            textBoxProp2.Text = memoria.Tipo;
            textBoxProp3.Visible = false;
            textBoxProp4.Visible = false;
            textBoxProp5.Visible = false;
            textBoxProp6.Visible = false;
            textBoxProp7.Visible = false;
            textBoxPrecio.Text = articuloSeleccionado.Pvp.ToString();*/
            }


            else if (articuloSeleccionado.TipoArticuloID == 3)
            {
                labelTituloPropiedades.Text = "Propiedades cámara:";

                // textBoxPrecio.Text = articuloSeleccionado.Pvp.ToString();
            }
            else if (articuloSeleccionado.TipoArticuloID == 4)
            {
                labelTituloPropiedades.Text = "Propiedades objetivo:";
                //  labelProp1.Text = articuloSeleccionado.Nombre;
                // textBoxPrecio.Text = articuloSeleccionado.Pvp.ToString();
            }
            else
            {
                labelTituloPropiedades.Text = "Propiedades producto genérico:";
                //  textBoxPrecio.Text = articuloSeleccionado.Pvp.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if(estado == "Consultar")
            {

            }else if(estado == "Seleccionar")
            {
                Utils.FormPedidosSeleccionado.SeleccionaProducto(articuloSeleccionado);
                this.Close();
            }
        }

       
    }

}