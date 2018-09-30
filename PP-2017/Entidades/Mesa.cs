using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesa
    {
        #region "Atributos"
        private List<Comensal> comensales;
        private int numero;
        static int capacidad;
        #endregion

        #region "Propiedades"
        public int Cantidad
        {
            get { return this.comensales.Count; }
        }

        public List<Comensal> Comensales
        {
            get { return this.comensales; }
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        #endregion

        #region "Constructores"
        static Mesa()
        {
            Mesa.capacidad = 12;
        }

        private Mesa()
        {
            this.comensales = new List<Comensal>();
        }

        public Mesa(int numero)
            : this()
        {
            this.numero = numero;
        }
        #endregion

        #region "Sobrecargas"
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} {2} {3}", "Mesa:", this.Numero, "Comensales:", this.Cantidad);
            return s.ToString();
        }
        #endregion

        #region "Operadores"
        public static explicit operator string(Mesa a)
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(a.ToString());
            foreach (Comensal comensal in a.Comensales)
            {
                if (comensal is Menor)
                {
                    s.AppendFormat("{0} {1}\n", comensal.Mostrar(), "Menor");
                }
                else
                {
                    s.AppendLine(((Mayor)comensal).ToString());
                }
                
            }
            return s.ToString();
        }

        public static bool operator ==(Mesa a, Mesa b)
        {
            return a.Numero == b.Numero;
        }

        public static bool operator !=(Mesa a, Mesa b)
        {
            return !(a == b);
        }

        public static Mesa operator +(Mesa a, Mayor b)
        {
            bool contiene = false;
            if (a.Cantidad < Mesa.capacidad)
            {
                foreach (Comensal comensal in a.Comensales)
                {
                    if (comensal is Mayor)
                    {
                        if ((Mayor)comensal == b)
                        {
                            contiene = true;
                            break;
                        }
                    }
                }
            }
            if (!contiene)
            {
                a.Comensales.Add(b);
            }
            return a;
        }

        public static Mesa operator +(Mesa a, Menor b)
        {
            bool contiene = false;
            if (a.Cantidad < Mesa.capacidad)
            {
                foreach (Comensal comensal in a.Comensales)
                {
                    if (comensal is Menor)
                    {
                        if ((Menor)comensal == b)
                        {
                            contiene = true;
                            break;
                        }
                    }
                }
            }
            if (!contiene)
            {
                a.Comensales.Add(b);
            }
            return a;
        }
        #endregion
    }
}
