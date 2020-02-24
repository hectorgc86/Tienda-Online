using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Objetivo
    {
        //Atributos

        private string _ObjetivoID;
        private string _tipo;
        private string _montura;
        private string _focal;
        private string _apertura;
        private string _especiales;

         //Constructor vacío
        public Objetivo()
        {
            _ObjetivoID = "";
            _tipo = "";
            _montura = "";
            _focal = "";
            _apertura = "";
            _especiales = "";
        }

        //Constructor con parámetros
        public Objetivo(string objetivoId, string tipo, string montura, string focal, string apertura, string especiales)
        {
            ObjetivoID = objetivoId;
            Tipo = tipo;
            Montura = montura;
            Focal = focal;
            Apertura = apertura;
            Especiales = especiales;
        }

        //Constructor copia
        public Objetivo(Objetivo objetivo)
        {
            _ObjetivoID = objetivo.ObjetivoID;
            _tipo = objetivo.Tipo;
            _montura = objetivo.Montura;
            _focal = objetivo.Focal;
            _apertura = objetivo.Apertura;
            _especiales = objetivo.Especiales;
        }

        //Destructor
        ~Objetivo()
        {
            _ObjetivoID = null;
            _tipo = null;
            _montura = null;
            _focal = null;
            _apertura = null;
            _especiales = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string ObjetivoID
        {
            get => _ObjetivoID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                ni nulo ni todo espacios en blanco*/
                if (value.Length <= 7 && !string.IsNullOrWhiteSpace(value))
                {
                    _ObjetivoID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'ObjetivoID'");
                }
            }
        }
        public string Tipo
        {

            get => _tipo; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 15)
                {
                    _tipo = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'tipo'");
                }
              
            }
        }
        public string Montura
        {
            get => _montura; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 15)
                {
                    _montura = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'montura'");
                }
            }
        }
        public string Focal
        {
            get => _focal; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 10)
                {
                    _focal = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'focal'");
                }
            }
        }
        public string Apertura
        {
            get => _apertura; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 10)
                {
                    _apertura = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'apertura'");
                }
            }
        }
        public string Especiales
        {
            get => _especiales; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 35)
                {
                    _especiales = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'especiales'");
                }
            }
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _ObjetivoID + "#" + _tipo + "#" + _montura + "#" + _focal + "#" + _apertura + "#" + _especiales;
        }
    }
}
