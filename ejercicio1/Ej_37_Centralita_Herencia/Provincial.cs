using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_37_Centralita_Herencia
{
    public class Provincial : Llamada
    {
        //Enumerados
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        //Atributos
        protected Franja franjaHoraria;
        //Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        //Constructores
        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :this(miFranja,new Llamada(duracion, destino, origen)) { }
        //Metodos
        public new string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Llamda Provincial Duracion: {0}\nNumero Destino: {1}\nNumero Origen: {2}\nCosto: {3}\nFranja Horaria: {4}", this.Duracion, this.NroDestino, this.NroOrigen, this.CostoLlamada, this.franjaHoraria);
            return s.ToString();
        }
        
        private float CalcularCosto()
        {
            float costo;
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
                default:
                    costo = 0;
                    break;
            }
            return costo;
        }
    }
}
