using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasTemperatura
{
    public class Celsius
    {
        private double temperatura;

        static Celsius()
        {
        }

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static implicit operator Celsius(double temperatura)
        {
            return new Celsius(temperatura);
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetTemperatura() * ((double)9 / 5) + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((((Fahrenheit)c).GetTemperatura() + 459.67) * ((double)5 / 9));
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool returnAux = false;
            if (c.GetTemperatura() == f.GetTemperatura())
            {
                returnAux = true;
            }
            return returnAux;
        }
        
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool returnAux = false;
            if (c.GetTemperatura() == k.GetTemperatura())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
    }
}
