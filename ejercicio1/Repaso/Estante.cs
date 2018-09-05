using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Ubicacion estante: {0}", e.ubicacionEstante);

            for (int i = 0; i < e.productos.Length; i++)
            {
                stringBuilder.AppendFormat(Producto.MostrarProducto(e.productos[i]));
            }
            return stringBuilder.ToString();
        }

       public static bool operator ==(Estante e, Producto p)
        {

        }
    }
}
