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
    public class CamaraADO : ADO
    {

        // Leo todas las Camaras de la BD
        public List<Camara> LeerCamaras()
        {
            List<Camara> listaCamaras = new List<Camara>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/camaras").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaCamaras = JsonConvert.DeserializeObject<List<Camara>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaCamaras;
        }
        public Camara LeerCamara(string id)
        {
            Camara camara = new Camara();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/camaras/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    camara = JsonConvert.DeserializeObject<Camara>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return camara;
        }
        // Creo una nueva Camara en la BD
        public bool InsertarCamara(string camaraID, string resolucion, string sensor, string tipo, string factor, string objetivo, string pantalla, string zoom)
        {
            try
            {
                Camara cam = new Camara(camaraID, resolucion, sensor, tipo, factor, objetivo, pantalla, zoom);

                HttpResponseMessage response = client.PostAsJsonAsync("api/camaras",cam).Result;
                //var response = client.PostAsync("api/camaras", new StringContent(new JavaScriptSerializer().Serialize(cam), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarCamara(Camara camara)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/camaras/"+camara.CamaraID, camara).Result;

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

        public bool BorrarCamara(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/camaras/"+id).Result;

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
