using Capa_Entidades;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Capa_Presentacion
{
    // Integración lógica para Usuarios

    public partial class VistaPedidos : UserControl
    {
        //Variables

        private Negocio _neg;
        private List<Pedido> pedidos;
        private List<Linped> linpeds;
        private ObservableCollection<ItemPedido> itemsPedido;
        private ObservableCollection<ItemLinPed> itemsLineaPedido;
        private Usuario usuarioSeleccionado;
        private Pedido pedidoSeleccionado;
        private Articulo articuloSeleccionado;
        private int pedidoId;
        private string estado;
        private CollectionView view;

        //Constructor

        public VistaPedidos(string estado)

        {
            InitializeComponent();

            _neg = new Negocio();

            pedidos = new List<Pedido>();
            itemsPedido = new ObservableCollection<ItemPedido>();
            itemsLineaPedido = new ObservableCollection<ItemLinPed>();

            datePickerFechaPedido.SelectedDate = DateTime.Now.Date;
            upDown.Value = 0;

            this.estado = estado;

            ConfigurarVentanas();
        }

        //Evento disparado al cargar la vista

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            linpeds = new List<Linped>();
            itemsLineaPedido = new ObservableCollection<ItemLinPed>();
            lvDatosArticulos.ItemsSource = itemsLineaPedido;
           

            try
            {
                pedidoId = _neg.PedidoMasAlto() + 1;
            }
            catch (Exception ex)
            {
                VistaPrincipal.Status.Message = ex.Message;
            }


            if (estado == "Modificar" || estado == "Seleccionar")
            {
                itemsPedido = new ObservableCollection<ItemPedido>();

                try
                {
                    pedidos = new List<Pedido>(_neg.ListarPedidos());

                    List<Usuario> listaUsuarios = _neg.ListarUsuarios();

                    foreach (Pedido pedido in pedidos)
                    {
                        ItemPedido itemPedido = new ItemPedido();
                        itemPedido.NumPedido = pedido.PedidoID;

                        Usuario aux = new Usuario();

                        aux = listaUsuarios.Where(u => u.UsuarioId == pedido.UsuarioID).First();
                      
                        itemPedido.NombreUsuario = aux.Nombre;
                        itemPedido.ApellidosUsuario = aux.Apellidos;
                        itemPedido.FechaPedido = pedido.Fecha.ToString();

                        itemsPedido.Add(itemPedido);
                    }
                    
                }
                catch (Exception ex)
                {
                    VistaPrincipal.Status.Message = ex.Message;
                }

                listViewPedidos.ItemsSource = itemsPedido;

                view = (CollectionView)CollectionViewSource.GetDefaultView(listViewPedidos.ItemsSource);

                view.Filter = FiltroPedidos;
            }
        }

        //Método de configuración de la vista

        private void ConfigurarVentanas()
        {
            if (estado == "Nuevo")
            {
                botonPedidos.Content = "Realizar pedido";

                gridPrincipal.RowDefinitions.ElementAt(2).Height = new GridLength(0, GridUnitType.Star);
                gridPrincipal.RowDefinitions.ElementAt(1).Height = new GridLength(0, GridUnitType.Star);

            }
            else if (estado == "Modificar")
            {
                botonPedidos.Content = "Modificar pedido";

                datePickerFechaPedido.Visibility = Visibility.Collapsed;
                botonUsuario.Visibility = Visibility.Collapsed;
                labelFecha.Visibility = Visibility.Collapsed;
                datePickerFechaPedido.Visibility = Visibility.Collapsed;

                gridPrincipal.RowDefinitions.ElementAt(0).Height = new GridLength(0, GridUnitType.Star);
            }
            else if (estado == "Seleccionar")
            {
                botonPedidos.Content = "Ver factura";

                gridPrincipal.RowDefinitions.ElementAt(0).Height = new GridLength(0, GridUnitType.Star);
                gridPrincipal.RowDefinitions.ElementAt(3).Height = new GridLength(0, GridUnitType.Star);
                gridPrincipal.RowDefinitions.ElementAt(4).Height = new GridLength(0, GridUnitType.Star);
                gridPrincipal.RowDefinitions.ElementAt(5).Height = new GridLength(0, GridUnitType.Star);
                gridPrincipal.RowDefinitions.ElementAt(6).Height = new GridLength(0, GridUnitType.Star);
            }
        }

        //Método de selección de usuario

        public void SeleccionarUsuario(Usuario usu)
        {
            usuarioSeleccionado = usu;

            nombreUser.Content = usuarioSeleccionado.Nombre + ", " + usuarioSeleccionado.Apellidos;
        }

        //Método de selección de pedido

        public void SeleccionarPedido(Pedido ped)
        {
            Articulo art = null;

            itemsLineaPedido.Clear();
            linpeds.Clear();

            pedidoSeleccionado = ped;

            foreach (Linped l in ped.LineasPedido)
            {
                try
                {
                    art = _neg.ObtenerArticulo(l.ArticuloID);
                }
                catch (Exception ex)
                {
                    VistaPrincipal.Status.Message = ex.Message;
                }


                ItemLinPed item = new ItemLinPed()
                {
                    Nombre = art.Nombre,
                    Marca = art.MarcaID,
                    Linea = l.Linea,
                    Cantidad = l.Cantidad,
                    Importe = l.Importe
                };

                linpeds.Add(l);
                itemsLineaPedido.Add(item);
            }
        }

        //Método de selección de artículo

        public void SeleccionarArticulo(Articulo art)
        {
            articuloSeleccionado = art;

            labelProductoSeleccionado.Content = art.ToString();
        }

        //Método de reseteo de campos

        public void ReseteaCampos()
        {
            usuarioSeleccionado = null;

            itemsLineaPedido = new ObservableCollection<ItemLinPed>();
            linpeds = new List<Linped>();

        }

        //Filtrado de pedidos

        private bool FiltroPedidos(Object item)
        {
            if (string.IsNullOrEmpty(buscadorPedidos.Text))
            {
                return true;
            }
            else
            {
                ItemPedido itemPed = (ItemPedido)item;
                bool result = (itemPed.NombreUsuario.IndexOf(buscadorPedidos.Text, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (itemPed.FechaPedido.IndexOf(buscadorPedidos.Text, StringComparison.OrdinalIgnoreCase) >= 0);

                return result;
            }
        }

        private void BotonUsuario_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Title = "Seleccionar usuario";
            window.Content = new VistaUsuarios("Seleccionar");

            Utils.ContextoPedidos = this;
            window.ShowDialog();
        }

        //Evento de acción del botón de selección de artículo

        private void BotonArticulo_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Title = "Seleccionar artículo";
            window.Content = new VistaProductos("Seleccionar");

            Utils.ContextoPedidos = this;
            window.ShowDialog();
        }

        //Evento de botón de pedidos (cambia en función del modo)

        private void BotonPedidos_Click(object sender, RoutedEventArgs e)
        {
                if (estado == "Nuevo")
                {
                    try
                    {
                        if (_neg.AnyadirPedido(pedidoId, usuarioSeleccionado.UsuarioId, datePickerFechaPedido.DisplayDate))
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
                    catch (Exception ex)
                    {
                        VistaPrincipal.Status.Message = ex.Message;
                    }
                }
                else if (estado == "Modificar")
                {
                    try
                    {
                        if (_neg.ModificarPed(pedidoSeleccionado))
                        {
                            if (linpeds.Count > 0)
                            {
                                foreach (Linped l in linpeds)
                                {
                                    _neg.ModificarLinPed(l);
                                }
                            }

                            MessageBox.Show("Pedido " + pedidoId + " modificado correctamente");

                            //ReseteaCampos();
                            Pedido ped = pedidos.FirstOrDefault(p => p.PedidoID == pedidoSeleccionado.PedidoID);
                        if (ped != null)
                        {
                            ped = pedidoSeleccionado;
                            view.Refresh();
                            SeleccionarPedido(ped);
                        }
                        }
                        else
                        {
                            MessageBox.Show("Pedido " + pedidoId + " no ha sido modificado");
                        }
                    }
                    catch (Exception ex)
                    {
                        VistaPrincipal.Status.Message = ex.Message;
                    }
                }
                else if (estado == "Seleccionar")
                {

                    VistaDocumento vistaDocumento = new VistaDocumento(pedidoSeleccionado);

                    gridPrincipal.RowDefinitions.Clear();
                    gridPrincipal.Children.Clear();
                    gridPrincipal.Children.Add(vistaDocumento);
                }
        }

        //Botón de añadir linea de pedido y sus validaciones

        private void BotonAnyadirLinped_Click(object sender, RoutedEventArgs e)
        {
            if (upDown.Value <= 0)
            {
                MessageBox.Show("Seleccione una cantidad mayor a 0.");
            }
            else if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario.");

            }
            else if (articuloSeleccionado == null)
            {
                MessageBox.Show("Seleccione un artículo,");
            }
            else
            {
                if (articuloSeleccionado.Pvp == null)
                {
                    Utils.MostrarDialogError("Error", "Articulo sin precio");
                }
                else
                {
                    Linped linped = new Linped(articuloSeleccionado.ArticuloID, pedidoId, linpeds.Count + 1, (int)upDown.Value, articuloSeleccionado.Pvp.Value);

                    linpeds.Add(linped);

                    ItemLinPed item = new ItemLinPed()
                    {
                        Nombre = articuloSeleccionado.Nombre,
                        Marca = articuloSeleccionado.MarcaID,
                        Linea = linped.Linea,
                        Cantidad = linped.Cantidad,
                        Importe = linped.Importe
                    };

                    itemsLineaPedido.Add(item);
                    Totales totales = new Totales();

                    try
                    {
                        totales = _neg.CalcularTotalPedido(linpeds);
                    }
                    catch (Exception exc)
                    {
                        VistaPrincipal.Status.Message = exc.Message;
                    }

                    textBoxTotalSinIVA.Text = totales.TotalSinIVA.ToString();
                    textBoxTotal.Text = totales.Total.ToString();
                    textBoxIVA.Text = totales.IVA.ToString();
                }
            }
        }

        //Evento de cambio de objeto seleccionado en el listview de pedidos

        private void ListViewPedidos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Pedido ped = _neg.ObtenerPedido(((ItemPedido)listViewPedidos.SelectedItem).NumPedido);
                usuarioSeleccionado = _neg.BuscarUsuario(ped.UsuarioID);
                pedidoSeleccionado = ped;
                SeleccionarPedido(ped);
            }
            catch (Exception ex)
            {
                VistaPrincipal.Status.Message = ex.Message;
            }
           

        }

        //Evento que refresca la view asociada al listview de pedidos 

        private void BuscadorPedidos_TextChanged(object sender, TextChangedEventArgs e)
        {
                CollectionViewSource.GetDefaultView(listViewPedidos.ItemsSource).Refresh();
        }
    }
}