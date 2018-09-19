using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double binarioADecimal = Conversor.BinarioDecimal((string)b);
            return (double)d + binarioADecimal;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double binarioADecimal = Conversor.BinarioDecimal((string)b);
            return (double)d - binarioADecimal;
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            bool returnAux = false;
            if ((double)d == Conversor.BinarioDecimal((string)b))
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(NumeroDecimal d,NumeroBinario b)
        {
            return !(d == b);
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }
    }
}
