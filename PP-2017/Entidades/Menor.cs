using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Menor : Comensal
    {
        #region "Enumerado"
        public enum eMenu
        {
            Milanesa, Hamburguesa
        }
        #endregion

        #region "Atributos"
        private eMenu menu;
        #endregion

        #region "Propiedades"
        public eMenu Menu
        {
            get { return this.menu; }
            set { this.menu = value; }
        }
        #endregion

        #region "Constructores"
        private Menor(string nombre, string apellido)
            : base(apellido, nombre) { }

        public Menor(string nombre, string apellido, eMenu menu)
            :this(nombre, apellido)
        {
            this.Menu = menu;
        }
        #endregion

        #region "Metodos"
        public override string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1}", base.Mostrar(), this.Menu);
            return s.ToString();
        }
        #endregion

        #region "Sobrecargas"
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return this == (Menor)obj;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Menor a, Menor b)
        {
            return (a.Nombre.CompareTo(b.Nombre) == 0 && a.Apellido.CompareTo(b.Apellido) == 0 && a.Menu.CompareTo(b.Menu) == 0);
        }

        public static bool operator !=(Menor a, Menor b)
        {
            return !(a == b);
        }
        #endregion
    }
}
