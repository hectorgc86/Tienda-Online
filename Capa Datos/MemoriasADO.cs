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
    public class MemoriasADO : ADO
    {

        // Leo todas las Memorias dela BD
        public List<Memoria> LeerMemorias()
        {
            List<Memoria> listaMemorias = new List<Memoria>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/memorias").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaMemorias = JsonConvert.DeserializeObject<List<Memoria>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaMemorias;
        }
        public Memoria LeerMemoria(string id)
        {
            Memoria memoria = new Memoria();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/memorias/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    memoria = JsonConvert.DeserializeObject<Memoria>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return memoria;
        }
        // Creo una nueva Memoria en la BD
        public bool InsertarMemoria(string memoriaID, string tipo)
        {
            try
            {
                Memoria mem = new Memoria(memoriaID, tipo);

                HttpResponseMessage response = client.PostAsJsonAsync("api/memorias",mem).Result;
                //var response = client.PostAsync("api/memorias", new StringContent(new JavaScriptSerializer().Serialize(mem), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarMemoria(Memoria memoria)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/memorias/"+memoria.MemoriaID, memoria).Result;

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

        public bool BorrarMemoria(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/memorias/"+id).Result;

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
