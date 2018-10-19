using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_47_Torneo_Generics
{
    public class EquipoFutbol : Equipo
    {
        #region "Constructor"
        public EquipoFutbol(string nombre, DateTime fecha)
            : base(nombre, fecha) { }
        #endregion
    }
}
