using Capa_Negocio;
using Capa_Entidades;
using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows;

namespace Capa_Presentacion
{

    // Integración lógica para Productos
   
    public partial class VistaProductos : UserControl
    {
        //Variables

        private Negocio _neg;
        private string estado;
        private ObservableCollection<ArticulosPorTipo> listaTipos;

        //Constructor

        public VistaProductos(string estado)
        {
            InitializeComponent();

            _neg = new Negocio();

           
            if (estado == "Consultar")
            {
                botonProductos.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (estado == "Seleccionar")
            {
                botonProductos.Visibility = System.Windows.Visibility.Visible;
            }

            this.estado = estado;
        }

        //Evento ocurrido al cargar la vista

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                listaTipos = _neg.ListarArticulosPorTipo();

                dockPanel.DataContext = listaTipos;
            }
            catch (Exception ex)
            {
                VistaPrincipal.Status.Message = ex.Message;
            }
        }

        //Evento de cambio del listbox de productos

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LimpiarCaracteristicas();

            ListBox lb = (ListBox)sender;
            Articulo art = (Articulo)lb.SelectedItem;
            int tipo = art.TipoArticuloID.Value;
            switch (tipo){

                case 1:
                    RellenaTv((Tv)art);
                    break;
                case 2:
                    RellenaMemoria((Memoria)art);
                    break;
                case 3:
                    RellenaCamara((Camara)art);
                    break;
                case 4:
                    RellenaObjetivo((Objetivo)art);
                    break;
            }
        }

        //Método de reseteo de características

        private void LimpiarCaracteristicas()
        {
            labelCaracteristica1.Content = "";
            labelCaracteristica2.Content = "";
            labelCaracteristica3.Content = "";
            labelCaracteristica4.Content = "";
            labelCaracteristica5.Content = "";
            labelCaracteristica6.Content = "";
            caracteristica1.Text = "";
            caracteristica2.Text = "";
            caracteristica3.Text = "";
            caracteristica4.Text = "";
            caracteristica5.Text = "";
            caracteristica6.Text = "";
        }

        //Método de rellenado de características de un objetivo

        private void RellenaObjetivo(Objetivo obj)
        {
            labelCaracteristica1.Content = "Especiales:";
            caracteristica1.Text = obj.Especiales;
            labelCaracteristica2.Content = "Apertura:";
            caracteristica2.Text = obj.Apertura;
            labelCaracteristica3.Content = "Focal:";
            caracteristica3.Text = obj.Focal;
            labelCaracteristica4.Content = "Tipo:";
            caracteristica4.Text = obj.Tipo;
            labelCaracteristica5.Content = "Montura:";
            caracteristica5.Text = obj.Montura;
        }

        //Método de rellenado de características de una memoria

        private void RellenaMemoria(Memoria mem)
        {
            labelCaracteristica1.Content = "Tipo:";
            caracteristica1.Text = mem.Tipo;
        }

        //Método de rellenado de características de una cámara

        private void RellenaCamara(Camara cam)
        {
            labelCaracteristica1.Content = "Pantalla:";
            caracteristica1.Text = cam.Pantalla;
            labelCaracteristica2.Content = "Objetivo:";
            caracteristica2.Text = cam.Objetivo;
            labelCaracteristica3.Content = "Resolucion:";
            caracteristica3.Text = cam.Resolucion;
            labelCaracteristica4.Content = "Sensor:";
            caracteristica4.Text = cam.Sensor;
            labelCaracteristica5.Content = "Tipo:";
            caracteristica5.Text = cam.Tipo;
            labelCaracteristica6.Content = "Zoom:";
            caracteristica6.Text = cam.Zoom;
        }

        //Método de rellenado de características de una tv

        private void RellenaTv(Tv tv)
        {
            labelCaracteristica1.Content = "Pantalla:";
            caracteristica1.Text = tv.Pantalla.ToString();
            labelCaracteristica2.Content = "Tdt:";
            caracteristica2.Text = tv.Tdt.ToString();
            labelCaracteristica3.Content = "Resolucion:";
            caracteristica3.Text = tv.Resolucion;
            labelCaracteristica4.Content = "Panel:";
            caracteristica4.Text = tv.Panel;
            labelCaracteristica5.Content = "Hd:";
            caracteristica5.Text = tv.Hdreadyfullhd;
        }

      
        //Evento de acción del botón de selección de producto
        private void BotonProductos_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(estado == "Seleccionar")
            {
                Articulo art = (Articulo)listBoxArticulos.SelectedItem;

                Utils.ContextoPedidos.SeleccionarArticulo(art);

                Window parentWindow = Window.GetWindow((DependencyObject)sender);
                if (parentWindow != null)
                {
                    parentWindow.Close();
                }
            }
        } 
    }
}
