using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
   public class Tv: Articulo
    {
        //Atributos

        private string _TvID;
        private string _panel;
        private string _resolucion;
        private string _hdreadyfullhd;
        private int? _pantalla;
        private bool? _tdt;

        //Constructor vacío
        public Tv()
        {
            _TvID = "";
            _panel = "";
            _resolucion = "";
            _hdreadyfullhd = "";
        
        }

        //Constructor con parámetros
        public Tv(string tvId, string panel, string resolucion, string hdReadyFullHd, int? pantalla, bool? tdt)
        {
            TvID = tvId;
            Panel = panel;
            Resolucion = resolucion;
            Hdreadyfullhd = hdReadyFullHd;
            Pantalla = pantalla;
            Tdt = tdt;
        }

        //Constructor copia
        public Tv(Tv tv)
        {
            _TvID = tv.TvID;
            _panel = tv.Panel;
            _resolucion = tv.Resolucion;
            _hdreadyfullhd = tv.Hdreadyfullhd;
            _pantalla = tv.Pantalla;
            _tdt = tv.Tdt;
        }

        //Destructor
        ~Tv()
        {
            _TvID = null;
            _panel = null;
            _resolucion = null;
            _hdreadyfullhd = null;
            _pantalla = null;
            _tdt = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string TvID
        {
            get => _TvID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 7 && !string.IsNullOrWhiteSpace(value))
                {
                    _TvID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'TvID'");
                }
         
            }
        }
        public string Panel
        {
            get => _panel; set
            {
                //Compruebo que respete la cantidad máxima de caracteres

                if (value.Length <= 45)
                {
                    _panel = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'panel'");
                }
            }
        }
        public string Resolucion
        {
            get => _resolucion; set
            {
                //Compruebo que respete la cantidad máxima de caracteres

                if (value.Length <= 15)
                {
                    _resolucion = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'resolucion'");
                }
              
            }
        }
        public string Hdreadyfullhd
        {
            get => _hdreadyfullhd; set
            {
                //Compruebo que respete la cantidad máxima de caracteres

                if (value.Length <= 6)
                {
                    _hdreadyfullhd = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'hdreadyfullhd'");
                }
            }
        }
        public int? Pantalla
        {
            get => _pantalla; set
            {
                //Compruebo que respete el valor máximo y mínimo y que pueda ser null

                if (value <= 999999 && value >= 0 || !value.HasValue)
                {
                    _pantalla = value;
                }
                else
                {
                    throw new ArgumentException("Valor numérico incorrecto para 'pantalla'");
                }
               
            }
        }
        public bool? Tdt
        {
            get => _tdt; set { _tdt = value;}
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return base.ToString() + ", " +_resolucion + ".";
        }
    }
}
