using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesContabilidad
{
    public class Recibo : Documento
    {
        #region "Constructores"
        public Recibo()
            : base(0) { }

        public Recibo(int numero)
            : base(numero) { }
        #endregion
    }
}
