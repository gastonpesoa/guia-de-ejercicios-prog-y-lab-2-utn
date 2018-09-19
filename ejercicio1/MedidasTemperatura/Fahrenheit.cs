using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasTemperatura
{
    public class Fahrenheit
    {
        private double temperatura;

        static Fahrenheit()
        {
        }

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static implicit operator Fahrenheit(double temperatura)
        {
            return new Fahrenheit(temperatura);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetTemperatura() - 32) * ((double)5 / 9));
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetTemperatura() + 459.67) * ((double)5 / 9));
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool returnAux = false;
            if (f.GetTemperatura() == c.GetTemperatura())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        } 

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool returnAux = false;
            if (f.GetTemperatura() == k.GetTemperatura())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
    }
}
