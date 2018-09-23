using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40_Centralita_Herencia_Polimorfismo
{
    public class Local : Llamada
    {
        #region Atributo

        protected float costo;

        #endregion

        #region Propiedad

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Constructor

        //public Local(Llamada llamada, float costo)
        //    : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        //{
        //    this.costo = costo;
        //}

        //public Local(string origen, float duracion, string destino, float costo)
        //    : this(new Llamada(duracion, destino, origen), costo) { }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        #endregion

        #region Metodos

        protected override string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Llamda Local{0}\nCosto: {1}", base.Mostrar(), this.CostoLlamada);
            return s.ToString();
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public override bool Equals(object obj)
        {
            return obj is Local; 
        }

        public override int GetHashCode()
        {
            return 1142510187;  
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
