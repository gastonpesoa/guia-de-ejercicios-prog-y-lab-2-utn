using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region "Enumerados"
        public enum EMarcaProducto
        {
            Manaos, Pitusas, Naranjú, Diversión, Swift, Favorita
        }

        public enum ETipoProducto
        {
            Galletita, Gaseosa, Jugo, Harina, Todos
        }
        #endregion

        #region "Atributos"
        protected int codigoBarra;
        protected EMarcaProducto marca;
        protected float precio;
        #endregion

        #region "Propiedades"
        public abstract float CalcularCostoDeProduccion { get; }

        public EMarcaProducto Marca
        {
            get
            {
                return this.marca;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int CodigoBarra
        {
            get
            {
                return this.codigoBarra;
            }
        }
        #endregion

        #region "Constructor"
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this.codigoBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region "Metodos"
        private string MostrarProducto(Producto p)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("CODIGO DE BARRAS: {0}\nMARCA: {1}\nPRECIO: {2}", this.CodigoBarra, this.Marca, this.Precio);
            return s.ToString();
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }
        #endregion

        #region "Sobrecargas"
        //public override bool Equals(object obj)
        //{
        //    return obj is Producto;
        //}
        #endregion

        #region "Operadores"
        public static explicit operator int(Producto p)
        {
            return p.codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return p.MostrarProducto(p);
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            return prodUno.Marca == marca;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            return (prodUno.Marca == prodDos.Marca && prodUno.codigoBarra == prodDos.codigoBarra);
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }
        #endregion
    }
}
