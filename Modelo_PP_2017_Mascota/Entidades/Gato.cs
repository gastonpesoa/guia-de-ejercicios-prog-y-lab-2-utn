using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region "Constructor
        public Gato(string nombre, string raza)
            : base(nombre, raza) { }
        #endregion

        #region "Metodos"
        protected override string Ficha()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}", base.DatosCompletos());
            return s.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool returnAux = false;
            if ((Gato)obj == this)
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return (obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza);
        }

        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
        #endregion

    }
}
