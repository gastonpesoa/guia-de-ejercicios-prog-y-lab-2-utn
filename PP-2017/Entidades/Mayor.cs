using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mayor : Comensal
    {
        #region "Enumerados"
        public enum eBebidas
        {
            Agua, Cerveza, Vino, Gaseosa
        }
        #endregion

        #region "Atributos"
        private eBebidas bebida;
        #endregion

        #region "Propiedades"
        public eBebidas Bebida
        {
            get
            {
                return this.bebida;
            }
        }
        #endregion

        #region "Constructores"
        public Mayor(string nombre, string apellido, eBebidas bebida)
            :base(apellido, nombre)
        {
            this.bebida = bebida;
        }
        #endregion

        #region "Sobrecargas"
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} {2}", this.Nombre, this.Apellido, this.Bebida);
            return s.ToString();
        }

        public override bool Equals(object obj)
        {
            return this == (Mayor)obj;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Mayor a, Mayor b)
        {
            return (a.Nombre.CompareTo(b.Nombre) == 0 && a.Nombre.CompareTo(b.Nombre) == 0);
        }

        public static bool operator !=(Mayor a, Mayor b)
        {
            return !(a == b);
        }
        #endregion
    }
}
