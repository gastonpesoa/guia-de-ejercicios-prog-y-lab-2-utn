using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40_Centralita_Herencia_Polimorfismo
{
    public class Centralita
    {
        #region Atributos

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Constructores

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool contiene = false;
            foreach (Llamada l in c.Llamadas)
            {
                if (l == llamada)
                {
                    contiene = true;
                    break;
                }
            }
            return contiene;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }
        #endregion

        #region Metodos

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float valorRecaudado = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                default:
                    break;
            }
            return valorRecaudado;
        }

        private string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Centralita\nRazon Social: {0}\nGanancia Total: {1}\nGanancia Locales: {2}\nGanancia Provinciales: {3}\nDetalle de Llamadas:\n", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    s.AppendLine(((Local)llamada).ToString());
                }
                if (llamada is Provincial)
                {
                    s.AppendLine(((Provincial)llamada).ToString());
                }
            }
            return s.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar(); 
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
                this.Llamadas.Add(nuevaLlamada);
        }

        #endregion

    }
}
