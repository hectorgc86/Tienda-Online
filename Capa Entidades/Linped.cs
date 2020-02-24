using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Linped
    {
        //Atributos

       private string _articuloID;
       private int _PedidoID;
       private int _linea;
       private int _cantidad;
       private decimal _importe;

        //Constructor vacío
        public Linped()
        {
            _articuloID = "";
            _PedidoID = 0;
            _linea = 0;
            _importe = 0;
        }

        //Constructor con parámetros
        public Linped(string articuloID, int pedidoID, int linea, int cantidad, decimal importe)
        {
            ArticuloID = articuloID;
            PedidoID = pedidoID;
            Linea = linea;
            Cantidad = cantidad;
            Importe = importe;
        }

        //Constructor copia
        public Linped(Linped linped)
        {
            _articuloID = linped.ArticuloID;
            _PedidoID = linped.PedidoID;
            _linea = linped.Linea;
            _cantidad = linped.Cantidad;
            _importe = linped.Importe;
        }

        //Destructor
        ~Linped()
        {
            _articuloID = null;
            _cantidad = 0;
            _PedidoID = 0;     
            _linea = 0;
            _importe = 0;
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
        public int PedidoID
        {
            get => _PedidoID; set
            {
                //Compruebo que respete el valor máximo y mínimo 
                if (value <= 999999999 && value > 0)
                {
                    _PedidoID = value;
                }
                else
                {
                    throw new ArgumentException("Valor numérico incorrecto para 'PedidoID'");
                }
               
            }
        }
        public int Linea
        {
            get => _linea; set
            {
                //Compruebo que respete el valor máximo y mínimo 
                if (value <= 999999999 && value > 0)
                {
                    _linea = value;
                }
                else
                {
                    throw new ArgumentException("Valor numérico incorrecto para 'linea'");
                }
                
            }
        }
        public int Cantidad
        {
            get => _cantidad; set
            {
                //Compruebo que respete el valor máximo y mínimo 
                if (value <= 999999999 && value >= 0 )
                {
                    _cantidad = value;
                }
                else
                {
                    throw new ArgumentException("Valor numérico incorrecto para 'cantidad'");
                }
               
            }
        }
        public decimal Importe
        {
                get => _importe; set
            {
                //Compruebo que respete el valor máximo y mínimo 
                if (value <= 999999999.99m && value >=-999999999.99m)
                    {
                        _importe = value;
                    }
                    else
                    {
                        throw new ArgumentException("Valor numérico incorrecto para 'importe'");
                    }
            
            }
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _articuloID + "#" + _PedidoID + "#" + _linea + "#" + _cantidad + "#" + _importe;
        }
    }
}
