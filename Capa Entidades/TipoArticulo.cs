using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class TipoArticulo
    {
        //Atributos

        private int _tipoArticuloID;
        private string _Descripcion;


        //Constructor vacío
        public TipoArticulo()
        {
            TipoArticuloID = 0;
            _Descripcion = "";
        }

        //Constructor con parámetros
        public TipoArticulo(int tipoArticuloID, string descripcion)
        {
            TipoArticuloID = tipoArticuloID;
            Descripcion = descripcion;
        }

        //Constructor copia
        public TipoArticulo(TipoArticulo tipoArticulo)
        {
            TipoArticuloID = tipoArticulo.TipoArticuloID;
            _Descripcion = tipoArticulo.Descripcion;
        }

        //Destructor
        ~TipoArticulo()
        {
            TipoArticuloID = 0;
            _Descripcion = null;
        }

        //Getters y Setters
        public string Descripcion
        {
            get => _Descripcion; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                  ni nulo ni todo espacios en blanco*/
                if (value.Length <= 8 && !string.IsNullOrWhiteSpace(value))
                {
                    _Descripcion = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'Descripcion'");
                }
            }
        }

        public int TipoArticuloID { get => _tipoArticuloID; set => _tipoArticuloID = value; }


        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + TipoArticuloID + "#" + _Descripcion;
        }
    }
}
