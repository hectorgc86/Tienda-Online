using Capa_Entidades;
using System;
using System.Text;
using System.Windows;

namespace Capa_Presentacion
{
    public static class Utils
    {

        private static Usuario usuarioSeleccionado;
        private static Pedido pedidoSeleccionado;
        private static Articulo articuloSeleccionado;
        private static VistaPedidos contextoPedidos;
        private static VistaUsuarios contextoUsuarios;
        public static Usuario UsuarioSeleccionado { get => usuarioSeleccionado; set => usuarioSeleccionado = value; }
        public static Pedido PedidoSeleccionado { get => pedidoSeleccionado; set => pedidoSeleccionado = value; }
        public static Articulo ArticuloSeleccionado { get => articuloSeleccionado; set => articuloSeleccionado = value; }
        public static VistaPedidos ContextoPedidos { get => contextoPedidos; set => contextoPedidos = value; }

        public static string CalcularMD5(string input)
        {

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static void MostrarDialogSalir()
        {
            string msgtext = "¿Seguro que desea salir?";
            string txt = "Salir";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Environment.Exit(0);
                    break;
            }
        }

        public static bool MostrarDialogLogout()
        {
            bool decision;

            string msgtext = "¿Seguro que desea cerrar sesion?";
            string txt = "Cerrar sesion";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    decision = true;
                    break;
                default:
                    decision = false;
                    break;
            }

            return decision;
        }

        public static MessageBoxResult MostrarDialogError(string titulo, string contenido)
        {

            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result = MessageBox.Show(contenido, titulo, button);

            return result;
        }


    }
}
