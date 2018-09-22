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
            : this()
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
            Euro e = new Euro(d.GetCantidad() / Euro.GetCotizacion());
            return e;
        }

        /// <summary>
        /// Conversion explicita del tipo Dolar al tipo Pesos
        /// </summary>
        /// <param name="d">Objeto Dolar a ser convertido</param>
        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
            return p;
        }

        /// <summary>
        /// Conversion implicita del tipo double al tipo Dolar
        /// </summary>
        /// <param name="d">Valor del tipo double a ser convertido</param>
        public static implicit operator Dolar(double d)
        {
            Dolar temp = new Dolar(d);
            return temp;
        }

        /// <summary>
        /// Sobrecarga del operador == compara igualdad de cantidades de objetos del tipo Dolar y Euro
        /// </summary>
        /// <param name="d">Objeto Dolar a ser comparado</param>
        /// <param name="e">Objeto Euro a ser comparado</param>
        /// <returns></returns>
        public static bool operator ==(Dolar d, Euro e)
        {
            bool returnAux = false;
            if (d.GetCantidad() == e.GetCantidad())
            {
                returnAux = true;
            }
            return returnAux;
        }

        /// <summary>
        /// Sobrecarga del operador == compara igualdad de objetos de tipo Dolar y Pesos
        /// </summary>
        /// <param name="d">Objeto Dolar a ser comparado</param>
        /// <param name="p">Objeto Pesos a ser comparado</param>
        /// <returns></returns>
        public static bool operator ==(Dolar d, Pesos p)
        {
            bool returnAux = false;
            if (d.GetCantidad() == p.GetCantidad())
            {
                return true;
            }
            return returnAux;
        }

        /// <summary>
        /// Sobrecarga del operador == compara igualdad de objetos de tipo Dolar
        /// </summary>
        /// <param name="d1">Primer objeto Dolar a ser comparado</param>
        /// <param name="d2">Segundo objeto Dolar a ser comparado</param>
        /// <returns></returns>
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool returnAux = false;
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }
            return returnAux;
        }

        /// <summary>
        /// Sobrecarga del operador != compara desigualdad de cantidades de objetos de tipo Dolar y Euro
        /// </summary>
        /// <param name="d">Objeto Dolar a ser comparado</param>
        /// <param name="e">Objeto Euro a ser comparado</param>
        /// <returns></returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        /// <summary>
        /// Sobrecarga del operador != compara desigualdad de cantidades de objetos de tipo Dolar y Pesos
        /// </summary>
        /// <param name="d">Objeto Dolar a ser comparado</param>
        /// <param name="p">Objeto Pesos a ser comparado</param>
        /// <returns></returns>
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        /// <summary>
        /// Sobrecarga del operador != compara desigualdad de cantidades de objetos de tipo Dolar
        /// </summary>
        /// <param name="d1">Primer objeto Dolar a ser comparado</param>
        /// <param name="d2">Segundo objeto Dolar a ser comparado</param>
        /// <returns></returns>
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        /// <summary>
        /// Sobrecarga del operador + suma objetos Dolar y Euro previa conversion a tipo Dolar
        /// </summary>
        /// <param name="d">Objeto Dolar a ser sumado</param>
        /// <param name="e">Objeto del tipo Euro a ser convertido a tipo Dolar y sumado</param>
        /// <returns>Resultado de la suma en tipo Dolar</returns>
        public static Dolar operator +(Dolar d, Euro e)
        {
            return ((Dolar)e).GetCantidad() + d.GetCantidad();
        }

        /// <summary>
        /// Sobrecarga del operador + suma objetos Dolar y Pesos previa conversion a tipo Dolar
        /// </summary>
        /// <param name="d">Objeto Dolar a ser sumado</param>
        /// <param name="p">Objeto del tipo Pesos a ser convertido a tipo Dolar y sumado</param>
        /// <returns>Resultado de la suma en tipo Dolar</returns>
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return ((Dolar)p).GetCantidad() + d.GetCantidad();
        }

        /// <summary>
        /// Sobrecarga del operador - resta objetos Dolar y Euro previa conversion a tipo Dolar
        /// </summary>
        /// <param name="d">Objeto Dolar a ser restado</param>
        /// <param name="e">Objeto del tipo Euro a ser convertido a tipo Dolar y restado</param>
        /// <returns>Resultado de la resta en tipo Dolar</returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            return ((Dolar)e).GetCantidad() - d.GetCantidad();
        }

        /// <summary>
        /// Sobrecarga del operador - resta objetos Dolar y Pesos previa conversion a tipo Dolar
        /// </summary>
        /// <param name="d">Objeto Dolar a ser restado</param>
        /// <param name="p">Objeto del tipo Pesos a ser convertido a tipo Dolar y restado</param>
        /// <returns>Resultado de la resta en tipo Dolar</returns>
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return ((Dolar)p).GetCantidad() - d.GetCantidad();
        }
    }
}
