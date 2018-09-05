using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
           Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        /// <summary>
        /// Conversion explicita del tipo Dolar al tipo Euro
        /// </summary>
        /// <param name="d">Objeto Dolar a ser convertido</param>
        public static explicit operator Euro(Dolar d)
        {
            Euro temp = new Euro(d.GetCantidad());
            return temp;
        }

    }
}
