using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52_Boligrafo_Lapiz_Interface
{
    public class EscrituraWrapper
    {
        #region "Atributos"
        public ConsoleColor color;
        public string texto;
        #endregion

        #region "Constructores"
        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }
        #endregion
    }
}
