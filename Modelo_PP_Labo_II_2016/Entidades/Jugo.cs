using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        #region "Enumerado"
        public enum ESaborJugo
        {
            Asqueroso, Pasable, Rico
        }
        #endregion

        #region "Atributos"
        private ESaborJugo sabor;
        static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.4F;
            }
        }
        #endregion

        #region "Constructores"
        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this.sabor = sabor;
        }
        #endregion

        #region "Metodos"
        private string MostrarJugo()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("JUGO\n{0}\nSABOR: {1}\n", (string)this, this.sabor);
            return s.ToString();
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }
        #endregion
    }
}
