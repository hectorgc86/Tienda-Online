using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Capa_Presentacion.Validadores
{
    public class CPRegla : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            bool error = true;
            string mensajeError = "";
            string cp = ((string)value);
            if (!Int32.TryParse(cp, out int numero))
            {
                mensajeError += "* El campo 'Código Postal' debe ser numérico\n";
                error = false;
            }
            else if (cp.Length != 5)
            {
                mensajeError += "* El campo 'Código Postal' debe contener 5 caracteres\n";
                error = false;
            }

            return new ValidationResult(error, mensajeError);
        }
    }
}

