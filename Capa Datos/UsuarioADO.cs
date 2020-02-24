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
    public class UsuarioADO : ADO
    {

        // Leo todos los usuarios dela BD
        public List<Usuario> LeerUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/usuarios").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return listaUsuarios;
        }
        public Usuario LeerUsuario(int id)
        {
            Usuario usu = new Usuario();
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/usuarios/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    usu = JsonConvert.DeserializeObject<Usuario>(aux);
                }
            }
            catch (Exception e)
            {
                throw new ExternalException("Error:" + e);
            }

            return usu;
        }
        // Creo un nuevo usuario en la BD
        public bool InsertarUsuario(string nombre, string apellidos, string email, string password, string dni, string telefono, string calle, string calle2, string codPos, string puebloID, string provinciaId, DateTime? nacido, int usuarioId)
        {
            try
            {
                Usuario usu = new Usuario(nombre, apellidos, email, password, dni, telefono, calle, calle2, codPos, puebloID, provinciaId, nacido, usuarioId);

                HttpResponseMessage response = client.PostAsJsonAsync("api/usuarios", usu).Result;
                //var response = client.PostAsync("api/usuarios", new StringContent(new JavaScriptSerializer().Serialize(usu), Encoding.UTF8, "application/json")).Result;
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
                throw;
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                HttpResponseMessage response = client.PutAsJsonAsync("api/usuarios/" + usuario.UsuarioId, usuario).Result;

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

        public bool BorrarUsuario(int id)
        {
            try
            {

                HttpResponseMessage response = client.DeleteAsync("api/usuarios/" + id).Result;

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
