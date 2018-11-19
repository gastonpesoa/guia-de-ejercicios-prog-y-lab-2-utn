using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_De_Extencion
{
    public static class Extensor
    {
        public static int CantidadDeDigitos(this long numero)
        {
            int cantidadDeDigitos = 0;
            foreach (char digito in numero.ToString())
            {
                cantidadDeDigitos++;
            }
            return cantidadDeDigitos;
        }
    }
}
