using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Capa_Presentacion.Validadores
{
    public class PasswordRegla : ValidationRule
    {
        public string Password { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            bool error = true;
            string mensajeError = "";
            string password = ((string)value);
           
            if (Password != password)
            {
                error = false;
                mensajeError += "Password no coincide.";
            }

          
            return new ValidationResult(error, mensajeError);
        }
    }
}

