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
using System.Windows.Forms.DataVisualization.Charting;

//<author> Héctor Granja <author>

namespace Capa_Presentacion
{
    public partial class Estadisticas : Form
    {
        //Variables
        private TiendaOnline _neg;
       


        public Estadisticas()
        {
            InitializeComponent();

            //Inicializo la conexión con la capa Negocio
            _neg = new TiendaOnline();

            dateTimePickerEstadisticas.CustomFormat = "MMMM yyyy";
            dateTimePickerEstadisticas.ShowUpDown = true;


        }

        private void dateTimePickerEstadisticas_ValueChanged(object sender, EventArgs e)
        {
  
            List<Pedido> listPedMensual = _neg.PedidosMensuales(dateTimePickerEstadisticas.Value);

            int numeroDePedidosDia,numeroObjetivosMes,numeroTvsMes,numeroCamarasMes,numeroMemoriasMes;

            int diasMesSeleccionado = DateTime.DaysInMonth(dateTimePickerEstadisticas.Value.Year,dateTimePickerEstadisticas.Value.Month);
            
            //Grafico

            chartGrafico.Series[0].Points.Clear();

            for (int i = 1; i <= diasMesSeleccionado; i++)
            {
                numeroDePedidosDia = listPedMensual.Where(p => p.Fecha.Day == i).Count();

                chartGrafico.Series[0].Points.AddXY(i.ToString(), numeroDePedidosDia.ToString());
            }

            //Pastel

            chartPie.Series[0].Points.Clear();



  

/*
            chartPie.Series[0].Points.AddXY("Tv", numeroTvsMes.ToString());
            chartPie.Series[0].Points.AddXY("Cámara", numeroCamarasMes.ToString());
            chartPie.Series[0].Points.AddXY("Memoria", numeroMemoriasMes.ToString());
            chartPie.Series[0].Points.AddXY("Objetivo", numeroObjetivosMes.ToString());
            */

        }
    }
    
}

