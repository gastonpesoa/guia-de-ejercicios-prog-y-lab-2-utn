using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30_Competencia_AutoF1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(1, "Mercedes-Benz");
            AutoF1 a2 = new AutoF1(2, "McLaren");
            AutoF1 a3 = new AutoF1(3, "Lotus");
            AutoF1 a4 = new AutoF1(3, "Lotus");
            AutoF1 a5 = new AutoF1(4, "Ferrari");
            Competencia f1 = new Competencia(10, 3);

            if (a1 != a2)
            {
                Console.WriteLine("a1: {0}\ny\na2: {1}\nson diferentes",a1.MostrarDatos(),a2.MostrarDatos());
            }
            if (a3 == a4)
            {
                Console.WriteLine("a3: {0}\ny\na4: {1}\nson iguales",a3.MostrarDatos(), a4.MostrarDatos());
            }

            Console.WriteLine("Se cero la competencia f1 2018: ");
            Console.WriteLine(f1.MostrarDatos());
            if (f1 + a1 && f1 + a2 && f1 + a3)
            {
                Console.WriteLine("Se agregaron autos a la competencia: ");
                Console.WriteLine(f1.MostrarDatos());
            }

            if (!(f1 + a4))
            {
                Console.WriteLine("No se puede agreagar a4, igual a a3, ya se encuentra compitiendo");
            }

            if (!(f1 + a5))
            {
                Console.WriteLine("No se puede agreagar a5, Capacidad limite de competidores superada");
            }

            Console.ReadKey();
        }
    }
}
