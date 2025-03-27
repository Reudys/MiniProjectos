using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas.Models
{
    class ErrorMessage
    {
        //Error cuando el campo está vacío
        public string Error1 = "El campo está vacío";
        //Error cuando no se selecciona la temperatura en el btnRadio
        public string Error2 = "Debe seleccionar la temperatura inicial antes de convertir";
        //Error cuando se elige la misma temperatura en btnRadio y en el btn
        public string Error3 = "La temperatura no puede ser la misma";
    }
}
