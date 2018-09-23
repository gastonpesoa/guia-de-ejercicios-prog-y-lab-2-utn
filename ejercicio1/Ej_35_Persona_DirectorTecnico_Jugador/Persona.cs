using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35_Persona_DirectorTecnico_Jugador
{
    public class Persona
    {
        #region Atributos

        private long dni;
        private string nombre;
        #endregion
        
        #region Propiedades

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region Constructores

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(long dni, string nombre)
            :this(nombre)
        {
            this.Dni = dni;
        }
        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Dni: {0}\nNombre: {1}", this.Dni, this.Nombre);
            return s.ToString();
        }
        #endregion
    }
}
