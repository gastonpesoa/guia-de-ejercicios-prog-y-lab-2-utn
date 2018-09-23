using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_39_Sobreescrito_Abstract
{
    public abstract class Sobreescrito
    {
        #region Atributo

        protected string miAtributo;

        #endregion

        #region Constructor

        protected Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        #endregion

        #region Propiedad

        public abstract string MiPropiedad { get; }

        #endregion

        #region Metodos 

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return obj is Sobreescrito;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

        public abstract string MiMetodo();

        #endregion

    }
}
