using Capa_Entidades;
using Capa_Negocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Capa_Presentacion
{

   
    public partial class FacturaRpt : Form
    {
        public List<Efactura> Invoice = new List<Efactura>();
        public List<EArticulo> Detail = new List<EArticulo>();
        private TiendaOnline _neg;

        public string Titulo { get; set; }
        public string Empresa { get; set; }
        public FacturaRpt()
        {
            
            InitializeComponent();

          
        }

      

        private void FacturaRpt_Load(object sender, EventArgs e)
        {
            //Limpiemos el DataSource del informe
            reportViewer1.LocalReport.DataSources.Clear();
            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("parameterTitulo", Titulo);
            parameters[1] = new ReportParameter("parameterEmpresa", Empresa);

            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Encabezado", Invoice));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detail));
            //
            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);
            //
            //Hagamos un refresh al reportViewer
            //
            this.reportViewer1.RefreshReport();
           
        }

        private void FacturaRpt_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
