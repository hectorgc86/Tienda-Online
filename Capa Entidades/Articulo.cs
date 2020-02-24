using System;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Articulo
    {
        //Atributos

        private string _articuloID;
        private string _nombre;
        private string _marcaID;
        private string _urlimagen;
        private int? _tipoArticuloID;
        private decimal? _pvp;

        //Propiedades autoimplementadas
        public string Especificaciones { get; set; }
        public byte?[] Imagen { get; set; }

        //Constructor vacío
        public Articulo()
        {
            _articuloID = "";
            _nombre = "";
            _marcaID = "";
            _urlimagen = "";
        }

        //Constructor con parámetros
        public Articulo(string articuloID, string nombre, string marcaID, string urlimagen, string especificaciones, int? tipoArticuloID, decimal? pvp, byte?[] imagen)
        {
            ArticuloID = articuloID;
            Nombre = nombre;
            MarcaID = marcaID;
            Urlimagen = urlimagen;
            Especificaciones = especificaciones;
            TipoArticuloID = tipoArticuloID;
            Pvp = pvp;
            Imagen = imagen;
        }

        //Constructor copia
        public Articulo(Articulo articulo)
        {
            _articuloID = articulo.ArticuloID;
            _nombre = articulo.Nombre;
            _marcaID = articulo.MarcaID;
            _urlimagen = articulo.Urlimagen;
            Especificaciones = articulo.Especificaciones;
            _tipoArticuloID = articulo.TipoArticuloID;
            _pvp = articulo.Pvp;
            Imagen = AsignaImagen(articulo.Imagen);
        }

        //Destructor
        ~Articulo()
        {
            _articuloID = null;
            _nombre = null;
            _marcaID = null;
            _urlimagen = null;
            Especificaciones = null;
            _tipoArticuloID = null;
            _pvp = null;
            Imagen = null;
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
        public string Nombre
        {
            get => _nombre; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (value.Length <= 45)
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'nombre'");
                }

            }
        }
        public string MarcaID
        {
            get => _marcaID; set
            {
                if (value != null)
                {
                    //Compruebo que respete la cantidad máxima de caracteres
                    if (value.Length <= 15)
                    {
                        _marcaID = value;
                    }
                    else
                    {
                        throw new ArgumentException("Longitud de texto incorrecta para 'marcaID'");
                    }
                }

            }
        }
        public string Urlimagen
        {
            get => _urlimagen; set
            {
                if (value != null)
                {
                    //Compruebo que respete la cantidad máxima de caracteres
                    if (value.Length <= 100)
                    {
                        _urlimagen = value;
                    }
                    else
                    {
                        throw new ArgumentException("Longitud de texto incorrecta para 'urlimagen'");
                    }
                }
            }
        }

        public int? TipoArticuloID
        {
            get => _tipoArticuloID; set
            {
                if (value != null)
                {
                    //Compruebo que se respéten los valores máximo y mínimo y que pueda ser nulo
                    if (value <= 99999999999 && value > 0 || !value.HasValue)
                    {
                        _tipoArticuloID = value;
                    }
                    else
                    {
                        throw new ArgumentException("Valor numérico incorrecto para 'tipoArticuloID'");
                    }
                }
               
            }
        }

        public decimal? Pvp
        {
            get => _pvp; set
            {
                if (value!=null) {
                    //Compruebo que se respéten los valores máximo y mínimo
                    if (value <= 9999999.99m && value >= 0)
                    {
                        _pvp = value;
                    }
                    else
                    {
                        throw new ArgumentException("Valor numérico incorrecto para 'pvp'");
                    }
                }
            }
        }


        //Método de asignación de una nueva imagen creada
        private byte?[] AsignaImagen(byte?[] imagen)
        {
           byte?[]nuevaImagen = new byte?[imagen.Length];
            for (int i = 0; i < imagen.Length; i++)
            {
                nuevaImagen[i] = imagen[i];
            }

            return nuevaImagen;
        }

        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _articuloID + "#" + _nombre + "#" + _marcaID + "#" + _urlimagen + "#" + Especificaciones + "#" + _tipoArticuloID
                + "#" + _pvp + "#" + Imagen;
        }
    }
}
