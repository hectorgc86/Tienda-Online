using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Marca
    {
        //Atributos

       private string _marcaID;
       private string _empresa;

        //Propiedades autoimplementadas
       public byte[] Logo { get; set; }

        //Constructor vacío
        public Marca()
        {
            _marcaID = "";
            _empresa = "";
        }

        //Constructor con parámetros
        public Marca(string marcaID, string empresa, byte[] logo)
        {
            MarcaID = marcaID;
            Empresa = empresa;
            Logo = logo;
        }

        //Constructor copia
        public Marca(Marca marca)
        {
            _marcaID = marca.MarcaID;
            _empresa = marca.Empresa;
            Logo = AsignaLogo(marca.Logo);
        }

        //Destructor
        ~Marca()
        {
            _marcaID = null;
            _empresa = null;
            Logo = null;
        }

        //Getters y Setters, con validaciones en los setter.
        public string MarcaID
        {
            get => _marcaID;
            set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/
                if (value.Length <= 15 && !string.IsNullOrWhiteSpace(value))
                {
                    _marcaID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'marcaID'");
                }
            }
        }
        public string Empresa
        {
            get => _empresa;
            set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 60){
                    _empresa = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'empresa'");
                }
            }
        }

        //Método de asignación de un nuevo logo
        private byte[] AsignaLogo(byte[] logo)
        {
            byte[] nuevoLogo = new byte[logo.Length];
            for (int i = 0; i < logo.Length; i++)
            {
                nuevoLogo[i] = logo[i];
            }

            return nuevoLogo;
        }


        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _marcaID + "#" + _empresa + "#" + Logo;
        }
    }
}
