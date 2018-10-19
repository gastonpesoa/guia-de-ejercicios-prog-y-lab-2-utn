using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesContabilidad
{
    public class Factura : Documento
    {
        #region "Constructor"
        public Factura(int numero)
            : base(numero) { }
        #endregion
    }
}
