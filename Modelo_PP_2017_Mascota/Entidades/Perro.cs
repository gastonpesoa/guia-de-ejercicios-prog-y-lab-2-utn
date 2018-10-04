using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        #region "Atributos"
        private int edad;
        private bool esAlfa;
        #endregion

        #region "Propiedades"
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value == 0)
                {
                    this.edad = 0;
                }
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                if (value)
                {
                    this.esAlfa = false;
                }
                
            }
        }
        #endregion

        #region "Constructores"
        public Perro(string nombre, string raza)
            : base(nombre, raza) { }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : this(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Perro j1, Perro j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.Edad == j2.Edad);
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        #endregion

        #region "Metodos"
        protected override string Ficha()
        {
            StringBuilder s = new StringBuilder();
            if (!this.EsAlfa)
            {
                s.AppendFormat("{0}, alfa de la manada, edad {2}\n", base.DatosCompletos(), this.edad);
            }
            else
            {
                s.AppendFormat("{0} edad {1}", base.DatosCompletos(), this.edad);
            }
            return s.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool returnAux = false;
            if((Perro)obj == this)
            {
                returnAux = true;
            }
            return returnAux;
        }
        #endregion
    }
}
