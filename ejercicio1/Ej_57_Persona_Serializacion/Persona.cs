using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_57_Persona_Serializacion
{
    public class Persona
    {
        #region "Atributos"
        private string nombre;
        private string apellido;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        #endregion

        #region "Constructor"
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region "Metodos"
        //static bool Guardar(Persona p)
        //{
        //    tr
        //}
        #endregion
    }
}
