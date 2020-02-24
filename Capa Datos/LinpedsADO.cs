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
    public class LinpedsADO : ADO
    {

        // Leo todas las Linpeds de la BD
        public List<Linped> LeerLinpeds()
        {
            List<Linped> listaLinpeds = new List<Linped>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/linpeds").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaLinpeds = JsonConvert.DeserializeObject<List<Linped>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaLinpeds;
        }
        public List<Linped> LeerLinped(string id)
        {
            List<Linped> listaLinpeds = new List<Linped>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/linpeds/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaLinpeds = JsonConvert.DeserializeObject<List<Linped>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaLinpeds;
        }
        // Creo un nuevo Linped en la BD
        public bool InsertarLinped(string articuloID, int pedidoID, int linea, int cantidad, decimal importe)
        {
            try
            {
                Linped linp = new Linped(articuloID, pedidoID, linea, cantidad, importe);

                HttpResponseMessage response = client.PostAsJsonAsync("api/linpeds", linp).Result;
                //var response = client.PostAsync("api/linpeds", new StringContent(new JavaScriptSerializer().Serialize(linp), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarLinped(Linped linped)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/linpeds/"+linped.PedidoID, linped).Result;

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

        public bool BorrarLinped(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/linpeds/"+id).Result;

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
