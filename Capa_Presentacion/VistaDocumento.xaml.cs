using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Controls;


namespace Capa_Presentacion
{
   
    // Lógica de interacción para VistaDocumento.xaml

    public partial class VistaDocumento : UserControl
    {
        //Variables

        private Negocio _neg;
        private Pedido pedido;

        //Constructor, recibe pedido desde vistapedidos

        public VistaDocumento(Pedido pedido)
        {

            InitializeComponent();

            _neg = new Negocio();

            this.pedido = pedido;

            CrearFactura();

        }

        //Método de creación de la factura del pedido actual

        private void CrearFactura()
        {
            Efactura factura = new Efactura();
            List<EArticulo> articulos = new List<EArticulo>();
            Usuario usu = _neg.BuscarUsuario(pedido.UsuarioID);
            Localidad loc = _neg.BuscarLocalidad(usu.PuebloID, usu.ProvinciaID);
            factura.NumeroFactura = pedido.PedidoID;
            factura.Direccion = usu.Calle + " " + usu.Codpos;
            factura.Localidad = loc.Nombre;
            factura.Dni = usu.Dni;
            factura.Fecha = pedido.Fecha;
            factura.Nombre = usu.Nombre + " " + usu.Apellidos;

            numPedido.Text = pedido.PedidoID.ToString();

            foreach (Linped l in pedido.LineasPedido)
            {
                EArticulo eart = new EArticulo();

                Articulo art = _neg.ObtenerArticulo(l.ArticuloID);
                eart.Fecha = factura.Fecha;
                eart.Cantidad = l.Cantidad;
                eart.Descripcion = art.Nombre;
                eart.ImporteUnitario = l.Importe;
                eart.Importe = l.Importe * l.Cantidad;
                eart.Total = eart.Importe * 1.21m;
                articulos.Add(eart);
            }

            factura.Detail = articulos;
            factura.Subtotal = pedido.ImporteTotal;
            factura.Iva = (Math.Round(factura.Subtotal * 0.21m, 2));
            factura.Total = Math.Round(factura.Subtotal + factura.Iva, 2);

            dockPanelFactura.DataContext = factura;
            listViewFactura.ItemsSource = factura.Detail;

            tbIVA.Text = "21%";
            tbBase.Text = factura.Subtotal.ToString("######.####"+"€");
            tbTotalIVA.Text = factura.Iva.ToString("######.####"+"€");
            tbTotalFactura.Text = factura.Total.ToString("######.####"+"€");
        }
    }
}
