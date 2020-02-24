namespace Capa_Presentacion
{
    partial class UsuariosBuscador
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
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.comboBoxOpcionBusqueda = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.labelInfoUsuariosBuscador = new System.Windows.Forms.Label();
            this.labelTituloUsuariosBuscador = new System.Windows.Forms.Label();
            this.btnUsuariosBuscador = new System.Windows.Forms.Button();
            this.panelUsuariosBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsuariosBuscador
            // 
            this.panelUsuariosBuscador.BackColor = System.Drawing.Color.White;
            this.panelUsuariosBuscador.Controls.Add(this.pictureBoxUsuario);
            this.panelUsuariosBuscador.Controls.Add(this.labelUsuarios);
            this.panelUsuariosBuscador.Controls.Add(this.labelBusqueda);
            this.panelUsuariosBuscador.Controls.Add(this.dataGridViewUsuarios);
            this.panelUsuariosBuscador.Controls.Add(this.textBoxBusqueda);
            this.panelUsuariosBuscador.Controls.Add(this.comboBoxOpcionBusqueda);
            this.panelUsuariosBuscador.Controls.Add(this.labelBuscarPor);
            this.panelUsuariosBuscador.Controls.Add(this.labelInfoUsuariosBuscador);
            this.panelUsuariosBuscador.Controls.Add(this.labelTituloUsuariosBuscador);
            this.panelUsuariosBuscador.Controls.Add(this.btnUsuariosBuscador);
            this.panelUsuariosBuscador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsuariosBuscador.Location = new System.Drawing.Point(0, 0);
            this.panelUsuariosBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.panelUsuariosBuscador.Name = "panelUsuariosBuscador";
            this.panelUsuariosBuscador.Size = new System.Drawing.Size(984, 631);
            this.panelUsuariosBuscador.TabIndex = 101;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = global::Capa_Presentacion.Properties.Resources.usericonblack;
            this.pictureBoxUsuario.InitialImage = null;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(39, 18);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUsuario.TabIndex = 150;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsuarios.Location = new System.Drawing.Point(39, 243);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(309, 31);
            this.labelUsuarios.TabIndex = 149;
            this.labelUsuarios.Text = "Lista de usuarios";
            this.labelUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusqueda.ForeColor = System.Drawing.Color.Black;
            this.labelBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBusqueda.Location = new System.Drawing.Point(348, 149);
            this.labelBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(259, 28);
            this.labelBusqueda.TabIndex = 147;
            this.labelBusqueda.Text = "Info Busqueda";
            this.labelBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(39, 288);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsuarios.MultiSelect = false;
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            this.dataGridViewUsuarios.RowTemplate.Height = 33;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(900, 263);
            this.dataGridViewUsuarios.TabIndex = 146;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(352, 179);
            this.textBoxBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(240, 29);
            this.textBoxBusqueda.TabIndex = 145;
            this.textBoxBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBusqueda_KeyUp);
            // 
            // comboBoxOpcionBusqueda
            // 
            this.comboBoxOpcionBusqueda.AutoCompleteCustomSource.AddRange(new string[] {
            "Nombre y apellidos",
            "DNI",
            "Email"});
            this.comboBoxOpcionBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcionBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxOpcionBusqueda.FormattingEnabled = true;
            this.comboBoxOpcionBusqueda.Location = new System.Drawing.Point(39, 179);
            this.comboBoxOpcionBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOpcionBusqueda.Name = "comboBoxOpcionBusqueda";
            this.comboBoxOpcionBusqueda.Size = new System.Drawing.Size(261, 29);
            this.comboBoxOpcionBusqueda.TabIndex = 144;
            this.comboBoxOpcionBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcionBusqueda_SelectedIndexChanged);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.Black;
            this.labelBuscarPor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBuscarPor.Location = new System.Drawing.Point(39, 149);
            this.labelBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(259, 28);
            this.labelBuscarPor.TabIndex = 143;
            this.labelBuscarPor.Text = "Buscar por: ";
            this.labelBuscarPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoUsuariosBuscador
            // 
            this.labelInfoUsuariosBuscador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoUsuariosBuscador.ForeColor = System.Drawing.Color.Black;
            this.labelInfoUsuariosBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInfoUsuariosBuscador.Location = new System.Drawing.Point(37, 78);
            this.labelInfoUsuariosBuscador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoUsuariosBuscador.Name = "labelInfoUsuariosBuscador";
            this.labelInfoUsuariosBuscador.Size = new System.Drawing.Size(902, 31);
            this.labelInfoUsuariosBuscador.TabIndex = 142;
            this.labelInfoUsuariosBuscador.Text = "Info Modo";
            this.labelInfoUsuariosBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTituloUsuariosBuscador
            // 
            this.labelTituloUsuariosBuscador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloUsuariosBuscador.ForeColor = System.Drawing.Color.Black;
            this.labelTituloUsuariosBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloUsuariosBuscador.Location = new System.Drawing.Point(78, 18);
            this.labelTituloUsuariosBuscador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloUsuariosBuscador.Name = "labelTituloUsuariosBuscador";
            this.labelTituloUsuariosBuscador.Size = new System.Drawing.Size(296, 31);
            this.labelTituloUsuariosBuscador.TabIndex = 103;
            this.labelTituloUsuariosBuscador.Text = "TITULO";
            this.labelTituloUsuariosBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUsuariosBuscador
            // 
            this.btnUsuariosBuscador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuariosBuscador.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnUsuariosBuscador.FlatAppearance.BorderSize = 0;
            this.btnUsuariosBuscador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosBuscador.ForeColor = System.Drawing.Color.Black;
            this.btnUsuariosBuscador.Location = new System.Drawing.Point(841, 576);
            this.btnUsuariosBuscador.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuariosBuscador.Name = "btnUsuariosBuscador";
            this.btnUsuariosBuscador.Size = new System.Drawing.Size(98, 27);
            this.btnUsuariosBuscador.TabIndex = 3;
            this.btnUsuariosBuscador.Text = "Boton";
            this.btnUsuariosBuscador.UseVisualStyleBackColor = true;
            this.btnUsuariosBuscador.Click += new System.EventHandler(this.btnUsuariosBuscador_Click);
            // 
            // UsuariosBuscador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.panelUsuariosBuscador);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuariosBuscador";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelUsuariosBuscador.ResumeLayout(false);
            this.panelUsuariosBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUsuariosBuscador;
        private System.Windows.Forms.Label labelTituloUsuariosBuscador;
        private System.Windows.Forms.Button btnUsuariosBuscador;
        private System.Windows.Forms.Label labelInfoUsuariosBuscador;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.ComboBox comboBoxOpcionBusqueda;
        private System.Windows.Forms.Label labelBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
    }
}