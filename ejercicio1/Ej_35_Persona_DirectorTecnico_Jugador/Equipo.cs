using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35_Persona_DirectorTecnico_Jugador
{
    public class Equipo
    {
        #region Atributos

        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region Constructores

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        #endregion

        #region Sobrecargas

        public static bool operator +(Equipo e, Jugador j)
        {
            bool contiene = false;
            bool returnAux = false;
            foreach (Jugador jugador in e.jugadores)
            {
                if (j.Dni == jugador.Dni)
                {
                    contiene = true;
                }
            }
            if (!contiene && !(e.jugadores.Count >= e.cantidadDeJugadores))
            {
                e.jugadores.Add(j);
                returnAux = true;
            }
            return returnAux;
        }

        #endregion

    }
}
