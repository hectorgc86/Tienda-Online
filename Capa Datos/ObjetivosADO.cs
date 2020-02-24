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
    public class ObjetivosADO : ADO
    {

        // Leo todos los Objetivos dela BD
        public List<Objetivo> LeerObjetivos()
        {
            List<Objetivo> listaObjetivos = new List<Objetivo>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/objetivos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaObjetivos = JsonConvert.DeserializeObject<List<Objetivo>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaObjetivos;
        }
        public Objetivo LeerObjetivo(string id)
        {
            Objetivo obj = new Objetivo();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/objetivos/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    obj = JsonConvert.DeserializeObject<Objetivo>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return obj;
        }
        // Creo un nuevo Objetivo en la BD
        public bool InsertarObjetivo(string objetivoId, string tipo, string montura, string focal, string apertura, string especiales)
        {
            try
            {
                Objetivo obj = new Objetivo(objetivoId, tipo, montura, focal, apertura, especiales);

                HttpResponseMessage response = client.PostAsJsonAsync("api/objetivos",obj).Result;
                //var response = client.PostAsync("api/objetivos", new StringContent(new JavaScriptSerializer().Serialize(obj), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarObjetivo(Objetivo objetivo)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/objetivos/"+objetivo.ObjetivoID, objetivo).Result;

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

        public bool BorrarObjetivo(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/objetivos/"+id).Result;

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
