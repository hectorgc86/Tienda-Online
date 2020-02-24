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

//<author> Héctor Granja <author>

namespace Capa_Presentacion
{
    public partial class UsuariosFormulario : Form
    {
        //Variables
        private TiendaOnline _neg;
        private Usuario usuarioActual;
        private string estado;
        private bool nombreError, apellido1Error, apellido2Error, emailError, errorSumaApellidos,codPosError,
            dniError, contrasenya1Error, contrasenya2Error;


        private object userIconBlack = Resources.ResourceManager.GetObject("usericonblack");
        private object userIcon = Resources.ResourceManager.GetObject("usericon");
        private object rightIcon = Resources.ResourceManager.GetObject("righticon");
        private object wrongIcon = Resources.ResourceManager.GetObject("wrongicon");
        Dictionary<string, string> dicProvincias;
        Dictionary<string, string> dicLocalidades;


        public UsuariosFormulario(string estado, Usuario usuarioActual)
        {
            InitializeComponent();

            //Inicializo la conexión con la capa Negocio
            _neg = new TiendaOnline();


            //Valido que el desplegable de fecha nacimiento no sea mayor al día actual
            dateTimePickerFecha.MaxDate = DateTime.Today;

            //Inicializo diccionario y almaceno clave y valor de las provincias
            dicProvincias = new Dictionary<string, string>();


            try
            {
                foreach (Provincia prov in _neg.ListarProvincias())
                {
                    dicProvincias.Add(prov.ProvinciaID, prov.Nombre);
                }
            }
            catch (Exception e)
            {

                Utils.MostrarErroresBd(e.Message);

            }

            //Asigno al combobox de Provincia los valores y selecciono el primero automaticamente
            comboBoxProvincia.DataSource = new BindingSource(dicProvincias, null);
            comboBoxProvincia.ValueMember = "Key";
            comboBoxProvincia.DisplayMember = "Value";
            comboBoxProvincia.SelectedIndex = 0;

            //Asigno estado a la variable global
            this.estado = estado;


            //Compruebo en que estado debe mostrarse el formulario
            if (estado == "Modificar")
            {
                this.Text = "Modificar Usuario";
                labelTituloUsuariosForm.Text = "MODIFICAR USUARIO";
                labelInfoUsuariosForm.Text = "Modifique los campos correctamente y pulse \"Modificar\"";
                btnUsuarioVariable.Text = "Modificar";
                this.usuarioActual = usuarioActual;
                RellenarCamposConUsuario(usuarioActual);
            }
            else if (estado == "Insertar")
            {
                this.Text = "Insertar Usuario";
                labelTituloUsuariosForm.Text = "INSERTAR USUARIO";
                labelInfoUsuariosForm.Text = "Rellene los campos correctamente y pulse \"Guardar\" para registrar un usuario nuevo";
                btnUsuarioVariable.Text = "Guardar";
                ResetearCamposFormulario();

            }
        }



        //Funciones
        private void RellenarCamposConUsuario(Usuario usuarioActual)
        {
            string[] apellidos = usuarioActual.Apellidos.Split(' ');

            textBoxNombre.Text = usuarioActual.Nombre;
            textBox1erApellido.Text = apellidos[0];
            textBoxSegundoApellido.Text = apellidos[1];
            textBoxDni.Text = usuarioActual.Dni;
            textBoxEmail.Text = usuarioActual.Email;
            textBoxCodPos.Text = usuarioActual.Codpos;
            textBoxContrasenya.Text = usuarioActual.Password;
            maskedTextBoxTelefono.Text = usuarioActual.Telefono;
            textBoxContrasenyaRepetir.Text = usuarioActual.Password;
            textBoxCalle1.Text = usuarioActual.Calle;
            textBoxCalle2.Text = usuarioActual.Calle2;
            dateTimePickerFecha.Value = usuarioActual.Nacido.Value;
            comboBoxProvincia.SelectedItem = Convert.ToInt32(usuarioActual.ProvinciaID);
            comboBoxLocalidad.SelectedValue = Convert.ToInt32(usuarioActual.PuebloID);

        }

        private void ResetearCamposFormulario()
        {
            textBoxNombre.Text = "";
            textBox1erApellido.Text = "";
            textBoxSegundoApellido.Text = "";
            textBoxDni.Text = "";
            textBoxEmail.Text = "";
            textBoxCodPos.Text = "";
            textBoxContrasenya.Text = "";
            maskedTextBoxTelefono.Text = "";
            textBoxContrasenyaRepetir.Text = "";
            textBoxCalle1.Text = "";
            textBoxCalle2.Text = "";
            dateTimePickerFecha.Value = DateTime.Today;
            comboBoxLocalidad.SelectedIndex = 0;
            comboBoxProvincia.SelectedIndex = 0;
        }

        private void CargarLocalidades(string provincia)
        {
            dicLocalidades = new Dictionary<string, string>();
            try
            {
                foreach (Localidad loc in _neg.ListarLocalidades(provincia))
                {
                    dicLocalidades.Add(loc.LocalidadID, loc.Nombre);
                }
            }
            catch (Exception e)
            {

                Utils.MostrarErroresBd(e.Message);

            }

            comboBoxLocalidad.DataSource = new BindingSource(dicLocalidades, null);
            comboBoxLocalidad.ValueMember = "Key";
            comboBoxLocalidad.DisplayMember = "Value";
            comboBoxLocalidad.SelectedIndex = 0;

            dicLocalidades.Clear();
        }

        //Funciones de validado
        private void LLamarValidacionInicial()
        {
            nombreError = ValidarTextBox(textBoxNombre);
            apellido1Error = ValidarTextBox(textBox1erApellido);
            apellido2Error = ValidarTextBox(textBoxSegundoApellido);
            emailError = ValidarTextBox(textBoxEmail);
            dniError = ValidarTextBox(textBoxDni);
            ValidarMaskedTextBox();
            ValidarTextBox(textBoxCalle1);
            ValidarTextBox(textBoxCalle2);
            codPosError = ValidarTextBox(textBoxCodPos);
            contrasenya1Error = ValidarTextBox(textBoxContrasenya);
            contrasenya2Error = ValidarTextBox(textBoxContrasenyaRepetir);
           
        }

        private bool ValidarTextBox(TextBox textBoxAValidar)
        {
            bool error = false;
            errorSumaApellidos = false;

            labelValidacionUsuario.Text = "";

            switch (textBoxAValidar.Name)
            {
                case "textBoxNombre":
                    if (textBoxAValidar.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo nombre no puede estar vacío";
                        pictureBoxNombre.Image = (Image)wrongIcon;

                        error = true;
                    }
                    else if (textBoxAValidar.Text.Length > 35)
                    {
                        labelValidacionUsuario.Text = "* El campo nombre no puede contener más de 35 caracteres";
                        pictureBoxNombre.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else
                    {
                        pictureBoxNombre.Image = (Image)rightIcon;
                    }
                    break;
                case "textBox1erApellido":
                    if (textBoxSegundoApellido.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Segundo Apellido' no puede estar vacío";
                        pictureBoxApellidos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (textBox1erApellido.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Primer Apellido' no puede estar vacío";
                        pictureBoxApellidos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else
                    {
                        pictureBoxApellidos.Image = (Image)rightIcon;
                    }
                    break;
                case "textBoxSegundoApellido":
                    if (textBox1erApellido.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Primer Apellido' no puede estar vacío";
                        pictureBoxApellidos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (textBoxSegundoApellido.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Segundo Apellido' no puede estar vacío";
                        pictureBoxApellidos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else
                    {
                        pictureBoxApellidos.Image = (Image)rightIcon;
                    }
                    break;
                case "textBoxDni":
                    if (textBoxAValidar.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Dni' no puede estar vacío";
                        pictureBoxDni.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (textBoxAValidar.Text.Length > 12)
                    {
                        labelValidacionUsuario.Text = "* El campo 'Dni' no puede superar los 12 caracteres";
                        pictureBoxDni.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (ComprobarDni(textBoxAValidar.Text))
                    {
                        labelValidacionUsuario.Text = "* El campo 'Dni' no tiene un formato correcto";
                        pictureBoxDni.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else
                    {
                        pictureBoxDni.Image = (Image)rightIcon;
                    }
                    break;
                case "textBoxEmail":
                    if (textBoxAValidar.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Email' no puede estar vacío";
                        pictureBoxEmail.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (textBoxAValidar.Text.Length > 50)
                    {
                        labelValidacionUsuario.Text = "* El campo 'Email' no puede superar los 50 caracteres";
                        pictureBoxEmail.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (!ComprobarEmail(textBoxAValidar.Text))
                    {
                        labelValidacionUsuario.Text = "* El campo 'Email' no tiene un formato correcto";
                        pictureBoxEmail.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else
                    {
                        pictureBoxEmail.Image = (Image)rightIcon;
                    }
                    break;
                case "textBoxCalle1":
                    if (textBoxAValidar.Text.Length > 45)
                    {
                        labelValidacionUsuario.Text = "* El campo 'Calle 1' no puede contener más de 45 caracteres";
                        pictureBoxCalle1.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else { pictureBoxCalle1.Image = (Image)rightIcon; }
                    break;
                case "textBoxCalle2":
                    if (textBoxAValidar.Text.Length > 45)
                    {
                        labelValidacionUsuario.Text = "* El campo 'Calle 2' no puede contener más de 45 caracteres";
                        pictureBoxCalle2.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else { pictureBoxCalle2.Image = (Image)rightIcon; }
                    break;
                case "textBoxCodPos":
                    if (textBoxAValidar.Text == "")
                    {
                        labelValidacionUsuario.Text = "* El campo 'Código Postal' no puede estar vacío";
                        pictureBoxCodPos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (!Int32.TryParse(textBoxAValidar.Text, out int numero))
                    {
                        labelValidacionUsuario.Text = "* El campo 'Código Postal' debe ser numérico";
                        pictureBoxCodPos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else if (textBoxAValidar.Text.Length != 5)
                    {
                        labelValidacionUsuario.Text = "* El campo 'Código Postal' debe contener 5 caracteres";
                        pictureBoxCodPos.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else { pictureBoxCodPos.Image = (Image)rightIcon; }
                    break;
                case "textBoxContrasenya":
                    if (textBoxAValidar.Text.Any(p => char.IsUpper(p)) &&
                        textBoxAValidar.Text.Any(x => char.IsNumber(x) &&
                        !textBoxAValidar.Text.All(char.IsLetterOrDigit))) { pictureBoxContrasenya1.Image = (Image)rightIcon; }
                    else
                    {
                        labelValidacionUsuario.Text = "* La contraseña debe contener mínimo una mayúscula, un carácter no alfanumérico y un número";
                        pictureBoxContrasenya1.Image = (Image)wrongIcon;
                        error = true;
                    }
                    break;
                case "textBoxContrasenyaRepetir":
                    if (textBoxAValidar.Text != textBoxContrasenya.Text)
                    {
                        labelValidacionUsuario.Text = "* Las contraseñas no coinciden";
                        pictureBoxContrasenya2.Image = (Image)wrongIcon;
                        error = true;
                    }
                    else { pictureBoxContrasenya2.Image = (Image)rightIcon; }
                    break;
                default:
                    break;
            }

            if ((textBox1erApellido.Text.Length + textBoxSegundoApellido.Text.Length) > 55)
            {
                labelValidacionUsuario.Text = "* La suma de caracteres de los apellidos no puede exceder los 55 caracteres";
                pictureBoxApellidos.Image = (Image)wrongIcon;
                error = true;
                errorSumaApellidos = true;
            }


            return error;
        }

        private void ValidarMaskedTextBox()
        {
            if (maskedTextBoxTelefono.TextLength == 9)
            {
                pictureBoxCodPos.Image = (Image)rightIcon;
            }
            else
            {
                labelValidacionUsuario.Text = "* Longitud incorrecta para teléfono";
                pictureBoxApellidos.Image = (Image)wrongIcon;
            }
        }

        private bool ComprobarEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        private bool ComprobarDni(string dni)
        {
            bool error = true;

            string estandarLetrasDni = "TRWAGMYFPDXBNJZSQVHLCKE";
            char[] charsDni = estandarLetrasDni.ToCharArray();


            if (dni.Length == 9)
            {
                string cadenaNumerosDni = dni.Substring(0, 8);
                string letraDni = dni.Substring(8, 1);
                string primercaracterDni = dni.Substring(0, 1);

                if (primercaracterDni.ToUpper() == "X")
                {
                    cadenaNumerosDni.ToUpper().Substring(0, 1).Replace("X", "0");

                }
                else if (primercaracterDni.ToUpper() == "Y")
                {

                    cadenaNumerosDni.ToUpper().Substring(0, 1).Replace("Y", "1");
                }
                else if (primercaracterDni.ToUpper() == "Z")
                {
                    cadenaNumerosDni.ToUpper().Substring(0, 1).Replace("Z", "2");
                }

                if (Int32.TryParse(cadenaNumerosDni, out int numerosDni))
                {
                    int restoCalculoDni = numerosDni % 23;
                    if (letraDni.ToUpper() == charsDni[restoCalculoDni].ToString()) { error = false; }
                }

            }

            return error;
        }

        private string CalcularMD5(string input)
        {

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        //Eventos
        private void textBoxSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            apellido2Error = ValidarTextBox(textBoxSegundoApellido);
        }

        private void textBoxNombre_KeyUp(object sender, KeyEventArgs e)
        {
            nombreError = ValidarTextBox(textBoxNombre);
        }

        private void textBox1erApellido_KeyUp(object sender, KeyEventArgs e)
        {
            apellido1Error = ValidarTextBox(textBox1erApellido);
        }

        private void textBoxSegundoApellido_KeyUp(object sender, KeyEventArgs e)
        {
            apellido2Error = ValidarTextBox(textBoxSegundoApellido);
        }

        private void textBoxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            emailError = ValidarTextBox(textBoxEmail);
        }

        private void textBoxDni_KeyUp(object sender, KeyEventArgs e)
        {
            dniError = ValidarTextBox(textBoxDni);
        }

        private void maskedTextBoxTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarMaskedTextBox();
        }

        private void textBoxCalle1_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTextBox(textBoxCalle1);
        }

        private void textBoxCalle2_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTextBox(textBoxCalle2);
        }

        private void textBoxCodPos_KeyUp(object sender, KeyEventArgs e)
        {
            codPosError = ValidarTextBox(textBoxCodPos);
        }

        private void textBoxContrasenyaRepetir_KeyUp(object sender, KeyEventArgs e)
        {
            contrasenya2Error = ValidarTextBox(textBoxContrasenyaRepetir);
        }

        private void textBoxContrasenya_KeyUp(object sender, KeyEventArgs e)
        {
            contrasenya1Error = ValidarTextBox(textBoxContrasenya);
        }

        private void btnUsuarioVariable_Click(object sender, EventArgs e)
        {
            LLamarValidacionInicial();

            bool error = false;
            string cadenaErrores = "";

            if (nombreError)
            {
                cadenaErrores += "- Nombre incorrecto. \n";
                error = true;
            }
            if (apellido1Error)
            {
                cadenaErrores += "- Primer apellido incorrecto. \n";
                error = true;
            }
            if (apellido2Error)
            {
                cadenaErrores += "- Segundo apellido incorrecto. \n";
                error = true;
            }
            if (dniError)
            {
                cadenaErrores += "- Dni incorrecto. \n";
                error = true;
            }
            if (codPosError)
            {
                cadenaErrores += "- Código postal incorrecto. \n";
                error = true;
            }
            if (emailError)
            {
                cadenaErrores += "- Email incorrecto. \n";
                error = true;
            }
            if (contrasenya1Error)
            {
                cadenaErrores += "- La contraseña debe contener mínimo una mayúscula, un carácter no alfanumérico y un número. \n";
                error = true;
            }
            if (contrasenya2Error)
            {
                cadenaErrores += "- Las contraseñas no coinciden. \n";
                error = true;
            }
            if (errorSumaApellidos)
            {
                cadenaErrores += "- Se esta excediendo la cantidad máxima de caracteres para apellidos. \n";
                error = true;
            }

            if (!error)
            {

                try
                {

                    string nombre = textBoxNombre.Text;
                    string apellidos = textBox1erApellido.Text + " " + textBoxSegundoApellido.Text;
                    string email = textBoxEmail.Text;
                    string password = CalcularMD5(textBoxContrasenya.Text);
                    string dni = textBoxDni.Text;
                    string telefono = maskedTextBoxTelefono.Text;
                    string calle = textBoxCalle1.Text;
                    string calle2 = textBoxCalle2.Text;
                    string codpos = textBoxCodPos.Text;
                    string puebloId = comboBoxLocalidad.SelectedValue.ToString();
                    string provinciaId = comboBoxProvincia.SelectedValue.ToString();
                    DateTime nacido = dateTimePickerFecha.Value;
                    int usuarioMasAlto = _neg.UsuarioMasAlto();

                    Usuario usu = new Usuario(nombre, apellidos, email, password, dni, telefono,
                  calle, calle2, codpos, puebloId, provinciaId, nacido, usuarioMasAlto + 1);

                    if (estado == "Insertar")
                    {
                        if (_neg.AnyadirUsuario(usu))
                        {
                            MessageBox.Show("Usuario creado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                         
                    }
                    else if (estado == "Modificar")
                    {
                        if (_neg.ModificarUsuario(usu))
                        {
                            MessageBox.Show("Usuario modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                      
                    }

                }
                catch (Exception ex)
                {
                    Utils.MostrarErroresBd(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Se han los siguientes errores al " + estado.ToLower() + " usuario:\n\n" + cadenaErrores, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1erApellido_KeyUp_1(object sender, KeyEventArgs e)
        {
            ValidarTextBox(textBox1erApellido);
        }

        private void dateTimePickerFecha_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTextBox(textBoxEmail);
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxLocalidad.Items.Count == 0)
            {
                CargarLocalidades("01");
            }

        }

        private void comboBoxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (comboBoxProvincia.SelectedValue.ToString() != "")
            {
                CargarLocalidades(comboBoxProvincia.SelectedValue.ToString());

            }
        }

        private void btnLimpiarUsuarios_Click(object sender, EventArgs e)
        {
            ResetearCamposFormulario();
        }
    }

}

