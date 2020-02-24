namespace Capa_Presentacion
{
    partial class Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChartPastel = new System.Windows.Forms.Label();
            this.labelChartGrafica = new System.Windows.Forms.Label();
            this.dateTimePickerEstadisticas = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.labelInfoEstadisticas = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTituloEstadisticas = new System.Windows.Forms.Label();
            this.panelEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.BackColor = System.Drawing.Color.White;
            this.panelEstadisticas.Controls.Add(this.chartPie);
            this.panelEstadisticas.Controls.Add(this.chartGrafico);
            this.panelEstadisticas.Controls.Add(this.labelChartPastel);
            this.panelEstadisticas.Controls.Add(this.labelChartGrafica);
            this.panelEstadisticas.Controls.Add(this.dateTimePickerEstadisticas);
            this.panelEstadisticas.Controls.Add(this.pictureBoxUsuario);
            this.panelEstadisticas.Controls.Add(this.labelInfoEstadisticas);
            this.panelEstadisticas.Controls.Add(this.labelNombre);
            this.panelEstadisticas.Controls.Add(this.labelTituloEstadisticas);
            this.panelEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstadisticas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.panelEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(984, 631);
            this.panelEstadisticas.TabIndex = 101;
            // 
            // chartPie
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPie.Legends.Add(legend1);
            this.chartPie.Location = new System.Drawing.Point(514, 259);
            this.chartPie.Name = "chartPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPie.Series.Add(series1);
            this.chartPie.Size = new System.Drawing.Size(436, 314);
            this.chartPie.TabIndex = 156;
            this.chartPie.Text = "chartPastel";
            // 
            // chartGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGrafico.ChartAreas.Add(chartArea2);
            this.chartGrafico.Location = new System.Drawing.Point(37, 259);
            this.chartGrafico.Name = "chartGrafico";
            this.chartGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Name = "Series1";
            this.chartGrafico.Series.Add(series2);
            this.chartGrafico.Size = new System.Drawing.Size(449, 314);
            this.chartGrafico.TabIndex = 155;
            this.chartGrafico.Text = "chartGrafica";
            // 
            // labelChartPastel
            // 
            this.labelChartPastel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartPastel.ForeColor = System.Drawing.Color.Black;
            this.labelChartPastel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelChartPastel.Location = new System.Drawing.Point(517, 214);
            this.labelChartPastel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChartPastel.Name = "labelChartPastel";
            this.labelChartPastel.Size = new System.Drawing.Size(309, 31);
            this.labelChartPastel.TabIndex = 154;
            this.labelChartPastel.Text = "Artículos vendidos";
            this.labelChartPastel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChartGrafica
            // 
            this.labelChartGrafica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartGrafica.ForeColor = System.Drawing.Color.Black;
            this.labelChartGrafica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelChartGrafica.Location = new System.Drawing.Point(37, 214);
            this.labelChartGrafica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChartGrafica.Name = "labelChartGrafica";
            this.labelChartGrafica.Size = new System.Drawing.Size(309, 31);
            this.labelChartGrafica.TabIndex = 153;
            this.labelChartGrafica.Text = "Pedidos diarios";
            this.labelChartGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerEstadisticas
            // 
            this.dateTimePickerEstadisticas.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dateTimePickerEstadisticas.CustomFormat = "";
            this.dateTimePickerEstadisticas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerEstadisticas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEstadisticas.Location = new System.Drawing.Point(167, 148);
            this.dateTimePickerEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEstadisticas.Name = "dateTimePickerEstadisticas";
            this.dateTimePickerEstadisticas.Size = new System.Drawing.Size(261, 29);
            this.dateTimePickerEstadisticas.TabIndex = 152;
            this.dateTimePickerEstadisticas.ValueChanged += new System.EventHandler(this.dateTimePickerEstadisticas_ValueChanged);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = global::Capa_Presentacion.Properties.Resources.statsiconblack;
            this.pictureBoxUsuario.InitialImage = null;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(39, 18);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUsuario.TabIndex = 151;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // labelInfoEstadisticas
            // 
            this.labelInfoEstadisticas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoEstadisticas.ForeColor = System.Drawing.Color.Black;
            this.labelInfoEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInfoEstadisticas.Location = new System.Drawing.Point(37, 78);
            this.labelInfoEstadisticas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoEstadisticas.Name = "labelInfoEstadisticas";
            this.labelInfoEstadisticas.Size = new System.Drawing.Size(559, 31);
            this.labelInfoEstadisticas.TabIndex = 142;
            this.labelInfoEstadisticas.Text = "Seleccióne mes y año para ver las distintas estadísticas";
            this.labelInfoEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombre.Location = new System.Drawing.Point(39, 149);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(259, 28);
            this.labelNombre.TabIndex = 108;
            this.labelNombre.Text = "Seleccione mes:";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTituloEstadisticas
            // 
            this.labelTituloEstadisticas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloEstadisticas.ForeColor = System.Drawing.Color.Black;
            this.labelTituloEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloEstadisticas.Location = new System.Drawing.Point(78, 18);
            this.labelTituloEstadisticas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloEstadisticas.Name = "labelTituloEstadisticas";
            this.labelTituloEstadisticas.Size = new System.Drawing.Size(226, 31);
            this.labelTituloEstadisticas.TabIndex = 103;
            this.labelTituloEstadisticas.Text = "ESTADÍSTICAS";
            this.labelTituloEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Estadisticas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.panelEstadisticas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Estadisticas";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelEstadisticas.ResumeLayout(false);
            this.panelEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEstadisticas;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTituloEstadisticas;
        private System.Windows.Forms.Label labelInfoEstadisticas;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePickerEstadisticas;
        private System.Windows.Forms.Label labelChartGrafica;
        private System.Windows.Forms.Label labelChartPastel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
    }
}