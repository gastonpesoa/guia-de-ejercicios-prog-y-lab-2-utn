using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
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
            Dolar d = new Dolar(e.GetCantidad() * Dolar.GetCotizacion());
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

        public static 
    }
}
