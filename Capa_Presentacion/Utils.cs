using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public static class Utils
    {
        private static Principal mdiParent;
        private static Usuario usuarioSeleccionado;
        private static Pedido pedidoSeleccionado;
        private static Articulo articuloSeleccionado;
        private static PedidosFormulario formPedidosSeleccionado;
        private static PedidosBuscador FormPedidosBuscador;
        public static Principal MdiParent { get => mdiParent; set => mdiParent = value; }
        public static Usuario UsuarioSeleccionado { get => usuarioSeleccionado; set => usuarioSeleccionado = value; }
        public static Pedido PedidoSeleccionado { get => pedidoSeleccionado; set => pedidoSeleccionado = value; }
        public static Articulo ArticuloSeleccionado { get => articuloSeleccionado; set => articuloSeleccionado = value; }
        public static PedidosFormulario FormPedidosSeleccionado { get => formPedidosSeleccionado; set => formPedidosSeleccionado = value; }
        public static PedidosBuscador FormPedidosBuscador1 { get => FormPedidosBuscador; set => FormPedidosBuscador = value; }

        public static void MostrarErroresBd(string error) {
          
            mdiParent.SetErrorText(error);
        }

        public static void LimpiarErroresBd()
        {

            mdiParent.SetErrorText("");
        }

        public static bool mostrarMensajeSalir()
        {
            bool close = false;

            const string mensajeSalir = "¿Desea salir de la aplicacion?";
            const string tituloSalir = "Salir";
            var result = MessageBox.Show(mensajeSalir, tituloSalir, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                close = true;
                Environment.Exit(0);
            }

            return close;
        }

    }
}
