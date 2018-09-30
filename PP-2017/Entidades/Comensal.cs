using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Comensal
    {
        #region "Atributos"
        private string apellido;
        private string nombre;
        #endregion

        #region "Propiedades"
        public string Apellido
        {
            get { return this.apellido; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        #endregion

        #region "Constructores"
        public Comensal(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        #endregion

        #region "Metodos"
        public virtual string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1}", this.Nombre, this.Apellido);
            return s.ToString();
        }
        #endregion
    }
}
