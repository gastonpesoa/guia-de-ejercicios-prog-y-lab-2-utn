using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52_Boligrafo_Lapiz_Interface
{
    public class Boligrafo
    {
        #region "Atributos"
        private ConsoleColor colorTinta;
        private float tinta;
        #endregion

        #region "Porpiedades"
        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }
        #endregion

        #region "Constructor"
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }
        #endregion
    }
}
