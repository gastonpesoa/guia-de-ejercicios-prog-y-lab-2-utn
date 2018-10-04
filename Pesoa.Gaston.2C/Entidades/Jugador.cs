using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region "Atributos"
        private float altura;
        private float peso;
        private Posicion posicion;
        #endregion

        #region "Propiedades"
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        #region "Constructor"
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            :base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Expone datos de la instancia de Tipo Jugador
        /// </summary>
        /// <returns>string con datos de la instancia</returns>
        public new string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}\nAltura: {1}\nPeso: {2}\nPosicion: {3}\n", base.Mostrar(), this.Altura, this.Peso, this.Posicion);
            return s.ToString();
        }
        /// <summary>
        /// Metodo que valida que el indice de masa corporal (IMC) se encuentre entre 18.5 y 25
        /// </summary>
        /// <returns>true en caso de que el indice se encuentre en el rango, false caso contrario</returns>
        public bool ValidarEstadoFisico()
        {
            bool returnAux = false;
            float IMC = this.Peso / (float)Math.Pow(this.Altura, 2);
            if (IMC >= 18.5 && IMC < 25)
            {
                returnAux = true;
            }
            return returnAux;
        }
        /// <summary>
        /// Metodo para validar estado fisico y que la edad no supere los 40 años
        /// </summary>
        /// <returns>true si cumple, false si no</returns>
        public override bool ValidarAptitud()
        {
            bool returnAux = false;
            if (this.ValidarEstadoFisico() && this.Edad < 40)
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion
    }
}
