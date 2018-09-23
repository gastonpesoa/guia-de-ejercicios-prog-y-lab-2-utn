using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_36_MotoCross_VehiculoCarrera_Sobre_ej_30
{
    public class MotoCross:VehiculoDeCarrera
    {
        #region Atributos

        private short cilindrada;

        #endregion

        #region Propiedades

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        #endregion

        #region Constructores

        public MotoCross(short numero,string escuderia)
            :base(numero, escuderia) { }

        public MotoCross(short numero, string escuderia, short cilindrada)
            :this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        #endregion

        #region Metodos

        public new string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("MotoCross " + base.MostrarDatos());
            s.AppendFormat("Cilindrada: {0}", this.Cilindrada);
            return s.ToString();
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return ((((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2)) && (m1.Cilindrada == m2.Cilindrada));
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        #endregion
    }
}
