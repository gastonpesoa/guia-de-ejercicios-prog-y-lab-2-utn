using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region "Atributos"
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region "Propiedades"
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region "Constructores"
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo de clase 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ValidarEquipo(Equipo e)
        {
            bool returnAux = false;
            int arquero = 0, defensor = 0, central = 0, delantero = 0;

            if (!(e.directorTecnico is null))
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    switch (jugador.Posicion)
                    {
                        case Posicion.Arquero:
                            arquero++;
                            break;
                        case Posicion.Defensor:
                            defensor++;
                            break;
                        case Posicion.Central:
                            central++;
                            break;
                        case Posicion.Delantero:
                            delantero++;
                            break;
                        default:
                            break;
                    }
                }
                if (arquero == 1 && defensor != 0 && central != 0 && delantero != 0 && e.jugadores.Count == cantidadMaximaJugadores)
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Sobrecarga del operador string para exponer los datos del equipo 
        /// previa validacion de tenga DT asignado
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Nombre: {0}\nCantidad de Jugadores: {1}\n", e.Nombre, cantidadMaximaJugadores);
            if (e.directorTecnico is null)
            {
                s.AppendLine("Sin DT asignado");
            }
            else
            {
                s.AppendFormat("Director técnico: {0}\n", e.directorTecnico.Mostrar());
            }
            foreach (Jugador jugador in e.jugadores)
            {
                s.AppendLine(jugador.Mostrar());
            }
            return s.ToString();
        }
        /// <summary>
        /// Sobrecarga para verificar que un jugador se encuentre en el equipo
        /// </summary>
        /// <param name="e">Equipo donde se buscara la coincidencia</param>
        /// <param name="j">Jugador que se comparará</param>
        /// <returns>true si el jugador ya está en el equipo, false si no lo está</returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool returnAux = false;
            foreach (Jugador jugador in e.jugadores)
            {
                if (j.Dni == jugador.Dni && j.Nombre == jugador.Nombre && j.Apellido == jugador.Apellido)
                {
                    returnAux = true;
                    break;
                }
            }
            return returnAux;
        }
        /// <summary>
        /// Verifica que el jugador no se encuentre en el equipo
        /// </summary>
        /// <param name="e">Equipo donde se buscara la coincidencia</param>
        /// <param name="j">Jugador que se comparará</param>
        /// <returns>true si el jugador no está en el equipo, false si lo está</returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        /// <summary>
        /// Agrega un jugador al equipo en caso de que 
        /// Este no este agregado previamente
        /// No se haya superado la cantidad máxima de jugadores
        /// Cumpla con las condiciones de aptitud
        /// </summary>
        /// <param name="e">Equipo donde se agregará al jugador</param>
        /// <param name="j">Jugador que se agregará</param>
        /// <returns>Equipo con el jugador agregado en caso de ok, mismo Equipo caso contrario</returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < Equipo.cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        #endregion
    }
}
