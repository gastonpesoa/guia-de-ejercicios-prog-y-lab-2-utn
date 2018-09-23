using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35_Persona_DirectorTecnico_Jugador
{
    public class Jugador : Persona
    {
        #region Atributos

        private int partidosJugados;
        private int totalGoles;
        #endregion

        #region Propiedades

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        #endregion

        #region Constructores

        public Jugador(int dni, string nombre)
            : base(dni,nombre) { }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region Metodos

        public new string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Jugador");
            s.AppendLine(base.MostrarDatos());
            s.AppendFormat("Partidos Jugados: {2}\nTotal de Goles: {3}\nPromedio de Goles: {4:F2}", this.Dni, this.Nombre, this.PartidosJugados, this.TotalGoles, this.PromedioGoles);
            return s.ToString();
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
