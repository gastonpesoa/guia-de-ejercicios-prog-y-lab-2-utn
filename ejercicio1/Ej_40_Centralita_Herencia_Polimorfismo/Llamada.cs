using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40_Centralita_Herencia_Polimorfismo
{
    public abstract class Llamada
    {
        #region Atributos Protegidos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region Propiedades
        //Propiedad abstracta
        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion

        #region Constructor

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion

        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("\nDuracion: {0}\nNro Destino: {1}\nNro Origen: {2}", this.Duracion, this.NroDestino, this.NroOrigen);
            return s.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        #endregion

        #region Enumerados

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion

    }
}
