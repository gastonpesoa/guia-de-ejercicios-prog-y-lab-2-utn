using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        #region "Enumerado"
        public enum ETipoHarina
        {
            CuatroCeros, TresCeros, Integral
        }
        #endregion

        #region "Atributos"
        private ETipoHarina tipo;
        static bool DeConsumo;
        #endregion

        #region "Propiedades"
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return this.Precio * 0.6F;
            }
        }
        #endregion

        #region "Constructores"
        static Harina()
        {
            Harina.DeConsumo = false;
        }

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            :base(codigo, marca, precio)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Metodos"
        private string MostrarHarina()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0,-15} {1} Tipo: {2}", "Harina", (string)this, this.tipo);
            return s.ToString();
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }
        #endregion
    }
}
