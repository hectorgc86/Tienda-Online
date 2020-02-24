namespace Capa_Presentacion
{
    partial class ProductosFormulario
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
            this.panelUsuariosBuscador = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPropiedadesProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTituloPropiedades = new System.Windows.Forms.Label();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.labelProductos = new System.Windows.Forms.Label();
            this.labelBusquedaNombre = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.textBoxBusquedaNombre = new System.Windows.Forms.TextBox();
            this.comboBoxOpcionFiltrar = new System.Windows.Forms.ComboBox();
            this.labelFiltrarPor = new System.Windows.Forms.Label();
            this.labelInfoProductos = new System.Windows.Forms.Label();
            this.labelTituloProductos = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelUsuariosBuscador.SuspendLayout();
            this.flowLayoutPanelPropiedadesProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsuariosBuscador
            // 
            this.panelUsuariosBuscador.BackColor = System.Drawing.Color.White;
            this.panelUsuariosBuscador.Controls.Add(this.flowLayoutPanelPropiedadesProductos);
            this.panelUsuariosBuscador.Controls.Add(this.pictureBoxProducto);
            this.panelUsuariosBuscador.Controls.Add(this.labelProductos);
            this.panelUsuariosBuscador.Controls.Add(this.labelBusquedaNombre);
            this.panelUsuariosBuscador.Controls.Add(this.dataGridViewProductos);
            this.panelUsuariosBuscador.Controls.Add(this.textBoxBusquedaNombre);
            this.panelUsuariosBuscador.Controls.Add(this.comboBoxOpcionFiltrar);
            this.panelUsuariosBuscador.Controls.Add(this.labelFiltrarPor);
            this.panelUsuariosBuscador.Controls.Add(this.labelInfoProductos);
            this.panelUsuariosBuscador.Controls.Add(this.labelTituloProductos);
            this.panelUsuariosBuscador.Controls.Add(this.btnProductos);
            this.panelUsuariosBuscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuariosBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelUsuariosBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.panelUsuariosBuscador.Name = "panelUsuariosBuscador";
            this.panelUsuariosBuscador.Size = new System.Drawing.Size(984, 631);
            this.panelUsuariosBuscador.TabIndex = 101;
            // 
            // flowLayoutPanelPropiedadesProductos
            // 
            this.flowLayoutPanelPropiedadesProductos.Controls.Add(this.labelTituloPropiedades);
            this.flowLayoutPanelPropiedadesProductos.Location = new System.Drawing.Point(576, 243);
            this.flowLayoutPanelPropiedadesProductos.Name = "flowLayoutPanelPropiedadesProductos";
            this.flowLayoutPanelPropiedadesProductos.Size = new System.Drawing.Size(391, 308);
            this.flowLayoutPanelPropiedadesProductos.TabIndex = 155;
            // 
            // labelTituloPropiedades
            // 
            this.labelTituloPropiedades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPropiedades.ForeColor = System.Drawing.Color.Black;
            this.labelTituloPropiedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloPropiedades.Location = new System.Drawing.Point(2, 0);
            this.labelTituloPropiedades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloPropiedades.Name = "labelTituloPropiedades";
            this.labelTituloPropiedades.Size = new System.Drawing.Size(389, 48);
            this.labelTituloPropiedades.TabIndex = 170;
            this.labelTituloPropiedades.Text = "Propiedades";
            this.labelTituloPropiedades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.Image = global::Capa_Presentacion.Properties.Resources.producticonblack;
            this.pictureBoxProducto.InitialImage = null;
            this.pictureBoxProducto.Location = new System.Drawing.Point(39, 18);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProducto.TabIndex = 149;
            this.pictureBoxProducto.TabStop = false;
            // 
            // labelProductos
            // 
            this.labelProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.Color.Black;
            this.labelProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProductos.Location = new System.Drawing.Point(39, 243);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(309, 31);
            this.labelProductos.TabIndex = 148;
            this.labelProductos.Text = "Lista de productos";
            this.labelProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBusquedaNombre
            // 
            this.labelBusquedaNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusquedaNombre.ForeColor = System.Drawing.Color.Black;
            this.labelBusquedaNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBusquedaNombre.Location = new System.Drawing.Point(272, 149);
            this.labelBusquedaNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusquedaNombre.Name = "labelBusquedaNombre";
            this.labelBusquedaNombre.Size = new System.Drawing.Size(259, 28);
            this.labelBusquedaNombre.TabIndex = 147;
            this.labelBusquedaNombre.Text = "Búsqueda por nombre:";
            this.labelBusquedaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(39, 288);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowTemplate.Height = 33;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(516, 263);
            this.dataGridViewProductos.TabIndex = 146;
            this.dataGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellClick);
            // 
            // textBoxBusquedaNombre
            // 
            this.textBoxBusquedaNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxBusquedaNombre.ForeColor = System.Drawing.Color.Black;
            this.textBoxBusquedaNombre.Location = new System.Drawing.Point(276, 179);
            this.textBoxBusquedaNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBusquedaNombre.Name = "textBoxBusquedaNombre";
            this.textBoxBusquedaNombre.Size = new System.Drawing.Size(279, 29);
            this.textBoxBusquedaNombre.TabIndex = 145;
            this.textBoxBusquedaNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBusqueda_KeyUp);
            // 
            // comboBoxOpcionFiltrar
            // 
            this.comboBoxOpcionFiltrar.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre y apellidos",
            "DNI",
            "Email"});
            this.comboBoxOpcionFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcionFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxOpcionFiltrar.ForeColor = System.Drawing.Color.Black;
            this.comboBoxOpcionFiltrar.FormattingEnabled = true;
            this.comboBoxOpcionFiltrar.Location = new System.Drawing.Point(39, 179);
            this.comboBoxOpcionFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOpcionFiltrar.Name = "comboBoxOpcionFiltrar";
            this.comboBoxOpcionFiltrar.Size = new System.Drawing.Size(190, 29);
            this.comboBoxOpcionFiltrar.TabIndex = 144;
            this.comboBoxOpcionFiltrar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcionFiltrado_SelectedIndexChanged);
            // 
            // labelFiltrarPor
            // 
            this.labelFiltrarPor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrarPor.ForeColor = System.Drawing.Color.Black;
            this.labelFiltrarPor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFiltrarPor.Location = new System.Drawing.Point(39, 149);
            this.labelFiltrarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiltrarPor.Name = "labelFiltrarPor";
            this.labelFiltrarPor.Size = new System.Drawing.Size(259, 28);
            this.labelFiltrarPor.TabIndex = 143;
            this.labelFiltrarPor.Text = "Búsqueda por tipo: ";
            this.labelFiltrarPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoProductos
            // 
            this.labelInfoProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoProductos.ForeColor = System.Drawing.Color.Black;
            this.labelInfoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInfoProductos.Location = new System.Drawing.Point(37, 78);
            this.labelInfoProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoProductos.Name = "labelInfoProductos";
            this.labelInfoProductos.Size = new System.Drawing.Size(902, 31);
            this.labelInfoProductos.TabIndex = 142;
            this.labelInfoProductos.Text = "Seleccione un filtro de búsqueda o ingrese nombre de producto para ver sus datos";
            this.labelInfoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTituloProductos
            // 
            this.labelTituloProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTituloProductos.ForeColor = System.Drawing.Color.Black;
            this.labelTituloProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloProductos.Location = new System.Drawing.Point(78, 18);
            this.labelTituloProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloProductos.Name = "labelTituloProductos";
            this.labelTituloProductos.Size = new System.Drawing.Size(296, 31);
            this.labelTituloProductos.TabIndex = 103;
            this.labelTituloProductos.Text = "TITULO";
            this.labelTituloProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Location = new System.Drawing.Point(837, 578);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(98, 27);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Modificar";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // ProductosFormulario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.panelUsuariosBuscador);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductosFormulario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelUsuariosBuscador.ResumeLayout(false);
            this.panelUsuariosBuscador.PerformLayout();
            this.flowLayoutPanelPropiedadesProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUsuariosBuscador;
        private System.Windows.Forms.Label labelTituloProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label labelInfoProductos;
        private System.Windows.Forms.Label labelFiltrarPor;
        private System.Windows.Forms.ComboBox comboBoxOpcionFiltrar;
        private System.Windows.Forms.Label labelBusquedaNombre;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textBoxBusquedaNombre;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPropiedadesProductos;
        private System.Windows.Forms.Label labelTituloPropiedades;
    }
}