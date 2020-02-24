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
    public class LocalidadesADO : ADO
    {

        // Leo todas las Localidades de la BD
        public List<Localidad> LeerLocalidades()
        {
            List<Localidad> listaLocalidades = new List<Localidad>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/localidades").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaLocalidades = JsonConvert.DeserializeObject<List<Localidad>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaLocalidades;
        }
        public Localidad LeerLocalidad(string id)
        {
            Localidad localidad = new Localidad();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/localidades/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    localidad = JsonConvert.DeserializeObject <Localidad>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return localidad;
        }
        // Creo una nueva Localidad en la BD
        public bool InsertarLocalidad(string localidadID, string nombre, string provinciaID)
        {
            try
            {
                Localidad loc = new Localidad(localidadID, nombre, provinciaID);

                HttpResponseMessage response = client.PostAsJsonAsync("api/localidades",loc).Result;
                //var response = client.PostAsync("api/localidades", new StringContent(new JavaScriptSerializer().Serialize(loc), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarLocalidad(Localidad localidad)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/localidades/"+localidad.LocalidadID, localidad).Result;

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

        public bool BorrarLocalidad(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/localidades/"+id).Result;

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
