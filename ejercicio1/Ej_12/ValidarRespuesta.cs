using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool returnAux = false;

            if(c == 'S')
            {
                returnAux = true;
            }
            return returnAux;
        }
    }
}
