using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_39_Sobreescrito_Abstract
{
    public class SobreSobreescrito : Sobreescrito
    {

        #region Propiedad

        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }

        #endregion

        #region Metodos 

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }

        #endregion
    }
}
