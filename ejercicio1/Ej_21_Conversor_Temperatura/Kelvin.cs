using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_21_Conversor_Temperatura
{
    public class Kelvin
    {
        private double temperatura;

        static Kelvin()
        {
        }

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static implicit operator Kelvin(double temperatura)
        {
            return new Kelvin(temperatura);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetTemperatura() * ((double)9 / 5)) - 459.67);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Fahrenheit f = (Fahrenheit)k;
            return new Celsius((f.GetTemperatura() - 32) * ((double)5 / 9));
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            bool returnAux = false;
            if (k.GetTemperatura() == f.GetTemperatura())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            bool returnAux = false;
            if (k.GetTemperatura() == c.GetTemperatura())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
    }
}
