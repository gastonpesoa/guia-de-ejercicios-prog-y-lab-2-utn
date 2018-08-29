using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_13
{
    class Conversor
    {
        public static string DecimalBinario(double numeroDecimal)
        {
            string numeroBinario = "";
            double cociente = numeroDecimal / 2;
            double resto = numeroDecimal % 2;

            while (cociente > 0)
            {

                if (resto > 0)
                {
                    numeroBinario = numeroBinario + "1";
                }
                else
                {
                    if(resto == 0)
                    {
                        numeroBinario = numeroBinario + "0";
                    }
                }
                cociente = cociente / 2;
                resto = cociente % 2;
            }
            return numeroBinario;
        } 
    }
}
