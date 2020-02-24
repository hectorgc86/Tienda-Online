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
    public class TvADO : ADO
    {

        // Leo todas las Tvs de la BD
        public List<Tv> LeerTvs()
        {
            List<Tv> listaTvs = new List<Tv>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tv").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaTvs = JsonConvert.DeserializeObject<List<Tv>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaTvs;
        }
        public Tv LeerTv(string id)
        {
            Tv tv = new Tv();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tv/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    tv = JsonConvert.DeserializeObject<Tv>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return tv;
        }
        // Creo un nuevo Tv en la BD
        public bool InsertarTv(string tvId, string panel, string resolucion, string hdReadyFullHd, int? pantalla, int? tdt)
        {
            try
            {
                Tv tv = new Tv(tvId, panel, resolucion, hdReadyFullHd, pantalla, tdt);

                HttpResponseMessage response = client.PostAsJsonAsync("api/tv",tv).Result;
                //var response = client.PostAsync("api/tv", new StringContent(new JavaScriptSerializer().Serialize(tv), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarTv(Tv tv)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/tv/"+tv.TvID, tv).Result;

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

        public bool BorrarTv(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/tv/"+id).Result;

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
