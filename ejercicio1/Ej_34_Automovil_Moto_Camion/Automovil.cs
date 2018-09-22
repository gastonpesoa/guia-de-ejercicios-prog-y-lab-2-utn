using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34_Automovil_Moto_Camion
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }

    public class Automovil:VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
