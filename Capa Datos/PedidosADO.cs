using System;
using System.Collections.Generic;
using Capa_Entidades;

// Para contactar con la WEB API
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

//<author> Héctor Granja <author>

namespace Capa_Datos
{
    public class PedidosADO : ADO
    {

        // Leo todos los Pedidos dela BD
        public List<Pedido> LeerPedidos()
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/pedidos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaPedidos = JsonConvert.DeserializeObject<List<Pedido>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaPedidos;
        }
        public Pedido LeerPedido(int id)
        {
            Pedido pedido = new Pedido();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/pedidos/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    pedido = JsonConvert.DeserializeObject<Pedido>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return pedido;
        }
        // Creo un nuevo Pedido en la BD
        public bool InsertarPedido(int pedidoId, int usuarioId, DateTime fecha)
        {
            try
            {
                Pedido ped = new Pedido(pedidoId, usuarioId, fecha);

                HttpResponseMessage response = client.PostAsJsonAsync("api/pedidos",ped).Result;
                //var response = client.PostAsync("api/pedidos", new StringContent(new JavaScriptSerializer().Serialize(ped), Encoding.UTF8, "application/json")).Result;
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }
        public bool ActualizarPedido(Pedido pedido)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/pedidos/"+ pedido.PedidoID, pedido).Result;
                

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }
        }

        public bool BorrarPedido(int id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/pedidos/"+id).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }
        }

    }
}
