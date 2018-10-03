using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        #region "Atributos"
        private float peso;
        static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.33F;
            }
        }
        #endregion

        #region "Constructores"
        static Galletita()
        {
            Galletita.DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marcaProducto, float peso)
            : base(codigoBarra, marcaProducto, precio)
        {
            this.peso = peso;
        }
        #endregion

        #region "Metodos"
        private string MostrarGalletita(Galletita g)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0,-15} {0} Peso: {1}","Galletita", (string)this, this.peso);
            return s.ToString();
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        public override string ToString()
        {
            return this.MostrarGalletita(this);
        }
        #endregion
    }
}
