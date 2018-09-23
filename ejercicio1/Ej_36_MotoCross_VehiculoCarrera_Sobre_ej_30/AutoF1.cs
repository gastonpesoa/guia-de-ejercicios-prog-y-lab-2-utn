using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_36_MotoCross_VehiculoCarrera_Sobre_ej_30
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos

        private short caballosDeFuerza;

        #endregion

        #region Propiedades

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        #endregion

        #region Constructores

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia) { }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        #endregion

        #region Metodos

        public new string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("AutoF1\n" + base.MostrarDatos());
            s.AppendFormat("Caballos de Fuerza: {0}", this.CaballosDeFuerza);
            return s.ToString();
        }
        #endregion

    }
}
