using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30_Competencia_AutoF1
{
    public class Competencia
    {
        //Atributos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        //Constructores
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        //Sobrecargas
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();
            bool returnAux = false;

            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)random.Next(15, 100);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool returnAux = false;

            if (c == a)
            {
                c.competidores.Remove(a);
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                returnAux = true;
            }
            return returnAux;
        }

        //Metodo
        public string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Competidores: ");
            foreach (AutoF1 auto in competidores)
            {
                s.AppendLine(auto.MostrarDatos());
            }
            s.AppendFormat("Cantidad de competidores: {0} - Cantidad de Vuletas: {1}", this.cantidadCompetidores, this.cantidadVueltas);
            return s.ToString();
        }
    }
}
