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
    public class ArticulosADO : ADO
    {

        // Leo todos los Articulos dela BD
        public List<Articulo> LeerArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/articulos").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaArticulos = JsonConvert.DeserializeObject<List<Articulo>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaArticulos;
        }
        public Articulo LeerArticulo(string id)
        {
            Articulo articulo = new Articulo();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/articulos/"+id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    articulo = JsonConvert.DeserializeObject<Articulo>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return articulo;
        }
        // Creo un nuevo Articulo en la BD
        public bool InsertarArticulo(string articuloID, string nombre, string marcaID, string urlimagen, string especificaciones, int? tipoArticuloID, decimal? pvp, byte?[] imagen)
        {
            try
            {
                Articulo art = new Articulo(articuloID, nombre, marcaID, urlimagen, especificaciones, tipoArticuloID, pvp, imagen);

                HttpResponseMessage response = client.PostAsJsonAsync("api/articulos",art).Result;
                //var response = client.PostAsync("api/articulos", new StringContent(new JavaScriptSerializer().Serialize(art), Encoding.UTF8, "application/json")).Result;
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
        public bool ActualizarArticulo(Articulo articulo)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/articulos/"+articulo.ArticuloID, articulo).Result;

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

        public bool BorrarArticulo(string id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/articulos/"+id).Result;

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
