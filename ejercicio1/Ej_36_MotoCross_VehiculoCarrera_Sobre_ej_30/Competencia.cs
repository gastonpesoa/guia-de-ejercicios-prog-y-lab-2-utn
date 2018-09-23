using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_36_MotoCross_VehiculoCarrera_Sobre_ej_30
{
    public class Competencia
    {
        #region Enumerado

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        #endregion

        #region Atributos

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        #endregion

        #region Propiedades

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Constructores

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            : this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        #endregion



        //Sobrecargas
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool contiene = false;

            foreach (VehiculoDeCarrera vehiculoDeCarrera in c.competidores)
            {
                if (vehiculoDeCarrera.Numero == v.Numero)
                {
                    contiene = true;
                }
            }
            return contiene;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
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
