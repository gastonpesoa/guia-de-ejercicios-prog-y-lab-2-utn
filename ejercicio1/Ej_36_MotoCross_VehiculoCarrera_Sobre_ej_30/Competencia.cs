using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        #region Indexador

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        #endregion

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

        #region Sobrecargas

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false, contiene = false;

            foreach (VehiculoDeCarrera vehiculoDeCarrera in c.competidores)
            {
                if (vehiculoDeCarrera.Numero == v.Numero)
                {
                    contiene = true;
                    break;
                }
            }
            if (!contiene)
            {
                switch (c.Tipo)
                {
                    case TipoCompetencia.F1:
                        if (v is AutoF1)
                        {
                            returnAux = true;
                        }
                        break;
                    case TipoCompetencia.MotoCross:
                        if (v is MotoCross)
                        {
                            returnAux = true;
                        }
                        break;
                }
            }
            if(contiene && !returnAux)
            {
                var st = new StackTrace();
                var sf = st.GetFrame(0);
                var currentMethodName = sf.GetMethod();
                CompetenciaNoDisponibleException competenciaEx = new CompetenciaNoDisponibleException(
                    "El vehículo no corresponde a la competencia", c.GetType().ToString(), currentMethodName.ToString());
                throw competenciaEx;
            }
            return returnAux;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random random = new Random();
            bool returnAux = false, contiene = false;
            try
            {
                contiene = c == v;
            }
            catch (CompetenciaNoDisponibleException compEx)
            {
                var st = new StackTrace();
                var sf = st.GetFrame(0);
                var currentMethodName = sf.GetMethod();
                CompetenciaNoDisponibleException newEx = new CompetenciaNoDisponibleException(
                    "Competencia incorrecta", c.GetType().ToString(), currentMethodName.ToString(), compEx);
                throw newEx;
            }
            if (c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(v);
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                v.CantidadCombustible = (short)random.Next(15, 100);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false;

            if (c != v)
            {
                c.competidores.Remove(v);
                v.EnCompetencia = false;
                v.VueltasRestantes = 0;
                v.CantidadCombustible = 0;
                returnAux = true;
            }
            return returnAux;
        }

        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Competencia {0}\nCantidad de Vueltas: {1}\nCantidad de Competidores: {2}\nCompetidores:\n",this.Tipo, this.cantidadVueltas, this.cantidadCompetidores);
            foreach (VehiculoDeCarrera vehiculoDeCarrera in this.competidores)
            {
                if (vehiculoDeCarrera is AutoF1)
                {
                    s.AppendFormat("\n{0}\nCantidad de Combustible: {1}\n", ((AutoF1)vehiculoDeCarrera).MostrarDatos(),vehiculoDeCarrera.CantidadCombustible);
                }
                if (vehiculoDeCarrera is MotoCross)
                {
                    s.AppendFormat("\nMotoCross\n{0}\nCantidad de Combustible: {1}\n", ((MotoCross)vehiculoDeCarrera).MostrarDatos(), vehiculoDeCarrera.CantidadCombustible);
                }
            }
            return s.ToString();
        }

        #endregion
    }
}
