using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_50_Interfaces
{
    public interface IGuardar<T, V>
    {
        #region "Metodos"
        bool GuardarTexto(Task obj);
        V Leer();
        #endregion
    }
}
