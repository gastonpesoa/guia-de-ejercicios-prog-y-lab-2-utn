using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_50_Interfaces
{
    public class Serializar<S, V>
    {
        #region "Metodos"
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto Leído", typeof(V));
        }
        #endregion
    }
}
