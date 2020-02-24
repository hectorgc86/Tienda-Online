using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Stock
    {
        //Atributos

        private string _articuloID;
        private int? _disponible;
        private string _entrega;
        private string[] _estadosEntrega = { "Descatalogado", "Próximamente", "24 horas", "3/4 días", "1/2 semanas" };

        //Constructor vacío
        public Stock()
        {
            _articuloID = "";
            _entrega = "";
        }

        //Constructor con parámetros
        public Stock(string articuloId, int? disponible, string entrega)
        {
            ArticuloID = articuloId;
            Disponible = disponible;
            Entrega = entrega;
        }

        //Constructor copia
        public Stock(Stock stock)
        {
            _articuloID = stock.ArticuloID;
            _disponible = stock.Disponible;
            _entrega = stock.Entrega;
        }

        //Destructor
        ~Stock()
        {
            _articuloID = null;
            _disponible = null;
            _entrega = null;
            _estadosEntrega = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string ArticuloID
        {
            get => _articuloID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 7 && !string.IsNullOrWhiteSpace(value))
                {
                    _articuloID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'articuloID'");
                }
            }
        }
        public int? Disponible
        {
            get => _disponible; set
            {
                //Compruebo que respete el valor máximo y mínimo 
                if (value <= 99999999999 && value >= 0)
                {
                    _disponible = value;
                }
                else
                {
                    throw new ArgumentException("Valor numérico incorrecto para 'disponible'");

                }

            }
        }
        public string Entrega
        {
            get => _entrega; set
            {
                //Compruebo que entrega coincida con alguno de los valores del set de estados posibles de entrega
                if(Array.IndexOf(_estadosEntrega,value) != -1)
                {
                    _entrega = value;
                }
                else
                {
                    throw new ArgumentException("Valor incorrecto para 'entrega'");
                }

            }
        }

        public string[] EstadosEntrega { get => _estadosEntrega; set => _estadosEntrega = value; }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _articuloID + "#" + _disponible + "#" + _entrega;
        }
    }
}
