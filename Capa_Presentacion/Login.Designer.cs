namespace Capa_Presentacion
{
    partial class Login
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelInfoLogin = new System.Windows.Forms.Label();
            this.labelUsuarioLogin = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelAsteriscoRojo = new System.Windows.Forms.Label();
            this.labelAsteriscoRojo2 = new System.Windows.Forms.Label();
            this.labelCamposObligatorios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(41, 12);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(306, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "LOGIN PANEL ADMINISTRACIÓN";
            // 
            // labelInfoLogin
            // 
            this.labelInfoLogin.AutoSize = true;
            this.labelInfoLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelInfoLogin.ForeColor = System.Drawing.Color.Black;
            this.labelInfoLogin.Location = new System.Drawing.Point(12, 53);
            this.labelInfoLogin.Name = "labelInfoLogin";
            this.labelInfoLogin.Size = new System.Drawing.Size(346, 15);
            this.labelInfoLogin.TabIndex = 1;
            this.labelInfoLogin.Text = "Ingrese sus credenciales para acceder al panel de administración";
            // 
            // labelUsuarioLogin
            // 
            this.labelUsuarioLogin.AutoSize = true;
            this.labelUsuarioLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.labelUsuarioLogin.Location = new System.Drawing.Point(34, 85);
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Size = new System.Drawing.Size(64, 21);
            this.labelUsuarioLogin.TabIndex = 1;
            this.labelUsuarioLogin.Text = "Usuario";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsuario.Location = new System.Drawing.Point(12, 109);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(344, 29);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenya.ForeColor = System.Drawing.Color.Black;
            this.textBoxContrasenya.Location = new System.Drawing.Point(13, 174);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(344, 29);
            this.textBoxContrasenya.TabIndex = 4;
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceder.ForeColor = System.Drawing.Color.Black;
            this.buttonAcceder.Location = new System.Drawing.Point(187, 220);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(82, 27);
            this.buttonAcceder.TabIndex = 5;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = true;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(275, 220);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 27);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = global::Capa_Presentacion.Properties.Resources.usericonblack;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(13, 86);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 7;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.lockericon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa_Presentacion.Properties.Resources.lockericon;
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // labelAsteriscoRojo
            // 
            this.labelAsteriscoRojo.AutoSize = true;
            this.labelAsteriscoRojo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsteriscoRojo.ForeColor = System.Drawing.Color.Red;
            this.labelAsteriscoRojo.Location = new System.Drawing.Point(94, 82);
            this.labelAsteriscoRojo.Name = "labelAsteriscoRojo";
            this.labelAsteriscoRojo.Size = new System.Drawing.Size(17, 21);
            this.labelAsteriscoRojo.TabIndex = 10;
            this.labelAsteriscoRojo.Text = "*";
            // 
            // labelAsteriscoRojo2
            // 
            this.labelAsteriscoRojo2.AutoSize = true;
            this.labelAsteriscoRojo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsteriscoRojo2.ForeColor = System.Drawing.Color.Red;
            this.labelAsteriscoRojo2.Location = new System.Drawing.Point(120, 150);
            this.labelAsteriscoRojo2.Name = "labelAsteriscoRojo2";
            this.labelAsteriscoRojo2.Size = new System.Drawing.Size(17, 21);
            this.labelAsteriscoRojo2.TabIndex = 11;
            this.labelAsteriscoRojo2.Text = "*";
            // 
            // labelCamposObligatorios
            // 
            this.labelCamposObligatorios.AutoSize = true;
            this.labelCamposObligatorios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.labelCamposObligatorios.Location = new System.Drawing.Point(12, 228);
            this.labelCamposObligatorios.Name = "labelCamposObligatorios";
            this.labelCamposObligatorios.Size = new System.Drawing.Size(125, 15);
            this.labelCamposObligatorios.TabIndex = 12;
            this.labelCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.labelCamposObligatorios);
            this.Controls.Add(this.labelAsteriscoRojo2);
            this.Controls.Add(this.labelAsteriscoRojo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuarioLogin);
            this.Controls.Add(this.labelInfoLogin);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelInfoLogin;
        private System.Windows.Forms.Label labelUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelAsteriscoRojo;
        private System.Windows.Forms.Label labelAsteriscoRojo2;
        private System.Windows.Forms.Label labelCamposObligatorios;
    }
}