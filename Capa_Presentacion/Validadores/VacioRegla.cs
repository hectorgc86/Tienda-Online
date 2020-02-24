using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Capa_Presentacion.Validadores
{
    public class VacioRegla : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public bool Vacio { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int numeroCaracteres = 0;
            string mensajeError = "";
            bool error = true;
            
              numeroCaracteres = ((string)value).Length; 
           
            if (numeroCaracteres == 0 && !Vacio)
            {
                error = false;
                mensajeError += " El campo no puede estar vacío.\n";
            }
            if ((numeroCaracteres < Min) || (numeroCaracteres > Max))
            {
                error = false;
                mensajeError += "Introduzca un texto entre " + Min + " y " + Max + " carácteres.\n";
               
            }
            return new ValidationResult(error, mensajeError);
        }
    }
}

