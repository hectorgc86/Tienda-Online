namespace Capa_Presentacion
{
    partial class PedidosFormulario
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
            this.labelTituloPedidosForm = new System.Windows.Forms.Label();
            this.labelInfoPedidosForm = new System.Windows.Forms.Label();
            this.btnPedidoVariable = new System.Windows.Forms.Button();
            this.btnSeleccionProducto = new System.Windows.Forms.Button();
            this.dataGridViewLinPeds = new System.Windows.Forms.DataGridView();
            this.labelFechaPedido = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelLinpeds = new System.Windows.Forms.Label();
            this.pictureBoxPedidos = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.totalSinIVATextBox = new System.Windows.Forms.TextBox();
            this.IVATextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinPeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloPedidosForm
            // 
            this.labelTituloPedidosForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPedidosForm.ForeColor = System.Drawing.Color.Black;
            this.labelTituloPedidosForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloPedidosForm.Location = new System.Drawing.Point(78, 18);
            this.labelTituloPedidosForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTituloPedidosForm.Name = "labelTituloPedidosForm";
            this.labelTituloPedidosForm.Size = new System.Drawing.Size(226, 31);
            this.labelTituloPedidosForm.TabIndex = 104;
            this.labelTituloPedidosForm.Text = "TITULO";
            this.labelTituloPedidosForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoPedidosForm
            // 
            this.labelInfoPedidosForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoPedidosForm.ForeColor = System.Drawing.Color.Black;
            this.labelInfoPedidosForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInfoPedidosForm.Location = new System.Drawing.Point(37, 78);
            this.labelInfoPedidosForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoPedidosForm.Name = "labelInfoPedidosForm";
            this.labelInfoPedidosForm.Size = new System.Drawing.Size(930, 31);
            this.labelInfoPedidosForm.TabIndex = 153;
            this.labelInfoPedidosForm.Text = "Info Modo";
            this.labelInfoPedidosForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPedidoVariable
            // 
            this.btnPedidoVariable.AutoEllipsis = true;
            this.btnPedidoVariable.BackColor = System.Drawing.Color.White;
            this.btnPedidoVariable.FlatAppearance.BorderSize = 0;
            this.btnPedidoVariable.Font = new System.Drawing.Font("Segoe UI", 12.125F);
            this.btnPedidoVariable.ForeColor = System.Drawing.Color.Black;
            this.btnPedidoVariable.Location = new System.Drawing.Point(794, 595);
            this.btnPedidoVariable.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidoVariable.Name = "btnPedidoVariable";
            this.btnPedidoVariable.Size = new System.Drawing.Size(173, 27);
            this.btnPedidoVariable.TabIndex = 154;
            this.btnPedidoVariable.Text = "Boton";
            this.btnPedidoVariable.UseVisualStyleBackColor = true;
            this.btnPedidoVariable.Click += new System.EventHandler(this.btnPedidoVariable_Click);
            // 
            // btnSeleccionProducto
            // 
            this.btnSeleccionProducto.AutoEllipsis = true;
            this.btnSeleccionProducto.BackColor = System.Drawing.Color.White;
            this.btnSeleccionProducto.FlatAppearance.BorderSize = 0;
            this.btnSeleccionProducto.Font = new System.Drawing.Font("Segoe UI", 12.125F);
            this.btnSeleccionProducto.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionProducto.Location = new System.Drawing.Point(265, 241);
            this.btnSeleccionProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeleccionProducto.Name = "btnSeleccionProducto";
            this.btnSeleccionProducto.Size = new System.Drawing.Size(184, 27);
            this.btnSeleccionProducto.TabIndex = 156;
            this.btnSeleccionProducto.Text = "Seleccionar Articulo";
            this.btnSeleccionProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionProducto.Click += new System.EventHandler(this.btnAnyadirLinped_Click);
            // 
            // dataGridViewLinPeds
            // 
            this.dataGridViewLinPeds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLinPeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinPeds.Location = new System.Drawing.Point(39, 288);
            this.dataGridViewLinPeds.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLinPeds.MultiSelect = false;
            this.dataGridViewLinPeds.Name = "dataGridViewLinPeds";
            this.dataGridViewLinPeds.ReadOnly = true;
            this.dataGridViewLinPeds.RowHeadersVisible = false;
            this.dataGridViewLinPeds.RowTemplate.Height = 33;
            this.dataGridViewLinPeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLinPeds.Size = new System.Drawing.Size(809, 176);
            this.dataGridViewLinPeds.TabIndex = 157;
            // 
            // labelFechaPedido
            // 
            this.labelFechaPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaPedido.ForeColor = System.Drawing.Color.Black;
            this.labelFechaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFechaPedido.Location = new System.Drawing.Point(35, 150);
            this.labelFechaPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaPedido.Name = "labelFechaPedido";
            this.labelFechaPedido.Size = new System.Drawing.Size(67, 31);
            this.labelFechaPedido.TabIndex = 160;
            this.labelFechaPedido.Text = "Fecha:";
            this.labelFechaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFechaPedido.Click += new System.EventHandler(this.labelFechaPedido_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dateTimePickerFecha.Enabled = false;
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePickerFecha.Location = new System.Drawing.Point(39, 180);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(299, 29);
            this.dateTimePickerFecha.TabIndex = 161;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoEllipsis = true;
            this.btnUsuario.BackColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 12.125F);
            this.btnUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnUsuario.Location = new System.Drawing.Point(461, 180);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(107, 27);
            this.btnUsuario.TabIndex = 163;
            this.btnUsuario.Text = "Seleccionar";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Black;
            this.labelUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsuario.Location = new System.Drawing.Point(457, 149);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(67, 31);
            this.labelUsuario.TabIndex = 164;
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // labelLinpeds
            // 
            this.labelLinpeds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinpeds.ForeColor = System.Drawing.Color.Black;
            this.labelLinpeds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLinpeds.Location = new System.Drawing.Point(37, 241);
            this.labelLinpeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLinpeds.Name = "labelLinpeds";
            this.labelLinpeds.Size = new System.Drawing.Size(167, 31);
            this.labelLinpeds.TabIndex = 165;
            this.labelLinpeds.Text = "Lineas de pedido";
            this.labelLinpeds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxPedidos
            // 
            this.pictureBoxPedidos.Image = global::Capa_Presentacion.Properties.Resources.caseiconblack;
            this.pictureBoxPedidos.InitialImage = null;
            this.pictureBoxPedidos.Location = new System.Drawing.Point(39, 18);
            this.pictureBoxPedidos.Name = "pictureBoxPedidos";
            this.pictureBoxPedidos.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPedidos.TabIndex = 152;
            this.pictureBoxPedidos.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(613, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 166;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(596, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 167;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(470, 248);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 168;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.125F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(848, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 169;
            this.button1.Text = "Añadir articulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalSinIVATextBox
            // 
            this.totalSinIVATextBox.Location = new System.Drawing.Point(490, 500);
            this.totalSinIVATextBox.Name = "totalSinIVATextBox";
            this.totalSinIVATextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSinIVATextBox.TabIndex = 170;
            // 
            // IVATextBox
            // 
            this.IVATextBox.Location = new System.Drawing.Point(613, 500);
            this.IVATextBox.Name = "IVATextBox";
            this.IVATextBox.Size = new System.Drawing.Size(100, 20);
            this.IVATextBox.TabIndex = 171;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(748, 500);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 172;
            // 
            // PedidosFormulario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.IVATextBox);
            this.Controls.Add(this.totalSinIVATextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLinpeds);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.labelFechaPedido);
            this.Controls.Add(this.dataGridViewLinPeds);
            this.Controls.Add(this.btnSeleccionProducto);
            this.Controls.Add(this.btnPedidoVariable);
            this.Controls.Add(this.labelInfoPedidosForm);
            this.Controls.Add(this.pictureBoxPedidos);
            this.Controls.Add(this.labelTituloPedidosForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PedidosFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PedidosFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinPeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTituloPedidosForm;
        private System.Windows.Forms.PictureBox pictureBoxPedidos;
        private System.Windows.Forms.Label labelInfoPedidosForm;
        private System.Windows.Forms.Button btnPedidoVariable;
        private System.Windows.Forms.Button btnSeleccionProducto;
        private System.Windows.Forms.DataGridView dataGridViewLinPeds;
        private System.Windows.Forms.Label labelFechaPedido;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelLinpeds;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox totalSinIVATextBox;
        private System.Windows.Forms.TextBox IVATextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
    }
}