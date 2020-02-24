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
            _tipoArticuloID = 0;
            _Descripcion = "";
        }

        //Constructor con parámetros
        public TipoArticulo(int tipoArticuloId, string descripcion)
        {
            _tipoArticuloID = tipoArticuloId;
            Descripcion = descripcion;
        }

        //Constructor copia
        public TipoArticulo(TipoArticulo tipoArticulo)
        {
            _tipoArticuloID = tipoArticulo.TipoArticuloID;
            _Descripcion = tipoArticulo.Descripcion;
        }

        //Destructor
        ~TipoArticulo()
        {
            _tipoArticuloID = 0;
            _Descripcion = null;
        }

        //Getters y Setters
        public int TipoArticuloID{ get => _tipoArticuloID; } //Propiedad sin setter por ser autoincremental por BBDD.
        public string Descripcion
        {
            get => _Descripcion; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                  ni nulo ni todo espacios en blanco*/
                if (value.Length <= 7 && !string.IsNullOrWhiteSpace(value))
                {
                    _Descripcion = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'Descripcion'");
                }
            }
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _tipoArticuloID + "#" + _Descripcion;
        }
    }
}
