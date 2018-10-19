using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej_47_Torneo_Generics
{
    public class Torneo<T> where T : Equipo
    {
        #region "Atributos"
        private List<T> equipos;
        private string nombre;
        #endregion

        #region "Propiedades"
        public string JugarPartido
        {
            get
            {
                Random random = new Random();

                int index1 = random.Next(this.equipos.Count);
                Thread.Sleep(2000);
                int index2 = random.Next(this.equipos.Count);
                while (index1 == index2) 
                {
                    index2 = random.Next(this.equipos.Count);
                } 
                

                T eq1 = this.equipos[index1];
                T eq2 = this.equipos[index2];

                return this.CalculaPartido(eq1, eq2);
            }
        }
        #endregion

        #region "Constructores"
        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Torneo<T> t, T e)
        {
            bool returnAux = false;
            foreach (T equipo in t.equipos)
            {
                if (equipo.Nombre == e.Nombre && equipo.FechaCreacion == e.FechaCreacion)
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t,T e)
        {
            if (t != e)
            {
                t.equipos.Add(e); 
            }
            return t;
        }
        #endregion

        #region "Metodos"
        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("TORNEO: {0}\n", this.nombre);
            foreach (T equipo in this.equipos)
            {
                s.AppendLine(equipo.Ficha());
            }
            return s.ToString();
        }

        private string CalculaPartido(T eq1, T eq2)
        {
            Random random = new Random();
            int resultado1 = random.Next(0,10);
            int resultado2 = random.Next(0,10);
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} - {2} {3}", eq1.Nombre, resultado1, eq2.Nombre, resultado2);
            return s.ToString();
        }
        #endregion
    }
}
