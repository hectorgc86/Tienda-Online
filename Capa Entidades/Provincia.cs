using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Provincia
    {
        //Atributos

        private string _ProvinciaID;
        private string _nombre;
        public List<Localidad> ListaLocalidades { get ; set ; }

        //Constructor vacío
        public Provincia()
        {
            _ProvinciaID = "";
            _nombre = "";
            ListaLocalidades = new List<Localidad>();
        }

        //Constructor con parámetros
        public Provincia(string provinciaId, string nombre)
        {
            ProvinciaID = provinciaId;
            Nombre = nombre;
            ListaLocalidades = new List<Localidad>();
        }

        //Constructor copia
        public Provincia(Provincia provincia)
        {
            _ProvinciaID = provincia.ProvinciaID;
            _nombre = provincia.Nombre;
            ListaLocalidades = new List<Localidad>();
            foreach (Localidad localidad in provincia.ListaLocalidades)
            {
                ListaLocalidades.Add(localidad);
            }
        }

        //Destructor
        ~Provincia()
        {
            _ProvinciaID = null;
            _nombre = null;
            ListaLocalidades.Clear();
            ListaLocalidades = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string ProvinciaID
        {
            get => _ProvinciaID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 2 && !string.IsNullOrWhiteSpace(value))
                {
                    _ProvinciaID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'ProvinciaID'");
                }
            }
        }
        public string Nombre
        {
            get => _nombre; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 25 && !string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'nombre'");
                }
            }
        }


        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _ProvinciaID + "#" + _nombre;
        }
    }
}
