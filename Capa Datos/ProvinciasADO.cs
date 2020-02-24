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
    public class ProvinciasADO : ADO
    {

        // Leo todas las Provincias dela BD
        public List<Provincia> LeerProvincias()
        {
            List<Provincia> listaProvincias = new List<Provincia>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/provincias").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaProvincias = JsonConvert.DeserializeObject<List<Provincia>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaProvincias;
        }
        public List<Provincia> LeerProvincia(string id)
        {
            List<Provincia> listaProvincias = new List<Provincia>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/provincias/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaProvincias = JsonConvert.DeserializeObject<List<Provincia>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaProvincias;
        }
        // Creo una nueva Provincia en la BD
        public bool InsertarProvincia(string provinciaId, string nombre)
        {
            try
            {
                Provincia prov = new Provincia(provinciaId, nombre);

                HttpResponseMessage response = client.PostAsJsonAsync("api/provincias", prov).Result;
                //var response = client.PostAsync("api/provincias", new StringContent(new JavaScriptSerializer().Serialize(prov), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarProvincia(Provincia provincia)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/provincias/"+provincia.ProvinciaID, provincia).Result;

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

        public bool BorrarProvincia(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/provincias/"+id).Result;

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
