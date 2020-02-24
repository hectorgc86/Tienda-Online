using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Capa_Entidades;
using Capa_Datos;

//<author> Héctor Granja <author>

namespace Capa_Negocio
{
    public class TiendaOnline
    {
        //Atributos

        private PedidosADO _datPed;
        private LinpedsADO _datLinPed;
        private UsuarioADO _datUsu;
        private ArticulosADO _datArt;
        private ProvinciasADO _datProv;
        private LocalidadesADO _datLoc;
        private TvADO _datTv;
        private CamaraADO _datCam;
        private MemoriasADO _datMem;
        private ObjetivosADO _datObj;


        //Contructor de la clase
        public TiendaOnline()
        {
            _datPed = new PedidosADO();
            _datLinPed = new LinpedsADO();
            _datUsu = new UsuarioADO();
            _datArt = new ArticulosADO();
            _datProv = new ProvinciasADO();
            _datLoc = new LocalidadesADO();
            _datTv = new TvADO();
            _datCam = new CamaraADO();
            _datMem = new MemoriasADO();
            _datObj = new ObjetivosADO();
        }



        //Método de filtrado de pedidos de la tienda en función al email de un usuario
        public List<Pedido> PedidosUsuario(string email) {

            //Busco a un usuario cuyo email sea el recibido por argumentos en la lista de usuarios de _datUsu, y que me de el primero puesto que
            //al ser clave única en la BBDD solo va a encontrar uno siempre.

            try
            {
                Usuario usuarioBuscado = _datUsu.LeerUsuarios().Where(u => u.Email == email).First();

                //Si no encuentra es por que no hay usuarios con ese email
                if (usuarioBuscado == null)
                {
                    throw new Exception("No se han encontrado usuarios con ese email");
                }

                List<Pedido> listaAuxiliar = _datPed.LeerPedidos().Where(p => p.UsuarioID == usuarioBuscado.UsuarioID).ToList();

                return listaAuxiliar;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Localidad BuscarLocalidad(string puebloID,string provinciaId)
        {
            try
            {
                Localidad localidad = _datLoc.LeerLocalidades().Where(l => l.LocalidadID == puebloID && l.ProvinciaID == provinciaId).First();
                return localidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Articulo ObtenerArticulo(string articuloID)
        {
            try
            {
                return _datArt.LeerArticulo(articuloID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método de filtrado de pedidos de la tienda en función a la fecha de creación del pedido
        public List<Pedido> PedidosDiarios(DateTime dia) {

            try
            {
                List<Pedido> pedidos = _datPed.LeerPedidos().Where(p => p.Fecha.Date.Equals(dia.Date)).ToList();


                return pedidos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Pedido> PedidosMensuales(DateTime mes)
        {

            try
            {
                List<Pedido> pedidos = _datPed.LeerPedidos().Where(p => p.Fecha.Month.Equals(mes.Month)).ToList();


                return pedidos;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Pedido> ListarPedidos()
        {
            try
            {
                List<Pedido> pedidos = _datPed.LeerPedidos();

                return pedidos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        public bool UsuarioTienePedidos(Usuario usu)
        {

           return ListarPedidos().Any(p=>p.UsuarioID == usu.UsuarioID);
          
        }

        public List<Usuario> ListarUsuarios() {
            try
            {
                return _datUsu.LeerUsuarios();

            }
            catch (Exception)
            {

                throw;
            }        }

        public List<Articulo> ListarArticulos()
        {
            try
            {
                return _datArt.LeerArticulos();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Articulo> ListarArticulos(string articuloID)
        {
            try
            {
                List<Articulo> listaArticulos = _datArt.LeerArticulos().Where(a => a.ArticuloID == articuloID ).ToList();

                return listaArticulos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Pedido ObtenerPedido(int pedidoID)
        {
            try
            {
                return _datPed.LeerPedido(pedidoID).First();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Tv ObtenerTv (string articuloID)
        {
            try
            {
                return _datTv.LeerTv(articuloID);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public Camara ObtenerCamara(string articuloID)
        {
            try
            {       
                return _datCam.LeerCamara(articuloID);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Memoria ObtenerMemoria(string articuloID)
        {
            try
            {
                return _datMem.LeerMemoria(articuloID);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Objetivo ObtenerObjetivo(string articuloID)
        {
            try
            {
                return _datObj.LeerObjetivo(articuloID);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Provincia> ListarProvincias()
        {
            try
            {
                return _datProv.LeerProvincias();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Localidad> ListarLocalidades()
        {
            

            try
            {
                return _datLoc.LeerLocalidades();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Localidad> ListarLocalidades(string provinciaId)
        {

            try
            {
                return _datLoc.LeerLocalidades().Where(p => p.ProvinciaID == provinciaId).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnyadirUsuario(Usuario usu) {

            try
            {
               return _datUsu.InsertarUsuario(usu.Nombre, usu.Apellidos, usu.Email, usu.Password, usu.Dni, usu.Telefono,
               usu.Calle, usu.Calle2, usu.Codpos, usu.PuebloID, usu.ProvinciaID, usu.Nacido, usu.UsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
           

        }

      
        public void BorrarUsuario(string id)
        {
            try
            {
                _datUsu.BorrarUsuario(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ModificarUsuario(Usuario usu) {

            try
            {
               return _datUsu.ActualizarUsuario(usu);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int UsuarioMasAlto()
        {
            try
            {
                return ListarUsuarios().Max(p => p.UsuarioID);
            }
            catch (Exception)
            {

                throw;
            }
 
        }

        public Usuario Login(string nombre,string contrasenya) {

            Usuario usuarioCoincidente = null;

            if (nombre == "cliente" && contrasenya == "1234")
            {
                try
                {
                    usuarioCoincidente = ListarUsuarios().Where(u => u.Nombre == nombre && u.Password == contrasenya && u.Email == "admin@tiendadam.es").First();
                }
                catch (Exception e){

                    return null;
                }

            }

            return usuarioCoincidente;
        }

        public Totales CalcularTotalPedido(List<Linped> linped)
        {
            Totales totales = new Totales();
            decimal sumaImporte = 0;

            foreach (Linped linea in linped)
            {
                sumaImporte += linea.Importe * (decimal)linea.Cantidad;
            }

            totales.TotalSinIVA = sumaImporte;
            totales.Total = sumaImporte * 1.21m;
            totales.IVA = totales.Total - totales.TotalSinIVA;
            return totales;
        }

        public void BorrarPedido(int id)
        {
            try
            {
                _datPed.BorrarPedido(id);

            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool ModificarLinPed(Linped l)
        {
            try
            {
                if (!_datLinPed.ActualizarLinped(l))
                {
                    return AnyadirLinped(l);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnyadirPedido(int pedidoID, int usuarioID, DateTime fecha)
        {
            try
            {
                return _datPed.InsertarPedido(pedidoID, usuarioID, fecha);

            }
            catch (Exception)
            {

                throw;
            }        }

        public Usuario BuscarUsuario(int usuarioID)
        {
            try {
                return _datUsu.LeerUsuario(usuarioID.ToString());
            } catch {
            
                throw;
            }
        }

        public bool AnyadirLinped(Linped linped) {

            try
            {
                return _datLinPed.InsertarLinped(linped.ArticuloID, linped.PedidoID, linped.Linea, linped.Cantidad, linped.Importe);

            }
            catch (Exception)
            {

                throw;
            }            
        }

        public bool ModificarPed(Pedido ped)
        {

            try
            {
                return _datPed.ActualizarPedido(ped);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int PedidoMasAlto()
        {
            try
            {
                return ListarPedidos().Max(p => p.PedidoID);
            }
            catch (Exception)
            {

                throw;
            }
          
        }
    }

}
