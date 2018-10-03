using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region "Atributos"
        protected sbyte capacidad;
        protected List<Producto> productos;
        #endregion

        #region "Propiedades"
        public float ValorEstanteTotal
        {
            get
            {
                return this.GetValorEstante(Producto.ETipoProducto.Todos);
            }
        }
        #endregion

        #region "Constructores"
        private Estante()
        {
            this.productos = new List<Producto>();
        }

        public Estante(sbyte capacidad)
            : this() { this.capacidad = capacidad; }
        #endregion

        #region "Metodos"
        public List<Producto> GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("CAPACIDAD: {0}\n", e.capacidad);
            foreach (Producto producto in e.GetProductos())
            {
                s.AppendLine(producto.ToString());
            }
            return s.ToString();
        }
        #endregion

        #region "Operadores"
        public static bool operator ==(Estante e, Producto prod)
        {
            bool returnAux = false;
            
            foreach (Producto producto in e.GetProductos())
            {
                if (producto == prod)
                {
                    returnAux = true;
                    break;
                }
            }

            return returnAux;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator +(Estante e, Producto prod)
        {
            bool returnAux = false;

            if (e != prod && e.GetProductos().Count < e.capacidad)
            {
                e.GetProductos().Add(prod);
                returnAux = true;
            }
            return returnAux;
        }

        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
            {
                e.GetProductos().Remove(prod);
            }
            return e;
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
            switch (tipo)
            {
                case Producto.ETipoProducto.Galletita:
                    for (int i = 0; i < e.GetProductos().Count; i++)
                    {
                        if (e.productos[i] is Galletita)
                        {
                            e -= e.productos[i];
                        }
                    }
                    break;
                case Producto.ETipoProducto.Gaseosa:
                    for (int i = 0; i < e.GetProductos().Count; i++)
                    {
                        if (e.productos[i] is Gaseosa)
                        {
                            e -= e.productos[i];
                        }
                    }
                    break;
                case Producto.ETipoProducto.Jugo:
                    for (int i = 0; i < e.GetProductos().Count; i++)
                    {
                        if (e.productos[i] is Jugo)
                        {
                            e -= e.productos[i];
                        }
                    }
                    break;
                case Producto.ETipoProducto.Harina:
                    for (int i = 0; i < e.GetProductos().Count; i++)
                    {
                        if (e.productos[i] is Harina)
                        {
                            e -= e.productos[i];
                        }
                    }
                    break;
                case Producto.ETipoProducto.Todos:
                    for (int i = 0; i < e.GetProductos().Count; i++)
                    {
                        e -= e.productos[i];
                        i--;
                    }
                    break;
                default:
                    break;
            }
            return e;
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float valor = 0;
            switch (tipo)
            {
                case Producto.ETipoProducto.Galletita:
                    foreach (Producto producto in this.GetProductos())
                    {
                        if (producto is Galletita)
                        {
                            valor += producto.Precio;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Gaseosa:
                    foreach (Producto producto in this.GetProductos())
                    {
                        if (producto is Gaseosa)
                        {
                            valor += producto.Precio;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Jugo:
                    foreach (Producto producto in this.GetProductos())
                    {
                        if (producto is Jugo)
                        {
                            valor += producto.Precio;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Harina:
                    foreach (Producto producto in this.GetProductos())
                    {
                        if (producto is Harina)
                        {
                            valor += producto.Precio;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Todos:
                    foreach (Producto producto in this.GetProductos())
                    {
                        valor += producto.Precio;
                    }
                    break;
                default:
                    break;
            }
            return valor;
        }
        #endregion
    }
}
