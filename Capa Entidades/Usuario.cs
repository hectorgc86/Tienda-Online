using System;
using System.Collections.Generic;
using System.Text;

//<author> Héctor Granja <author>

namespace Capa_Entidades
{
    public class Usuario : IComparable<Usuario>
    {
        //Atributos

        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _password;
        private string _dni;
        private string _telefono;
        private string _calle;
        private string _calle2;
        private string _codPos;
        private string _puebloID;
        private string _provinciaID;
        private DateTime? _nacido;
        private int _usuarioID;

        //Constructor vacío
        public Usuario()
        {
            _nombre = "";
            _apellidos = "";
            _email = "";
            _password = "";
            _dni = "";
            _telefono = "";
            _calle = "";
            _calle2 = "";
            _codPos = "";
            _puebloID = "";
            _provinciaID = "";
            _usuarioID = 0;
        }

        //Constructor con parámetros
        public Usuario(string nombre, string apellidos, string email, string password, string dni, string telefono, string calle, string calle2, string codPos, string puebloID, string provinciaID, DateTime? nacido, int usuarioID)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
            Password = password;
            Dni = dni;
            Telefono = telefono;
            Calle = calle;
            Calle2 = calle2;
            Codpos = codPos;
            PuebloID = puebloID;
            ProvinciaID = provinciaID;
            Nacido = nacido;
            UsuarioID = usuarioID;
        }

        //Constructor copia
        public Usuario(Usuario usuario)
        {
            _nombre = usuario.Nombre;
            _apellidos = usuario.Apellidos;
            _email = usuario.Email;
            _password = usuario.Password;
            _dni = usuario.Dni;
            _telefono = usuario.Telefono;
            _calle = usuario.Calle;
            _calle2 = usuario.Calle2;
            _codPos = usuario.Codpos;
            _puebloID = usuario.PuebloID;
            _provinciaID = usuario.ProvinciaID;
            if (usuario.Nacido.HasValue) {
                _nacido = new DateTime(usuario.Nacido.Value.Ticks);
            } else {
                _nacido = null;
            }
      
            _usuarioID = usuario.UsuarioID;
        }

        //Destructor
        ~Usuario()
        {
            _nombre = null;
            _apellidos = null;
            _email = null;
            _password = null;
            _dni = null;
            _telefono = null;
            _calle = null;
            _calle2 = null;
            _codPos = null;
            _puebloID = null;
            _provinciaID = null;
            _nacido = null;
            _usuarioID = 0;
        }


        //Getters y Setters, con validaciones en los setter.
        public string Nombre
        {
            get => _nombre; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 35 && !string.IsNullOrWhiteSpace(value)) 

                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'nombre'");
                }
            }
        }
        public string Apellidos
        {
            get => _apellidos; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 55 && !string.IsNullOrWhiteSpace(value))
                {
                    _apellidos = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'apellidos'");
                }
            }
        }
        public string Email
        {
            get => _email; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 50 && !string.IsNullOrWhiteSpace(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'email'");
                }
               
            }
        }
        public string Password
        {
            get => _password; set
            {
                //Compruebo que respete la cantidad máxima de caracteres

                if (value.Length <= 32)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'password'");
                }
              
            }
        }
        public string Dni
        {
            get => _dni; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 12 && !string.IsNullOrWhiteSpace(value))
                {
                    _dni = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'dni'");
                }
             
            }
        }
        public string Telefono
        {
            get => _telefono; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (value.Length <= 15)
                    {
                        _telefono = value;
                    }
                    else
                    {
                        throw new ArgumentException("Longitud de texto incorrecta para 'telefono'");
                    }
                }
               
            }
        }
        public string Calle
        {
            get => _calle; set
            {
                //Compruebo que respete la cantidad máxima de caracteres
                if (!string.IsNullOrWhiteSpace(value)) {
                    if (value.Length <= 45)
                    {
                        _calle = value;
                    }
                    else
                    {
                        throw new ArgumentException("Longitud de texto incorrecta para 'calle'");
                    }
                }
   
            }
        }
        public string Calle2
        {
            get => _calle2; set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    //Compruebo que respete la cantidad máxima de caracteres
                    if (value.Length <= 45)
                    {
                        _calle2 = value;
                    }
                    else
                    {
                        throw new ArgumentException("Longitud de texto incorrecta para 'calle2'");
                    }
                }
            }
        }
        public string Codpos
        {
            get => _codPos; set
            {
                //Compruebo que respete la cantidad máxima de caracteres

                if (value.Length <= 5)
                {
                    _codPos = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'codPos'");
                }
         
            }
        }
        public string PuebloID
        {
            get => _puebloID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 4 && !string.IsNullOrWhiteSpace(value))
                {
                    _puebloID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'puebloID'");
                }
             
            }
        }
        public string ProvinciaID
        {
            get => _provinciaID; set
            {
                /*Compruebo que respete la cantidad máxima de caracteres y que no sea
                 ni nulo ni todo espacios en blanco*/

                if (value.Length <= 2 && !string.IsNullOrWhiteSpace(value))
                {
                    _provinciaID = value;
                }
                else
                {
                    throw new ArgumentException("Longitud de texto incorrecta para 'provinciaID'");
                }
            }
        }
        public DateTime? Nacido
        {
            get => _nacido; set
            {
                /*Compruebo que no sea el valor mínimo de una fecha (osea, el valor inicial de un Datetime)*/
                if (!value.Equals(DateTime.MinValue))
                {
                    _nacido = value;
                }
                else
                {
                    throw new ArgumentException("La fecha no es una fecha válida");
                }
            }
        }
        public int UsuarioID { get; set; } //Propiedad sin setter por ser autoincremental por BBDD.


        //Sobrecarga del método ToString()
        public override string ToString()
        {
            return "#" + _nombre + "#" + _apellidos + "#" + _email + "#" + _password + "#" + _dni + "#" + _telefono
                + "#" + _calle + "#" + _calle2 + "#" + _codPos + "#" + _puebloID + "#" + _provinciaID + "#" + _nacido + "#" + _usuarioID;
        }

        //Método de comparación por email
        public int CompareTo(Usuario otroUsuario)
        {
            if (otroUsuario == null) return 1;

            if (otroUsuario.Email.CompareTo(_email) < 0)
                return 1;
            else

                if (otroUsuario.Email.CompareTo(_email) > 0)
                return -1;

            else
                return 0;
           
        }

       
    }
}
