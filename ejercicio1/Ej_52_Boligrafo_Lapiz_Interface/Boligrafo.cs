using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52_Boligrafo_Lapiz_Interface
{
    public class Boligrafo : IAcciones
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

        #region "Metodos"
        public EscrituraWrapper Escribir(string texto)
        {
            foreach (char c in texto)
            {
                this.UnidadesDeEscritura -= 0.3F;
            }
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} {2}", "Boligrafo", this.Color, this.UnidadesDeEscritura);
            return s.ToString();
        }
        #endregion
    }
}
