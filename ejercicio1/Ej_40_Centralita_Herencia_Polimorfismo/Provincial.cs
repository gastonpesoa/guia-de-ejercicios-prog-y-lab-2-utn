using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_40_Centralita_Herencia_Polimorfismo
{
    public class Provincial : Llamada
    {
        #region Atributo

        protected Franja franjaHoraria;
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

        #region Constructores

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino) { }
        #endregion

        #region Metodos

        protected override string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Llamda Provincial{0}\nCosto: {1}\nFranja Horaria: {2}", base.Mostrar(), this.CostoLlamada, this.franjaHoraria);
            return s.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.Duracion * (float)0.66;
                    break;
            }
            return costo;
        }
        #endregion

        #region Enumerado

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion
    }
}
