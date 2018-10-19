using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesContabilidad
{
    public class Documento
    {
        #region "Atributos"
        private int numero;
        #endregion

        #region "Propiedad"
        public int Numero
        {
            get { return this.numero; }
        }
        #endregion

        #region "Constructor"
        public Documento(int numero)
        {
            this.numero = numero;
        }
        #endregion
    }
}
