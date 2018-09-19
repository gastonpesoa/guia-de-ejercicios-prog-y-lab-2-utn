using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_13
{
    class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double binarioADecimal = Conversor.BinarioDecimal((string)b);
            return Conversor.DecimalBinario(binarioADecimal + (double)d);
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double binarioADecimal = Conversor.BinarioDecimal((string)b);
            return Conversor.DecimalBinario(binarioADecimal - (double)d);
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            bool returnAux = false;
            if (Conversor.BinarioDecimal((string)b) == (double)d)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario b)
        {
            return b.numero;
        }
    }
}
