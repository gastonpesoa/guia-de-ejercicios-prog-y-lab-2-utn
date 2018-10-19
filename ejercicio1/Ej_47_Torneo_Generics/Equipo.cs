using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_47_Torneo_Generics
{
    public abstract class Equipo
    {
        #region "Atributos"
        private string nombre;
        private DateTime fechaCreacion;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string FechaCreacion
        {
            get
            {
                return this.fechaCreacion.ToString();
            }
        }
        #endregion

        #region "Constructor"
        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }
        #endregion

        #region "Metodos"
        public string Ficha()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} fundado el {1}", this.nombre, this.fechaCreacion);
            return s.ToString();
        }
        #endregion
    }
}
