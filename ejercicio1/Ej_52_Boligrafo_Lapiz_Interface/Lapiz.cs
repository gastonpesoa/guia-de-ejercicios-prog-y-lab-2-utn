using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52_Boligrafo_Lapiz_Interface
{
    public class Lapiz : IAcciones
    {
        #region "Atributos"
        private float tamanioMina;
        #endregion

        #region "Propiedades"
        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }
        #endregion

        #region "Constructor"
        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        #endregion

        #region "Metodos"
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach (char c in texto)
            {
                ((IAcciones)this).UnidadesDeEscritura -= (float)0.1;
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} {2}", "Lapiz", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura);
            return s.ToString();
        }
        #endregion
    }
}
