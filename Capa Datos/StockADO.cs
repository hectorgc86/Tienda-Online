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
    public class StockADO : ADO
    {

        // Leo todos los Stocks dela BD
        public List<Stock> LeerStocks()
        {
            List<Stock> listaStocks = new List<Stock>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/stock").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaStocks = JsonConvert.DeserializeObject<List<Stock>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaStocks;
        }
        public List<Stock> LeerStock(string id)
        {
            List<Stock> listaStocks = new List<Stock>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/stock/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaStocks = JsonConvert.DeserializeObject<List<Stock>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaStocks;
        }
        // Creo un nuevo Stock en la BD
        public bool InsertarStock(string articuloId, int? disponible, string entrega)
        {
            try
            {
                Stock st = new Stock(articuloId, disponible, entrega);

                HttpResponseMessage response = client.PostAsJsonAsync("api/stock",st).Result;
                //var response = client.PostAsync("api/stock", new StringContent(new JavaScriptSerializer().Serialize(st), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarStock(Stock stock)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/stock/"+stock.ArticuloID, stock).Result;

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

        public bool BorrarStock(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/stock/"+id).Result;

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
