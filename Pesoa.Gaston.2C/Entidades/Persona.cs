using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region "Atributos"
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        #endregion

        #region "Propiedades"
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region "Constructor"
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Expone datos de la instancia
        /// </summary>
        /// <returns>string con los datos de la instancia</returns>
        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Apellido: {0}\nNombre: {1}\nDni: {2}\nEdad: {3}\n", this.Apellido, this.Nombre, this.Dni, this.Edad);
            return s.ToString();
        }
        /// <summary>
        /// Metodo abstracto que se implementara en clases derivadas
        /// </summary>
        /// <returns></returns>
        public abstract bool ValidarAptitud();
        #endregion
    }
}
