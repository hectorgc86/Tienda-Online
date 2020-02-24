using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Capa_Entidades;
using Capa_Negocio;
using LiveCharts;
using LiveCharts.Wpf;

namespace Capa_Presentacion
{
 
    // Lógica de interacción para VistaEstadisticas.xaml

    public partial class VistaEstadisticas : UserControl
    {
       
        // Variables
 
        private Negocio _neg;
        private List<Articulo> listaArticulos;
        private List<Pedido> listaPedidosMensuales;
        private List<string> listaPedidosDiarios = new List<string>();
        private string[] cadenaDiasMes;

        // Constructor

        public VistaEstadisticas()
        {

            InitializeComponent();

            _neg = new Negocio();

        }

        // Evento de carga de la vista

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                listaArticulos = _neg.ListarArticulos();
            }
            catch (Exception ex)
            {
                VistaPrincipal.Status.Message = ex.Message;
            }
            datePickerFecha.SelectedDate = DateTime.Today;
            ActualizarDatosColumnChart();
            ActualizarDatosPieChart();
        }

        // Evento ejecutado al cambiar valor del datepicker

        private void DatePickerFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ActualizarDatosColumnChart();
            ActualizarDatosPieChart();
        }

        // Método de recarga de datos del gráfico de columnas

        private void ActualizarDatosColumnChart()
        {
            try
            {
                listaPedidosMensuales = _neg.PedidosMensuales(datePickerFecha.DisplayDate);
            }
            catch (Exception e){

                VistaPrincipal.Status.Message = e.Message;
            }

            int diasMesSeleccionado = DateTime.DaysInMonth(datePickerFecha.DisplayDate.Year, datePickerFecha.DisplayDate.Month);
        
            cadenaDiasMes = new string[diasMesSeleccionado];

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Pedidos",
                    Values = new ChartValues<int>{ }
                }
            };

            for (int i = 1; i <= diasMesSeleccionado; i++)
            {
                cadenaDiasMes[i - 1] = i.ToString();
                SeriesCollection[0].Values.Add(listaPedidosMensuales.Where(p => p.Fecha.Day == i).Count());
            }

            Labels = cadenaDiasMes;

            Formatter = value => value.ToString("N");
            graficaBarras.DataContext = SeriesCollection;
        }

        // Método de recarga de datos del gráfico de pastel

        private void ActualizarDatosPieChart()
        {
            Dictionary<string, int> articulosMensuales = new Dictionary<string, int>();
            try
            {
                articulosMensuales = _neg.ArticulosMensuales(listaPedidosMensuales);
            }
            catch (Exception e)
            {
                VistaPrincipal.Status.Message = e.Message;
            }
            porcionTelevisores.Values = new ChartValues<int> { articulosMensuales["TVs"] };
            porcionCamaras.Values = new ChartValues<int> { articulosMensuales["Camaras"] };
            porcionObjetivos.Values = new ChartValues<int> { articulosMensuales["Objetivos"] };
            porcionMemorias.Values = new ChartValues<int> { articulosMensuales["Memorias"] };


            PointLabel = chartPoint =>
                    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }

        //Métodos de apoyo a las gráficas

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        public Func<ChartPoint, string> PointLabel { get; set; }

    }
}