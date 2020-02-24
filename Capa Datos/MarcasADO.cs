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
    public class MarcasADO : ADO
    {

        // Leo todas las Marcas dela BD
        public List<Marca> LeerMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/marcas").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaMarcas = JsonConvert.DeserializeObject<List<Marca>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaMarcas;
        }
        public List<Marca> LeerMarca(string id)
        {
            List<Marca> listaMarcas = new List<Marca>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/marcas/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaMarcas = JsonConvert.DeserializeObject<List<Marca>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaMarcas;
        }
        // Creo una nueva Marca en la BD
        public bool InsertarMarca(string marcaID, string empresa, byte[] logo)
        {
            try
            {
                Marca marc = new Marca(marcaID, empresa, logo);

                HttpResponseMessage response = client.PostAsJsonAsync("api/marcas",marc).Result;
                //var response = client.PostAsync("api/marcas", new StringContent(new JavaScriptSerializer().Serialize(marc), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarMarca(Marca marca)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/marcas/"+marca.MarcaID, marca).Result;

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

        public bool BorrarMarca(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/marcas/"+id).Result;

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
