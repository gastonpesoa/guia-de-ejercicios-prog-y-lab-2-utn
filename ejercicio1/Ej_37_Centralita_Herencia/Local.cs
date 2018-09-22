using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_37_Centralita_Herencia
{
    public class Local : Llamada
    {
        //Atributos
        protected float costo;
        //Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        //Constructores
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen,float duracion, string destino, float costo)
            :this(new Llamada(duracion, destino, origen),costo) { }
        //public Local(string origen, float duracion, string destino, float costo)
        //    :base(duracion, destino, origen)
        //{
        //    this.costo = costo;
        //}

        //public Local(Llamada llamada, float costo)
        //    : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        //{
        //}
        public new string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Llamda Local\nDuracion: {0}\nNumero Destino: {1}\nNumero Origen: {2}\nCosto: {3}", this.Duracion, this.NroDestino, this.NroOrigen, this.CostoLlamada);
            return s.ToString();
        }
        
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }    
    }
}
