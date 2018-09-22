using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = (float)1.3642;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        /// <summary>
        /// Conversion explicita del tipo Euro al tipo Dolar
        /// </summary>
        /// <param name="e">Objeto del tipo Euro a ser convertido</param>
        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() * Euro.GetCotizacion());
            return d;
        }

        /// <summary>
        /// Conversion explicita del tipo Euro al tipo Pesos
        /// </summary>
        /// <param name="e">Objeto del tipo Euro a ser convertido</param>
        public static explicit operator Pesos(Euro e)
        {
            Dolar d = (Dolar)e;
            return (Pesos)d;
        }

        /// <summary>
        /// Conversion implicita del tipo double al tipo Euro
        /// </summary>
        /// <param name="d">Valor del tipo double a ser convertido</param>
        public static implicit operator Euro(double d)
        {
            Euro e = new Euro(d);
            return e;
        }

        /// <summary>
        /// Sobrecarga del operador == compara cantidades entre los objetos del tipo Euro y Dolar
        /// </summary>
        /// <param name="e">Objeto del tipo Euro a ser comparado</param>
        /// <param name="d">Objeto del tipo Dolar a ser comparado</param>
        /// <returns></returns>
        public static bool operator ==(Euro e, Dolar d)
        {
            bool returnAux = false;
            if (e.GetCantidad() == d.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool returnAux = false;
            if (e.GetCantidad() == p.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool returnAux = false;
            if (e1.GetCantidad() == e2.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() + e.GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return ((Euro)p).GetCantidad() + p.GetCantidad();
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantidad() - e.GetCantidad();
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return ((Euro)p).GetCantidad() - e.GetCantidad();
        }
    }
}
