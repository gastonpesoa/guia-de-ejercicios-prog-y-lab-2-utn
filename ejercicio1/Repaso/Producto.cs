using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        protected string codigoDeBarra;
        protected string marca;
        protected float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Codigo: {0} Marca: {1} Precio: {2}", p.codigoDeBarra, p.marca, p.precio);
            return stringBuilder.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool returnAux = false;
            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool returnAux = true;
            if (p1 == p2 && p1 == p2)
            {
                returnAux = false;
            }
            return returnAux;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool returnAux = false;
            if (p.marca == marca)
            {
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool returnAux = true;
            if (p == marca)
            {
                returnAux = false;
            }
            return returnAux;
        }
    }
}
