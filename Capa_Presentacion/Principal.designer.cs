namespace Capa_Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barraMenus = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosInsertar = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.productosModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosConsultaYmod = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.informesFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.informesStock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripErroresPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelErroresBD = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelTiempoTranscurrido = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelContador = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelErroresPrincipal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelTextoHora = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelReloj = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBoxUsuarioConectado = new System.Windows.Forms.PictureBox();
            this.labelUsuarioLogueado = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.timerTiempoTranscurrido = new System.Windows.Forms.Timer(this.components);
            this.barraMenus.SuspendLayout();
            this.toolStripErroresPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarioConectado)).BeginInit();
            this.SuspendLayout();
            // 
            // barraMenus
            // 
            this.barraMenus.BackColor = System.Drawing.Color.White;
            this.barraMenus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraMenus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.barraMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuUsuarios,
            this.menuProductos,
            this.menuPedidos,
            this.menuEstadisticas,
            this.menuInformes,
            this.menuAcercaDe});
            this.barraMenus.Location = new System.Drawing.Point(0, 0);
            this.barraMenus.Name = "barraMenus";
            this.barraMenus.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.barraMenus.Size = new System.Drawing.Size(1008, 33);
            this.barraMenus.TabIndex = 3;
            this.barraMenus.Text = "MenuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoSalir});
            this.menuArchivo.MergeIndex = 0;
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(75, 25);
            this.menuArchivo.Text = "&Archivo";
            // 
            // archivoSalir
            // 
            this.archivoSalir.Name = "archivoSalir";
            this.archivoSalir.Size = new System.Drawing.Size(111, 26);
            this.archivoSalir.Text = "Salir";
            this.archivoSalir.Click += new System.EventHandler(this.archivoSalir_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosInsertar,
            this.usuariosModificar,
            this.usuariosEliminar});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(83, 25);
            this.menuUsuarios.Text = "Usuarios";
            // 
            // usuariosInsertar
            // 
            this.usuariosInsertar.Name = "usuariosInsertar";
            this.usuariosInsertar.Size = new System.Drawing.Size(146, 26);
            this.usuariosInsertar.Text = "Insertar";
            this.usuariosInsertar.Click += new System.EventHandler(this.usuariosInsertar_Click);
            // 
            // usuariosModificar
            // 
            this.usuariosModificar.Name = "usuariosModificar";
            this.usuariosModificar.Size = new System.Drawing.Size(146, 26);
            this.usuariosModificar.Text = "Modificar";
            this.usuariosModificar.Click += new System.EventHandler(this.usuariosModificar_Click);
            // 
            // usuariosEliminar
            // 
            this.usuariosEliminar.Name = "usuariosEliminar";
            this.usuariosEliminar.Size = new System.Drawing.Size(146, 26);
            this.usuariosEliminar.Text = "Eliminar";
            this.usuariosEliminar.Click += new System.EventHandler(this.usuariosEliminar_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosConsultar,
            this.productosModificar});
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(92, 25);
            this.menuProductos.Text = "Productos";
            // 
            // productosConsultar
            // 
            this.productosConsultar.Name = "productosConsultar";
            this.productosConsultar.Size = new System.Drawing.Size(147, 26);
            this.productosConsultar.Text = "Consultar";
            this.productosConsultar.Click += new System.EventHandler(this.productosConsultar_Click);
            // 
            // productosModificar
            // 
            this.productosModificar.Name = "productosModificar";
            this.productosModificar.Size = new System.Drawing.Size(147, 26);
            this.productosModificar.Text = "Modificar";
            // 
            // menuPedidos
            // 
            this.menuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosNuevo,
            this.pedidosConsultaYmod,
            this.pedidosEliminar});
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(76, 25);
            this.menuPedidos.Text = "Pedidos";
            // 
            // pedidosNuevo
            // 
            this.pedidosNuevo.Name = "pedidosNuevo";
            this.pedidosNuevo.Size = new System.Drawing.Size(246, 26);
            this.pedidosNuevo.Text = "Nuevo";
            this.pedidosNuevo.Click += new System.EventHandler(this.pedidosNuevo_Click);
            // 
            // pedidosConsultaYmod
            // 
            this.pedidosConsultaYmod.Name = "pedidosConsultaYmod";
            this.pedidosConsultaYmod.Size = new System.Drawing.Size(246, 26);
            this.pedidosConsultaYmod.Text = "Consulta y modificación";
            this.pedidosConsultaYmod.Click += new System.EventHandler(this.pedidosConsultaYmod_Click);
            // 
            // pedidosEliminar
            // 
            this.pedidosEliminar.Name = "pedidosEliminar";
            this.pedidosEliminar.Size = new System.Drawing.Size(246, 26);
            this.pedidosEliminar.Text = "Eliminar";
            // 
            // menuEstadisticas
            // 
            this.menuEstadisticas.Name = "menuEstadisticas";
            this.menuEstadisticas.Size = new System.Drawing.Size(101, 25);
            this.menuEstadisticas.Text = "Estadísticas";
            this.menuEstadisticas.Click += new System.EventHandler(this.menuEstadisticas_Click);
            // 
            // menuInformes
            // 
            this.menuInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesFactura,
            this.informesStock});
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Size = new System.Drawing.Size(84, 25);
            this.menuInformes.Text = "Informes";
            // 
            // informesFactura
            // 
            this.informesFactura.Name = "informesFactura";
            this.informesFactura.Size = new System.Drawing.Size(180, 26);
            this.informesFactura.Text = "Factura";
            this.informesFactura.Click += new System.EventHandler(this.informesFactura_Click);
            // 
            // informesStock
            // 
            this.informesStock.Name = "informesStock";
            this.informesStock.Size = new System.Drawing.Size(180, 26);
            this.informesStock.Text = "Stock";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(98, 25);
            this.menuAcercaDe.Text = "Acerca de...";
            this.menuAcercaDe.Click += new System.EventHandler(this.menuAcercaDe_Click);
            // 
            // toolStripErroresPrincipal
            // 
            this.toolStripErroresPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripErroresPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelErroresBD,
            this.toolStripSeparator3,
            this.toolStripLabelTiempoTranscurrido,
            this.toolStripLabelContador,
            this.toolStripSeparator2,
            this.toolStripLabelErroresPrincipal,
            this.toolStripLabelTextoHora,
            this.toolStripLabelReloj,
            this.toolStripSeparator1});
            this.toolStripErroresPrincipal.Location = new System.Drawing.Point(0, 704);
            this.toolStripErroresPrincipal.Name = "toolStripErroresPrincipal";
            this.toolStripErroresPrincipal.Size = new System.Drawing.Size(1008, 25);
            this.toolStripErroresPrincipal.TabIndex = 5;
            // 
            // toolStripLabelErroresBD
            // 
            this.toolStripLabelErroresBD.AutoSize = false;
            this.toolStripLabelErroresBD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelErroresBD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabelErroresBD.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabelErroresBD.Name = "toolStripLabelErroresBD";
            this.toolStripLabelErroresBD.Size = new System.Drawing.Size(600, 22);
            this.toolStripLabelErroresBD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelTiempoTranscurrido
            // 
            this.toolStripLabelTiempoTranscurrido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelTiempoTranscurrido.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabelTiempoTranscurrido.Name = "toolStripLabelTiempoTranscurrido";
            this.toolStripLabelTiempoTranscurrido.Size = new System.Drawing.Size(154, 22);
            this.toolStripLabelTiempoTranscurrido.Text = "Tiempo transcurrido:";
            // 
            // toolStripLabelContador
            // 
            this.toolStripLabelContador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelContador.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabelContador.Name = "toolStripLabelContador";
            this.toolStripLabelContador.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabelContador.Text = "        ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelErroresPrincipal
            // 
            this.toolStripLabelErroresPrincipal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelErroresPrincipal.Name = "toolStripLabelErroresPrincipal";
            this.toolStripLabelErroresPrincipal.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabelTextoHora
            // 
            this.toolStripLabelTextoHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelTextoHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabelTextoHora.Name = "toolStripLabelTextoHora";
            this.toolStripLabelTextoHora.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabelTextoHora.Text = "Hora:";
            // 
            // toolStripLabelReloj
            // 
            this.toolStripLabelReloj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabelReloj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabelReloj.Name = "toolStripLabelReloj";
            this.toolStripLabelReloj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripLabelReloj.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabelReloj.Text = "        ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBoxUsuarioConectado
            // 
            this.pictureBoxUsuarioConectado.ErrorImage = null;
            this.pictureBoxUsuarioConectado.Image = global::Capa_Presentacion.Properties.Resources.usericonblack;
            this.pictureBoxUsuarioConectado.InitialImage = global::Capa_Presentacion.Properties.Resources.usericonblack;
            this.pictureBoxUsuarioConectado.Location = new System.Drawing.Point(848, 5);
            this.pictureBoxUsuarioConectado.Name = "pictureBoxUsuarioConectado";
            this.pictureBoxUsuarioConectado.Size = new System.Drawing.Size(25, 22);
            this.pictureBoxUsuarioConectado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuarioConectado.TabIndex = 7;
            this.pictureBoxUsuarioConectado.TabStop = false;
            // 
            // labelUsuarioLogueado
            // 
            this.labelUsuarioLogueado.AutoSize = true;
            this.labelUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogueado.Location = new System.Drawing.Point(879, 6);
            this.labelUsuarioLogueado.Name = "labelUsuarioLogueado";
            this.labelUsuarioLogueado.Size = new System.Drawing.Size(64, 21);
            this.labelUsuarioLogueado.TabIndex = 6;
            this.labelUsuarioLogueado.Text = "Usuario";
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTiempoTranscurrido
            // 
            this.timerTiempoTranscurrido.Interval = 1000;
            this.timerTiempoTranscurrido.Tick += new System.EventHandler(this.timerTiempoTranscurrido_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBoxUsuarioConectado);
            this.Controls.Add(this.labelUsuarioLogueado);
            this.Controls.Add(this.toolStripErroresPrincipal);
            this.Controls.Add(this.barraMenus);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda DAM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.barraMenus.ResumeLayout(false);
            this.barraMenus.PerformLayout();
            this.toolStripErroresPrincipal.ResumeLayout(false);
            this.toolStripErroresPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuarioConectado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barraMenus;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem usuariosInsertar;
        private System.Windows.Forms.ToolStripMenuItem usuariosModificar;
        private System.Windows.Forms.ToolStripMenuItem usuariosEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem productosConsultar;
        private System.Windows.Forms.ToolStripMenuItem productosModificar;
        private System.Windows.Forms.ToolStripMenuItem menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem pedidosNuevo;
        private System.Windows.Forms.ToolStripMenuItem pedidosConsultaYmod;
        private System.Windows.Forms.ToolStripMenuItem pedidosEliminar;
        private System.Windows.Forms.ToolStripMenuItem menuEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem menuInformes;
        private System.Windows.Forms.ToolStripMenuItem informesFactura;
        private System.Windows.Forms.ToolStripMenuItem informesStock;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.ToolStrip toolStripErroresPrincipal;
        private System.Windows.Forms.ToolStripLabel toolStripLabelErroresPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxUsuarioConectado;
        private System.Windows.Forms.Label labelUsuarioLogueado;
        private System.Windows.Forms.ToolStripLabel toolStripLabelReloj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTextoHora;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTiempoTranscurrido;
        private System.Windows.Forms.ToolStripLabel toolStripLabelContador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timerTiempoTranscurrido;
        private System.Windows.Forms.ToolStripLabel toolStripLabelErroresBD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

