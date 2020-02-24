using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Capa_Entidades;
using Capa_Datos;
using System.Collections.ObjectModel;

//<author> Héctor Granja <author>

namespace Capa_Negocio
{
    public class Negocio
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
        private StockADO _datStock;
        private TipoArticuloADO _datTipo;


        //Contructor de la clase
        public Negocio()
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
            _datStock = new StockADO();
            _datTipo = new TipoArticuloADO();
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

                List<Pedido> listaAuxiliar = _datPed.LeerPedidos().Where(p => p.UsuarioID == usuarioBuscado.UsuarioId).ToList();

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


        public Dictionary<String, int> ArticulosMensuales(List<Pedido> pedidos)
        {

            List<Articulo> articulos = ListarArticulos();

            Dictionary<String, int> result = new Dictionary<string, int>();

            int tvs = 0;
            int memorias = 0;
            int camaras = 0;
            int objetivos = 0;

            foreach (Pedido p in pedidos)
            {
                foreach (Linped l in p.LineasPedido)
                {
                   Articulo art = articulos.Where(a => a.ArticuloID == l.ArticuloID).First();
                   switch (art.TipoArticuloID)
                    {
                        case 1:
                            tvs+=l.Cantidad;
                            break;
                        case 2:
                            memorias+=l.Cantidad;
                            break;
                        case 3:
                            camaras+=l.Cantidad;
                            break;
                        case 4:
                            objetivos+=l.Cantidad;
                            break;
                    }
                }
            }
            result.Add("TVs", tvs);
            result.Add("Memorias", memorias);
            result.Add("Camaras", camaras);
            result.Add("Objetivos", objetivos);
            return result;
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

           return ListarPedidos().Any(p=>p.UsuarioID == usu.UsuarioId);
          
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

        public List<TipoArticulo> ListarTipoArticulos()
        {
            try
            {
                List<TipoArticulo> listaTipoArticulos = _datTipo.LeerTipoArticulos();

                return listaTipoArticulos;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Camara> ListarCamaras()
        {
            try
            {
                return _datCam.LeerCamaras();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Memoria> ListarMemoria()
        {
            try
            {
                return _datMem.LeerMemorias();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Objetivo> ListarObjetivos()
        {
            try
            {
                return _datObj.LeerObjetivos();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Tv> ListarTvs()
        {
            try
            {
                return _datTv.LeerTvs();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public ObservableCollection<ArticulosPorTipo> ListarArticulosPorTipo()
        {
            List<TipoArticulo> tipos = ListarTipoArticulos();
            List<Articulo> articulos = ListarArticulos();
            List<Camara> camaras = ListarCamaras();
            List<Objetivo> objetivos = ListarObjetivos();
            List<Memoria> memorias = ListarMemoria();
            List<Tv> tvs = ListarTvs();

            List<ArticulosPorTipo> result = new List<ArticulosPorTipo>();

            foreach (TipoArticulo ti in tipos)
            {
                ArticulosPorTipo temp = new ArticulosPorTipo();
                temp.Nombre = ti.Descripcion;
                temp.ListaArticulos = new List<Articulo>();
                List<Articulo> arts = articulos.Where(a => a.TipoArticuloID == ti.TipoArticuloID).ToList();

                foreach (Articulo art in arts)
                {
                    Articulo artTemp;
                    if (art.TipoArticuloID == 1)
                    {
                        artTemp = tvs.Where(t => t.TvID == art.ArticuloID).First();
                    }
                    else if (art.TipoArticuloID == 2)
                    {
                        artTemp = memorias.Where(t => t.MemoriaID == art.ArticuloID).First();
                    }
                    else if (art.TipoArticuloID == 3)
                    {
                        artTemp = camaras.Where(t => t.CamaraID == art.ArticuloID).First();
                    }
                    else if (art.TipoArticuloID == 4)
                    {
                        artTemp = objetivos.Where(t => t.ObjetivoID == art.ArticuloID).First();
                    }
                    else
                    {
                        artTemp = art;
                    }
                    artTemp.ArticuloID = art.ArticuloID;
                    artTemp.Especificaciones = art.Especificaciones;
                    artTemp.Imagen = art.Imagen;
                    artTemp.MarcaID = art.MarcaID;
                    artTemp.Nombre = art.Nombre;
                    artTemp.Pvp = art.Pvp;
                    artTemp.TipoArticuloID = art.TipoArticuloID;
                    artTemp.Urlimagen = art.Urlimagen;


                    temp.ListaArticulos.Add(artTemp);

                }
                result.Add(temp);
            }

            return new ObservableCollection<ArticulosPorTipo>(result);
        }



        public Pedido ObtenerPedido(int pedidoID)
        {
            try
            {
                Pedido ped =_datPed.LeerPedido(pedidoID);
                ped.LineasPedido = _datLinPed.LeerLinped(pedidoID);
                return ped;
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
               usu.Calle, usu.Calle2, usu.Codpos, usu.PuebloID, usu.ProvinciaID, usu.Nacido, usu.UsuarioId);
            }
            catch (Exception e)
            {

                throw e;
            }
           

        }

      
        public bool BorrarUsuario(int id)
        {
            try
            {
            
                List<Pedido> listaPedidos = _datPed.LeerPedidos().Where(p => p.UsuarioID == id).ToList();
                foreach(Pedido ped in listaPedidos)
                {
                    BorrarPedido(ped.PedidoID);
                }
                return _datUsu.BorrarUsuario(id);
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
                return ListarUsuarios().Max(p => p.UsuarioId);
            }
            catch (Exception)
            {

                throw;
            }
 
        }

        public List<Stock> ListarStock(int cantidad)
        {
            return _datStock.LeerStocks().Where(s => s.Disponible <= cantidad && s.Disponible > 0 && s.Entrega != "Descatalogado").ToList();
        }

        public Usuario Login(string nombre,string contrasenya) {

            Usuario usuarioCoincidente;

                try
                {
                    usuarioCoincidente = ListarUsuarios().Where(u => u.Nombre == nombre && u.Password == contrasenya).First();
                }
                catch (Exception e){

                usuarioCoincidente = null;

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

        public Usuario BuscarUsuario(int usuarioId)
        {
            try {
                return _datUsu.LeerUsuario(usuarioId);
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
