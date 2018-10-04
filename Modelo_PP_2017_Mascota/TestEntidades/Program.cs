using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g = new Grupo("Rio Unica");
            Perro p1 = new Perro("Moro", "Pitbul", 0, false);
            Perro p2 = new Perro("Julio", "Cruza", 13, false);
            Perro p3 = new Perro("Ramon", "Salchicha", 2, true);
            Gato g1 = new Gato("Jose", "Angora");
            Gato g2 = new Gato("Hernan", "Cruza");
            Gato g3 = new Gato("Fer", "Siames");

            g += p1;
            g += p1;
            g += p2;
            g += p3;
            g += g1;
            g += g2;
            g += g3;

            Console.WriteLine((string)g);
            Console.ReadKey();
        }
    }
}
