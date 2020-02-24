using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Capa_Presentacion.Validadores
{
    public class DniRegla : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            bool error = true;
            string mensajeError = "";
            string dni = ((string)value);
            string estandarLetrasDni = "TRWAGMYFPDXBNJZSQVHLCKE";
            char[] charsDni = estandarLetrasDni.ToCharArray();

            if (dni.Length == 9)
            {
                string cadenaNumerosDni = dni.Substring(0, 8);
                string letraDni = dni.Substring(8, 1);
                string primercaracterDni = dni.Substring(0, 1);

                if (primercaracterDni.ToUpper() == "X")
                {
                    cadenaNumerosDni.ToUpper().Substring(0, 1).Replace("X", "0");

                }
                else if (primercaracterDni.ToUpper() == "Y")
                {
                    cadenaNumerosDni.ToUpper().Substring(0, 1).Replace("Y", "1");
                }
                else if (primercaracterDni.ToUpper() == "Z")
                {
                    cadenaNumerosDni.ToUpper().Substring(0, 1).Replace("Z", "2");
                }

                if (Int32.TryParse(cadenaNumerosDni, out int numerosDni))
                {
                    int restoCalculoDni = numerosDni % 23;
                    if (!(letraDni.ToUpper() == charsDni[restoCalculoDni].ToString())) {
                        error = false;
                        mensajeError += "Dni incorrecto.";
                    }
                }

            }
            return new ValidationResult(error, mensajeError);
        }
    }
}

