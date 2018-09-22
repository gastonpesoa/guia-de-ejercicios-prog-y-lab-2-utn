using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34_Automovil_Moto_Camion
{
    public class Moto:VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
