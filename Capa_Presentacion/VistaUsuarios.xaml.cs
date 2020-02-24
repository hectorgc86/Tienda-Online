using Capa_Entidades;
using Capa_Negocio;
using Capa_Presentacion.Validadores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Capa_Presentacion
{
    /// <summary>
    /// Integración lógica para Usuarios
    /// </summary>
    public partial class VistaUsuarios : UserControl
    {
        //Variables

        private Negocio _neg;

        private string estado;

        List<Usuario> usuarios;
        List<Provincia> provincias;
        List<Localidad> localidades;

        private Dictionary<string, string> dicProvincias;
        private Dictionary<string, string> dicLocalidades;
        private CollectionView view;
        private ObservableCollection<Usuario> listaUsuarios;

        //Constructor

        public VistaUsuarios(string estado)
        {
            InitializeComponent();

            _neg = new Negocio();

            try
            {
                provincias = _neg.ListarProvincias();
                localidades = _neg.ListarLocalidades();
            }
            catch (Exception e)
            {
                VistaPrincipal.Status.Message = e.Message;
            }

            dicProvincias = new Dictionary<string, string>();

            foreach (Provincia prov in provincias)
            {
                dicProvincias.Add(prov.ProvinciaID, prov.Nombre);
            }

            comboBoxProvincias.ItemsSource = dicProvincias;
            comboBoxProvincias.SelectedValuePath = "Key";
            comboBoxProvincias.DisplayMemberPath = "Value";
            comboBoxProvincias.SelectedIndex = 0;

            DataContext = this;
            this.estado = estado;

            ConfigurarVentanas();

        }

        //Método de configurado inicial de la vista

        private void ConfigurarVentanas()
        {
            if (estado == "Insertar")
            {
                gridPrincipal.RowDefinitions.ElementAt(0).Height = new GridLength(0, GridUnitType.Star);
                gridPrincipal.RowDefinitions.ElementAt(1).Height = new GridLength(0, GridUnitType.Star);

                botonUsuarios.Content = "Insertar";
            }
            else if (estado == "Modificar")
            {
                textBoxPassword1.Visibility = Visibility.Hidden;
                textBoxPassword2.Visibility = Visibility.Hidden;
                comboBoxLocalidades.Visibility = Visibility.Hidden;
                comboBoxProvincias.Visibility = Visibility.Hidden;
                labelLocalidad.Visibility = Visibility.Hidden;
                labelProvincia.Visibility = Visibility.Hidden;
                labelPassword1.Visibility = Visibility.Hidden;
                labelPassword2.Visibility = Visibility.Hidden;
                AsteriscoLocalidad.Visibility = Visibility.Hidden;
                AsteriscoProvincia.Visibility = Visibility.Hidden;
                AsteriscoPassword1.Visibility = Visibility.Hidden;
                AsteriscoPassword2.Visibility = Visibility.Hidden;

                botonUsuarios.Content = "Modificar";
            }
            else if (estado == "Eliminar")
            {
                botonUsuarios.Content = "Eliminar";
                labelCamposObligatorios.Visibility = Visibility.Hidden;
                gridPrincipal.RowDefinitions.ElementAt(2).Height = new GridLength(0, GridUnitType.Star);
            }
            else if (estado == "Seleccionar")
            {
                botonUsuarios.Content = "Seleccionar";
                labelCamposObligatorios.Visibility = Visibility.Hidden;
                gridPrincipal.RowDefinitions.ElementAt(2).Height = new GridLength(0, GridUnitType.Star);
            }
        }

        //Evento de carga de la vista
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (estado == "Insertar")
            {
                ResetearUsuario();
            }
            else if (estado == "Modificar" || estado == "Eliminar" || estado == "Seleccionar")
            {
                try
                {
                    usuarios = _neg.ListarUsuarios();
                }
                catch (Exception ex)
                {
                    VistaPrincipal.Status.Message = ex.Message;
                }

                listaUsuarios = new ObservableCollection<Usuario>(usuarios);
                listViewUsuarios.ItemsSource = listaUsuarios;
                view = (CollectionView)CollectionViewSource.GetDefaultView(listViewUsuarios.ItemsSource);
                view.Filter = FiltroUsuarios;
                view.Refresh();
            }

        }

        //Método de reseteo de usuario

        private void ResetearUsuario()
        {
            Usuario us = new Usuario();
            us.ProvinciaID = "1";
            us.PuebloID = "0014";

            listViewUsuarios.ItemsSource = new List<Usuario>() { us };
            listViewUsuarios.SelectedIndex = 0;
            comboBoxProvincias.SelectedIndex = 0;

            MarcarCamposObligatorios();
        }

        //Método de carga de localidades 

        private void CargarLocalidades(string provincia)
        {
            dicLocalidades = new Dictionary<string, string>();

            foreach (Localidad loc in localidades.Where(loc => loc.ProvinciaID == provincia))
            {
                dicLocalidades.Add(loc.LocalidadID, loc.Nombre);
            }

            comboBoxLocalidades.ItemsSource = dicLocalidades;
            comboBoxLocalidades.SelectedValuePath = "Key";
            comboBoxLocalidades.DisplayMemberPath = "Value";
            comboBoxLocalidades.SelectedIndex = 0;

            dicLocalidades.Clear();
        }

        //Método de filtrado de usuarios

        private bool FiltroUsuarios(Object item)
        {
            if (string.IsNullOrEmpty(buscadorUsuarios.Text))
            {
                return true;
            }
            else
            {
                Usuario user = (Usuario)item;
                bool result = (user.Nombre.IndexOf(buscadorUsuarios.Text, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (user.Apellidos.IndexOf(buscadorUsuarios.Text, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (user.Dni.IndexOf(buscadorUsuarios.Text, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (user.Email.IndexOf(buscadorUsuarios.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                return result;
            }
        }

        //Evento de tecleo en buscador, refresca la vista asignada al listview de usuarios y actualiza el filtro

        private void BuscadorUsuarios_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(listViewUsuarios.ItemsSource).Refresh();

        }

        //Evento de cambio de valor en el combobox provincias

        private void comboBoxProvincias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxProvincias.SelectedValue != null)
            {
                if (comboBoxProvincias.SelectedValue.ToString() != "")
                {
                    if (comboBoxProvincias.SelectedItem != null)
                    {
                        KeyValuePair<string, string> prov = (KeyValuePair<string, string>)comboBoxProvincias.SelectedItem;

                        CargarLocalidades(prov.Key);
                    }
                }
            }
        }

        //Evento de pulsación del botón de acción de usuarios (varía en función del modo)

        private void BotonUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Usuario usu = (Usuario)listViewUsuarios.SelectedItem;
            bool respuesta = false;

            if (estado == "Insertar")
            {
                try
                {
                    respuesta = _neg.AnyadirUsuario(usu);
                }
                catch (Exception ex)
                {
                    VistaPrincipal.Status.Message = ex.Message;
                }
                if (respuesta)
                {
                    MessageBox.Show(Window.GetWindow(this), "Usuario añadido con éxito", "Insertar Usuario", MessageBoxButton.OK, MessageBoxImage.Information);

                    ResetearUsuario();
                }
                else
                {
                    MessageBox.Show(Window.GetWindow(this), "Error añadiendo usuario", "Insertar Usuario", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (estado == "Eliminar")
            {
                try
                {
                    respuesta = _neg.BorrarUsuario(usu.UsuarioId);
                }
                catch (Exception ex)
                {
                    VistaPrincipal.Status.Message = ex.Message;
                }
                if (respuesta)
                {
                    listaUsuarios.Remove(usuarios.Where(us => us.UsuarioId == usu.UsuarioId).First());
                    view.Refresh();
                    MessageBox.Show("Usuario eliminado con éxito", "Insertar Usuario", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error eliminando usuario", "Insertar Usuario", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else if (estado == "Modificar")
            {
                try
                {
                    respuesta = _neg.ModificarUsuario(usu);
                }
                catch (Exception ex)
                {
                    VistaPrincipal.Status.Message = ex.Message;
                }
                if (respuesta)
                {
                    MessageBox.Show("Usuario modificado con éxito", "Modificar Usuario", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error modificando usuario", "Modificar Usuario", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (estado == "Seleccionar")
            {
                Utils.ContextoPedidos.SeleccionarUsuario(usu);

                Window parentWindow = Window.GetWindow((DependencyObject)sender);
                if (parentWindow != null)
                {
                    parentWindow.Close();
                }

            }
        }

        //Función llamada al entrar para poner todos os campos con error y desactivar el botón de añadir

        private void MarcarCamposObligatorios()
        {
            ValidationError validationError = new ValidationError(new VacioRegla() { Vacio = false }, textBoxNombre.GetBindingExpression(TextBox.TextProperty));

            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                validationError.ErrorContent = "Campo obligatorio";
                Validation.MarkInvalid(
                textBoxNombre.GetBindingExpression(TextBox.TextProperty),
                validationError);
                Validation.SetErrorTemplate(textBoxNombre, Resources["ValidationTemplate"] as ControlTemplate);
            }
            if (string.IsNullOrEmpty(textBoxApellidos.Text))
            {
                validationError.ErrorContent = "Campo obligatorio";
                Validation.MarkInvalid(
                textBoxApellidos.GetBindingExpression(TextBox.TextProperty),
                validationError);
                Validation.SetErrorTemplate(textBoxApellidos, Resources["ValidationTemplate"] as ControlTemplate);

            }
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                validationError.ErrorContent = "Campo obligatorio";
                Validation.MarkInvalid(
                textBoxEmail.GetBindingExpression(TextBox.TextProperty),
                validationError);
                Validation.SetErrorTemplate(textBoxEmail, Resources["ValidationTemplate"] as ControlTemplate);

            }
            if (string.IsNullOrEmpty(textBoxDni.Text))
            {
                validationError.ErrorContent = "Campo obligatorio";
                Validation.MarkInvalid(
                textBoxDni.GetBindingExpression(TextBox.TextProperty),
                validationError);
                Validation.SetErrorTemplate(textBoxDni, Resources["ValidationTemplate"] as ControlTemplate);

            }

            if (string.IsNullOrEmpty(textBoxPassword1.Password))
            {
                validationError.ErrorContent = "Campo obligatorio";
                Validation.MarkInvalid(
                textBoxPassword1.GetBindingExpression(PasswordBox.TagProperty),
                validationError);
                Validation.SetErrorTemplate(textBoxPassword1, Resources["ValidationTemplate"] as ControlTemplate);
            }

        }

        //Crea una regla necesaria para poder validar un campo password con otro

        private void ValidarPassword(string password)
        {

            ValidationError validationError = new ValidationError(new PasswordRegla() { Password = password }, textBoxPassword1.GetBindingExpression(PasswordBox.TagProperty));

            if (textBoxPassword1.Password != textBoxPassword2.Password)
            {
                validationError.ErrorContent = "* Las contraseñas no coinciden";
                Validation.MarkInvalid(
                textBoxPassword1.GetBindingExpression(PasswordBox.TagProperty),
                validationError);
            }

            else if (!(textBoxPassword1.Password.Any(p => char.IsUpper(p)) &&
                        textBoxPassword1.Password.Any(x => char.IsNumber(x) &&
                        !textBoxPassword1.Password.All(char.IsLetterOrDigit))))
            {
                validationError.ErrorContent = " * La contraseña debe contener mínimo una mayúscula, un carácter no alfanumérico y un número";
                Validation.MarkInvalid(
                textBoxPassword1.GetBindingExpression(PasswordBox.TagProperty),
                validationError);

            }
            else
            {
                Validation.ClearInvalid(textBoxPassword1.GetBindingExpression(PasswordBox.TagProperty));
            }

        }

        //Evento de entrada de pulsación de tecla que compara password con repetir password

        private void TextBoxPassword1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ValidarPassword(textBoxPassword2.Password);
        }

        //Evento de entrada de pulsación de tecla que compara repetir password con password

        private void TextBoxPassword2_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ValidarPassword(textBoxPassword1.Password);
        }

    }

}

