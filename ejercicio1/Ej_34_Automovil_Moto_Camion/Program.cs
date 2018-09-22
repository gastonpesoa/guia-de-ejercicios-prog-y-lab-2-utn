using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34_Automovil_Moto_Camion
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion c = new Camion(8, 2, Colores.Azul, 8, 5000);
            Console.WriteLine("Camion c\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga: {4}", c.cantidadRuedas, c.cantidadPuertas, c.color, c.cantidadMarchas, c.pesoCarga);
            Console.WriteLine("-----------");
            Automovil a = new Automovil(4, 5, Colores.Blanco, 5, 3);
            Console.WriteLine("Automovil a\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", a.cantidadRuedas, a.cantidadPuertas, a.color, a.cantidadMarchas, a.cantidadPasajeros);
            Console.WriteLine("-----------");
            Moto m = new Moto(2, 0, Colores.Rojo, 1000);
            Console.WriteLine("Moto m\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", m.cantidadRuedas, m.cantidadPuertas, m.color, m.cilindrada);
            Console.ReadKey();
        }
    }
}
