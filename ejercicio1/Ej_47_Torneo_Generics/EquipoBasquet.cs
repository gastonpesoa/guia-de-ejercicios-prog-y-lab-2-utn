using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_47_Torneo_Generics
{
    public class EquipoBasquet : Equipo
    {
        #region "Constructor"
        public EquipoBasquet(string nombre, DateTime fecha)
            : base(nombre, fecha) { }
        #endregion
    }
}
