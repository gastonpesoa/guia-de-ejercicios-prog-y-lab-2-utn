using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        #region "Atributos"
        private float litros;
        static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.42F;
            }
        }
        #endregion

        #region "Constructores"
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            :base(codigoBarra, marca, precio)
        {
            this.litros = litros;
        }

        public Gaseosa(Producto p, float litros)
            : this(p.CodigoBarra, p.Precio, p.Marca, litros) { }
        #endregion

        #region "Metodos"
        private string MostrarGaseosa()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("GASEOSA\n{0}\nLITROS: {1}\n", (string)this, this.litros);
            return s.ToString();
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }

        public override string Consumir()
        {
            return "Bebible";
        }
        #endregion
    }
}
