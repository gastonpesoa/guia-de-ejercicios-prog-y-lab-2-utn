using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52_Boligrafo_Lapiz_Interface
{
    public interface IAcciones
    {
        #region "Propiedades"
        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }
        #endregion

        #region "Metodos"
        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidades);
        #endregion
    }
}
