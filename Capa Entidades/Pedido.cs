using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Pedido
    {
        //Atributos

        private int _PedidoID;
        private int _usuarioID;
        private DateTime _fecha;
        public List<Linped> LineasPedido { get; set; }


        //Constructor vacío
        public Pedido()
        {
            _PedidoID = 0;
            _usuarioID = 0;
            _fecha = new DateTime();
            LineasPedido = new List<Linped>();
        }

        //Constructor con parámetros
        public Pedido(int pedidoId,int usuarioId, DateTime fecha)
        {
            PedidoID = pedidoId;
            UsuarioID = usuarioId;
            Fecha = fecha;
            LineasPedido = new List<Linped>();
            
        }

        //Constructor copia
        public Pedido(Pedido pedido)
        {
            _PedidoID = pedido.PedidoID;
            _usuarioID = pedido.UsuarioID;

            _fecha = new DateTime(pedido.Fecha.Ticks);

            LineasPedido = new List<Linped>(pedido.LineasPedido);
            foreach (Linped linped in pedido.LineasPedido)
            {
                LineasPedido.Add(linped);
            }
        }

        ~Pedido()
        {
            _PedidoID = 0;
            _usuarioID = 0;
            _fecha = DateTime.MinValue;
            LineasPedido.Clear();
            LineasPedido = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public int PedidoID
        {
            get => _PedidoID;
            set
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
        public int UsuarioID
        {
            get => _usuarioID; set
            {
                //Compruebo que respete el valor máximo y mínimo 
                if (value <= 999999999 && value > 0)
                {
                    _usuarioID = value;
                }
                else
                {
                    _usuarioID = 0;
                }
            }
        }
        public DateTime Fecha
        {
            get => _fecha; set
            {
                /*Compruebo que no sea el valor mínimo de una fecha (osea, el valor inicial de un Datetime)*/
                if (!value.Equals(DateTime.MinValue))
                {
                    _fecha = value;
                }
                else
                {
                    throw new ArgumentException("La fecha no es una fecha válida");
                }

            }
        }

       

        //Propiedad de solo lectura que devuelve el resultado de calcular todas las líneas
        public decimal ImporteTotal { get => CalculaImporte(); }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _PedidoID + "#" + _usuarioID + "#" + _fecha;
        }

        //Método que suma todas las lineas de pedido de un pedido
        private decimal CalculaImporte()
        {
            decimal sumaImporte = 0;

            foreach (Linped linea in LineasPedido)
            {
                sumaImporte += linea.Importe * (decimal)linea.Cantidad;
            }

            return sumaImporte;
        }
    }
}
