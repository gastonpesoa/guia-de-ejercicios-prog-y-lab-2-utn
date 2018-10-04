using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region "Atributos"
        private int añosExperiencia;
        #endregion

        #region "Propiedades"
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        #endregion

        #region "Constructor"
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
            : base(nombre, apellido, edad, dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Expone datos de la instancia de Tipo DirectorTecnico
        /// </summary>
        /// <returns></returns>
        public new string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("\n{0}\nAños de Experiencia: {1}\n", base.Mostrar(), this.AñosExperiencia);
            return s.ToString();
        }
        /// <summary>
        /// Metodo para validar que la edad del DT sea menor a 65 y los años de experiencia 2 o mas
        /// </summary>
        /// <returns>true si cumple, false si no</returns>
        public override bool ValidarAptitud()
        {
            bool returnAux = false;
            if (this.Edad < 65 && this.AñosExperiencia >= 2)
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion
    }
}
