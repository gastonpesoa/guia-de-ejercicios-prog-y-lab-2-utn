using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_19_Sumador";

            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(7);

            Console.WriteLine(sumador1.Sumar("a", "b"));
            Console.WriteLine(sumador1.Sumar(1,2));

            Console.WriteLine("Cantidad sumas sumador1 {0}",(int)sumador1);
            Console.WriteLine("Cantidad sumas sumador2 {0}", (int)sumador2);

            Console.WriteLine("Suma de sumadores {0}",sumador1 + sumador2);
            Console.WriteLine("Igualdad de sumador1 y sumador2 {0}", sumador1 | sumador2);
            Console.WriteLine("Igualdad de sumador1 y sumador1 {0}", sumador1 | sumador1);

            Console.ReadKey();
        }
    }
}
