using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35_Persona_DirectorTecnico_Jugador
{
    public class DirectorTecnico : Persona
    {
        #region Atributos

        private DateTime fechaNacimiento;
        #endregion

        #region Propiedades

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }
        #endregion

        #region Constructores

        private DirectorTecnico(string nombre)
            :base(nombre){ }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return ((dt1.Nombre) == (dt2.Nombre) && (dt1.fechaNacimiento) == (dt2.fechaNacimiento));
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
        #endregion

        #region Metodos

        public new string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("DT\nNombre: {0}\nFecha Nacimiento: {1}",this.Nombre, this.fechaNacimiento);
            return s.ToString();
        }
        #endregion
    }
}
