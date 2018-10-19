using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_50_Interfaces
{
    public class GuardarTexto<T, V>
    {
        #region "Metodos"
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leído", typeof(V));
        }
        #endregion
    }
}
