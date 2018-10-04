using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region "Enumerado"
        public enum TipoManada
        {
            Unica, Mixta
        }
        #endregion

        #region "Atributos"
        static TipoManada tipo;
        private string nombre;
        private List<Mascota> manada;
        #endregion

        #region "Propiedades"
        public TipoManada Tipo
        {
            set
            {
                Grupo.tipo = value; 
            }
        }
        #endregion

        #region "Constructores"
        static Grupo()
        {
            Grupo.tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Grupo e, Mascota j)
        {
            bool returnAux = false;
            foreach (Mascota mascota in e.manada)
            {
                if (mascota == j)
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (e != j)
            {
                e.manada.Add(j);
            }
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("**{0}**\nIntegrantes:\n", e.nombre);
            foreach (Mascota mascota in e.manada)
            {
                s.AppendLine(mascota.ToString());
            }
            return s.ToString();
        }
        #endregion
    }
}
