using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 1 / (float)17.55;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d = new Dolar(p.GetCantidad() * Pesos.GetCotizacion());
            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar d = (Dolar)p;
            return (Euro)d;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos temp = new Pesos(d);
            return temp;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool returnAux = false;
            if (p.GetCantidad() == d.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool returnAux = false;
            if (p.GetCantidad() == e.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool returnAux = false;
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return ((Pesos)d).GetCantidad() + p.GetCantidad();
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return ((Pesos)e).GetCantidad() + p.GetCantidad();
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return ((Pesos)d).GetCantidad() - p.GetCantidad();
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return ((Pesos)e).GetCantidad() - p.GetCantidad();
        }
    }
}
