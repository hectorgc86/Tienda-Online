using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Camara : Articulo
    {
        //Atributos

        private string _CamaraID;
        private string _resolucion;
        private string _sensor;
        private string _tipo;
        private string _factor;
        private string _objetivo;
        private string _pantalla;
        private string _zoom;

        //Constructor vacío
        public Camara()
        {
            _CamaraID = "";
            _resolucion = "";
            _sensor = "";
            _tipo = "";
            _factor = "";
            _objetivo = "";
            _pantalla = "";
            _zoom = "";
        }

        //Constructor con parámetros
        public Camara(string camaraID, string resolucion, string sensor, string tipo, string factor, string objetivo, string pantalla, string zoom)
        {
            CamaraID = camaraID;
            Resolucion = resolucion;
            Sensor = sensor;
            Tipo = tipo;
            Factor = factor;
            Objetivo = objetivo;
            Pantalla = pantalla;
            Zoom = zoom;
        }

        //Constructor copia
        public Camara(Camara camara)
        {
            _CamaraID = camara.CamaraID;
            _resolucion = camara.Resolucion;
            _sensor = camara.Sensor;
            _tipo = camara.Tipo;
            _factor = camara.Factor;
            _objetivo = camara.Objetivo;
            _pantalla = camara.Pantalla;
            _zoom = camara.Zoom;
        }

        //Destructor
        ~Camara()
        {
            _CamaraID = null;
            _resolucion = null;
            _sensor = null;
            _tipo = null;
            _factor = null;
            _objetivo = null;
            _pantalla = null;
            _zoom = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string CamaraID
        {
            get => _CamaraID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
               ni nulo ni todo espacios en blanco*/
                if (value.Length <= 7 && !string.IsNullOrWhiteSpace(value))
                {
                    _CamaraID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'CamaraID'");
                }

            }
        }
        public string Resolucion
        {
            get => _resolucion; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrEmpty(value) && value.Length <= 15)
                {
                    _resolucion = value;
                }

            }
        }
        public string Tipo
        {
            get => _tipo; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 45)
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'tipo'");
                }

            }
        }
        public string Factor
        {
            get => _factor; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrEmpty(value) && value.Length <= 10)
                {
                    _factor = value;
                }


            }
        }
        public string Objetivo
        {

            get => _objetivo; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrEmpty(value) && value.Length <= 15)
                {
                    _objetivo = value;
                }


            }
        }
        public string Pantalla
        {
            get => _pantalla; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrEmpty(value) && value.Length <= 20)
                {
                    _pantalla = value;
                }


            }
        }
        public string Zoom
        {
            get => _zoom; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrEmpty(value) && value.Length <= 40)
                {
                    _zoom = value;
                }

            }
        }

        public string Sensor
        {
            get => _sensor; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 40)
                {
                    _sensor = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'sensor'");
                }
            }
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return base.ToString() +  ", " + _tipo + ".";
        }

    }
}