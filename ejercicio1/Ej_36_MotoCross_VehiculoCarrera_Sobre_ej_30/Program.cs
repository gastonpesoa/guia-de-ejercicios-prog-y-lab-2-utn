using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_36_MotoCross_VehiculoCarrera_Sobre_ej_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competenciaF1 = new Competencia(60, 3, Competencia.TipoCompetencia.F1);

            AutoF1 a1 = new AutoF1(1, "Mercedes Benz", 300);
            AutoF1 a2 = new AutoF1(2, "Ferrari", 405);
            AutoF1 a3 = new AutoF1(3, "Lotus", 360);
            AutoF1 a4 = new AutoF1(4, "McLaren", 504);

            Competencia competenciaMotoCross = new Competencia(50, 2, Competencia.TipoCompetencia.MotoCross);

            MotoCross m1 = new MotoCross(1, "Ducati", 600);
            MotoCross m2 = new MotoCross(2, "Kawasaki", 700);
            MotoCross m3 = new MotoCross(3, "BMW", 800);

            if (competenciaF1 + a1)
            {
                Console.WriteLine("Se agrego a la competencia F1 a:\n" + a1.MostrarDatos());
            }
            Console.WriteLine("---------------");
            if (competenciaF1 + a2)
            {
                Console.WriteLine("Se agrego a la competencia F1 a:\n" + a2.MostrarDatos());
            }
            Console.WriteLine("---------------");
            if (competenciaF1 + a3)
            {
                Console.WriteLine("Se agrego a la competencia F1 a:\n" + a3.MostrarDatos());
            }
            Console.WriteLine("---------------");
            if (!(competenciaF1 + a4))
            {
                Console.WriteLine("No se agrego a la competencia F1 a:\n" + a4.MostrarDatos() + "\nCantidad de competidores sobrepasada");
            }

            Console.WriteLine("=========================");
            Console.WriteLine(competenciaF1.MostrarDatos());
            Console.WriteLine("=========================");

            if (competenciaF1 - a3)
            {
                Console.WriteLine("Se retira de la competencia:\n" + a3.MostrarDatos());
            }
            Console.WriteLine("---------------");

            if (competenciaF1 + a4)
            {
                Console.WriteLine("Se agrego a la competencia F1 a:\n" + a4.MostrarDatos());
            }
            
            Console.WriteLine("=========================");
            Console.WriteLine(competenciaF1.MostrarDatos());
            Console.WriteLine("=========================");

            if (!(competenciaF1 + m1))
            {
                Console.WriteLine("No se agrego a la competencia F1 a:\n" + m1.MostrarDatos() + "\nTipo de vehiculo incorrecto");
            }
            Console.WriteLine("********************************");
            if (competenciaMotoCross + m1)
            {
                Console.WriteLine("Se agrego a la competencia MotoCross a:\n" + m1.MostrarDatos());
            }
            Console.WriteLine("---------------");
            if (competenciaMotoCross + m2)
            {
                Console.WriteLine("Se agrego a la competencia MotoCross a:\n" + m2.MostrarDatos());
            }
            Console.WriteLine("---------------");
            if (!(competenciaMotoCross + m3))
            {
                Console.WriteLine("No se agrego a la competencia MotoCross a:\n" + m3.MostrarDatos() + "\nCantidad de competidores sobrepasada");
            }

            Console.WriteLine("=========================");
            Console.WriteLine(competenciaMotoCross.MostrarDatos());
            Console.WriteLine("=========================");

            if (competenciaMotoCross - m2)
            {
                Console.WriteLine("Se retira de la competencia:\n" + m2.MostrarDatos());
            }
            Console.WriteLine("---------------");

            if (competenciaMotoCross + m3)
            {
                Console.WriteLine("Se agrego a la competencia MotoCross a:\n" + m3.MostrarDatos());
            }

            Console.WriteLine("=========================");
            Console.WriteLine(competenciaMotoCross.MostrarDatos());
            Console.WriteLine("=========================");

            if (!(competenciaMotoCross + a3))
            {
                Console.WriteLine("No se agrego a la competencia MotoCross a:\n" + a3.MostrarDatos() + "\nTipo de vehiculo incorrecto");
            }
            Console.WriteLine("********************************");
            Console.ReadKey();
        }
    }
}
