using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Memoria
    {
        //Atributos

        private string _MemoriaID;
        private string _tipo;

        //Constructor vacío
        public Memoria()
        {
            _MemoriaID = "";
            _tipo = "";
        }

        //Constructor con parámetros
        public Memoria(string memoriaID, string tipo)
        {
            MemoriaID = memoriaID;
            Tipo = tipo;
        }

        //Constructor copia
        public Memoria(Memoria memoria)
        {
            _MemoriaID = memoria.MemoriaID;
            _tipo = memoria.Tipo;
        }

        //Destructor
        ~Memoria()
        {
            _MemoriaID = null;
            _tipo = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string MemoriaID
        {
            get => _MemoriaID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 7 && !string.IsNullOrWhiteSpace(value))
                {
                    _MemoriaID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'MemoriaID'");
                }
            }
        }
        public string Tipo
        {
            get => _tipo; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 30)
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'tipo'");
                }
            }
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _MemoriaID + "#" + _tipo;
        }
    }
}
