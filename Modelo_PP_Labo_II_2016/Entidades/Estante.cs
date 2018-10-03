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
            s.AppendLine("************************************ ESTANTE *********************************************");
            s.AppendFormat("Capacidad: {0}\n", e.capacidad);
            s.AppendLine("******************************* DETALLEDE PRODUCTOS **************************************");
            s.AppendFormat("{0,-15} {1,-15} {2,-15} {3,-15}\n", "Producto", "Codigo de Barra", "Marca", "Precio");
            foreach (Producto producto in e.GetProductos())
            {
                s.AppendLine(producto.ToString());
            }
            s.AppendLine("*******************************************************************************************");    
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
                e.productos.Remove(prod);
            }
            return e;
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
            switch (tipo)
            {
                case Producto.ETipoProducto.Galletita:
                    foreach (Producto producto in e.productos)
                    {
                        if (producto is Galletita)
                        {
                            e -= producto;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Gaseosa:
                    foreach (Producto producto in e.GetProductos())
                    {
                        if (producto is Gaseosa)
                        {
                            e -= producto;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Jugo:
                    foreach(Producto producto in e.GetProductos())
                    {
                        if (producto is Jugo)
                        {
                            e -= producto;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Harina:
                    foreach(Producto producto in e.GetProductos())
                    {
                        if (producto is Harina)
                        {
                            e -= producto;
                        }
                    }
                    break;
                case Producto.ETipoProducto.Todos:
                    foreach(Producto producto in e.GetProductos())
                    {
                        e -= producto;
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
