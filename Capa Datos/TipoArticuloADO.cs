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
    public class TipoArticuloADO : ADO
    {

        // Leo todos los TipoArticulos dela BD
        public List<TipoArticulo> LeerTipoArticulos()
        {
            List<TipoArticulo> listaTipoArticulos = new List<TipoArticulo>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tipoarticulos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaTipoArticulos = JsonConvert.DeserializeObject<List<TipoArticulo>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaTipoArticulos;
        }
        public List<TipoArticulo> LeerTipoArticulo(int id)
        {
            List<TipoArticulo> listaTipoArticulos = new List<TipoArticulo>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/tipoarticulos/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaTipoArticulos = JsonConvert.DeserializeObject<List<TipoArticulo>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaTipoArticulos;
        }
        // Creo un nuevo TipoArticulo en la BD
        public bool InsertarTipoArticulo(int tipoArticuloId, string descripcion)
        {
            try
            {
                TipoArticulo tipoArt = new TipoArticulo(tipoArticuloId,descripcion);

                HttpResponseMessage response = client.PostAsJsonAsync("api/tipoarticulos", tipoArt).Result;
                //var response = client.PostAsync("api/tipoarticulos", new StringContent(new JavaScriptSerializer().Serialize(usu), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarTipoArticulo(TipoArticulo tipoArticulo)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/tipoarticulos/"+tipoArticulo.TipoArticuloID, tipoArticulo).Result;

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

        public bool BorrarTipoArticulo(int id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/tipoarticulos/"+id).Result;

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
