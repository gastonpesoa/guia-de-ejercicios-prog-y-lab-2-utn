using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_32_Propiedades_sobre_ej_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

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
    }
}
