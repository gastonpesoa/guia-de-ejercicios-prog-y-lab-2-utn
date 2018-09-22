using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_37_Centralita_Herencia
{
    public class Llamada
    {
        //Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        //Propiedades
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
        //Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        //Metodos
        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("\nDuracion: {0}\nNro Destino: {1}\nNro Origen: {2}", this.Duracion, this.NroDestino, this.NroOrigen);
            return s.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }
        //Enumerados
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
