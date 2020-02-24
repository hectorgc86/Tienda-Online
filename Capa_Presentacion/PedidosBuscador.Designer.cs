namespace Capa_Presentacion
{
    partial class PedidosBuscador
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
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.labelInfoPedidosBuscador = new System.Windows.Forms.Label();
            this.labelTituloPedidosBuscador = new System.Windows.Forms.Label();
            this.btnUsuariosBuscador = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.labelFechaPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.InitialImage = null;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(61, 20);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUsuario.TabIndex = 160;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsuarios.Location = new System.Drawing.Point(61, 245);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(309, 31);
            this.labelUsuarios.TabIndex = 159;
            this.labelUsuarios.Text = "Lista de pedidos";
            this.labelUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsuarios.Click += new System.EventHandler(this.labelUsuarios_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(61, 290);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsuarios.MultiSelect = false;
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            this.dataGridViewUsuarios.RowTemplate.Height = 33;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(900, 263);
            this.dataGridViewUsuarios.TabIndex = 157;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            // 
            // labelInfoPedidosBuscador
            // 
            this.labelInfoPedidosBuscador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPedidosBuscador.ForeColor = System.Drawing.Color.Black;
            this.labelInfoPedidosBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInfoPedidosBuscador.Location = new System.Drawing.Point(59, 80);
            this.labelInfoPedidosBuscador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoPedidosBuscador.Name = "labelInfoPedidosBuscador";
            this.labelInfoPedidosBuscador.Size = new System.Drawing.Size(902, 31);
            this.labelInfoPedidosBuscador.TabIndex = 153;
            this.labelInfoPedidosBuscador.Text = "Info Modo";
            this.labelInfoPedidosBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTituloPedidosBuscador
            // 
            this.labelTituloPedidosBuscador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPedidosBuscador.ForeColor = System.Drawing.Color.Black;
            this.labelTituloPedidosBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloPedidosBuscador.Location = new System.Drawing.Point(100, 20);
            this.labelTituloPedidosBuscador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloPedidosBuscador.Name = "labelTituloPedidosBuscador";
            this.labelTituloPedidosBuscador.Size = new System.Drawing.Size(296, 31);
            this.labelTituloPedidosBuscador.TabIndex = 152;
            this.labelTituloPedidosBuscador.Text = "TITULO";
            this.labelTituloPedidosBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUsuariosBuscador
            // 
            this.btnUsuariosBuscador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuariosBuscador.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnUsuariosBuscador.FlatAppearance.BorderSize = 0;
            this.btnUsuariosBuscador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosBuscador.ForeColor = System.Drawing.Color.Black;
            this.btnUsuariosBuscador.Location = new System.Drawing.Point(863, 578);
            this.btnUsuariosBuscador.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuariosBuscador.Name = "btnUsuariosBuscador";
            this.btnUsuariosBuscador.Size = new System.Drawing.Size(98, 27);
            this.btnUsuariosBuscador.TabIndex = 151;
            this.btnUsuariosBuscador.Text = "Boton";
            this.btnUsuariosBuscador.UseVisualStyleBackColor = true;
            this.btnUsuariosBuscador.Click += new System.EventHandler(this.btnUsuariosBuscador_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(635, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 171;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsuario.Location = new System.Drawing.Point(479, 160);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(67, 31);
            this.labelUsuario.TabIndex = 170;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoEllipsis = true;
            this.btnUsuario.BackColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 12.125F);
            this.btnUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnUsuario.Location = new System.Drawing.Point(483, 191);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(107, 27);
            this.btnUsuario.TabIndex = 169;
            this.btnUsuario.Text = "Seleccionar";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerFecha.Location = new System.Drawing.Point(61, 191);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(299, 29);
            this.dateTimePickerFecha.TabIndex = 168;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // labelFechaPedido
            // 
            this.labelFechaPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaPedido.ForeColor = System.Drawing.Color.Black;
            this.labelFechaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFechaPedido.Location = new System.Drawing.Point(57, 161);
            this.labelFechaPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaPedido.Name = "labelFechaPedido";
            this.labelFechaPedido.Size = new System.Drawing.Size(67, 31);
            this.labelFechaPedido.TabIndex = 167;
            this.labelFechaPedido.Text = "Fecha:";
            this.labelFechaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PedidosBuscador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1020, 625);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelFechaPedido);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.labelUsuarios);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.labelInfoPedidosBuscador);
            this.Controls.Add(this.labelTituloPedidosBuscador);
            this.Controls.Add(this.btnUsuariosBuscador);
            this.Name = "PedidosBuscador";
            this.Text = "PedidosBuscador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PedidosBuscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label labelUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label labelInfoPedidosBuscador;
        private System.Windows.Forms.Label labelTituloPedidosBuscador;
        private System.Windows.Forms.Button btnUsuariosBuscador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelFechaPedido;
    }
}