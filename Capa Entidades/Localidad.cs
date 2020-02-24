using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
   public class Localidad
    {
        //Atributos

        private string _localidadID;
        private string _nombre;
        private string _provinciaID;

        //Constructor vacío
        public Localidad()
        {
            _localidadID = "";
            _nombre = "";
            _provinciaID = "";
        }

        //Constructor con parámetros
        public Localidad(string localidadID, string nombre, string provinciaID)
        {
            LocalidadID = localidadID;
            Nombre = nombre;
            ProvinciaID = provinciaID;
        }

        //Constructor copia
        public Localidad(Localidad localidad)
        {
            _localidadID = localidad.LocalidadID;
            _nombre = localidad.Nombre;
            _provinciaID = localidad.ProvinciaID;
        }

        //Destructor
        ~Localidad()
        {
            _localidadID = null;
            _nombre = null;
            _provinciaID = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string LocalidadID
        {
            get => _localidadID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 4 && !string.IsNullOrWhiteSpace(value))
                {
                    _localidadID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'localidadID'");
                }
               
            }
        }

        public string Nombre
        {
            get => _nombre; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 50 && !string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'nombre'");
                }
               
            }
        }
        public string ProvinciaID
        {
            get => _provinciaID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 2 && !string.IsNullOrWhiteSpace(value))
                {
                    _provinciaID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'provinciaID'");
                }
            }
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _localidadID + "#" + _nombre + "#" + _provinciaID;
        }
    }
}
