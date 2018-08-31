using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_17_Class_Boligrafo";

            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            Console.WriteLine("Dibujo de boligrafo1");
            if(boligrafo1.Pintar(50, out dibujo))
            {
                Console.ForegroundColor = boligrafo1.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nivel de tinta restante: {0}", boligrafo1.GetTinta());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
            }

            Console.Clear();
            Console.WriteLine("Dibujo de boligrafo2");
            if (boligrafo2.Pintar(30, out dibujo))
            {
                Console.ForegroundColor = boligrafo2.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nivel de tinta restante: {0}", boligrafo2.GetTinta());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
            }

        }
    }
}
