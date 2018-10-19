using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej_47_Torneo_Generics;

namespace Ej_47_Torneo_Generics_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneo1 = new Torneo<EquipoFutbol>("SUPERLIGA ARGENTINA");
            Torneo<EquipoBasquet> torneo2 = new Torneo<EquipoBasquet>("NBA");

            DateTime fechaEq1 = new DateTime(1953, 08, 18);
            DateTime fechaEq2 = new DateTime(1990, 01, 01);
            DateTime fechaEq3 = new DateTime(1976, 10, 26);
            DateTime fechaEq4 = new DateTime(1977, 03, 05);
            DateTime fechaEq5 = new DateTime(1983, 06, 15);
            DateTime fechaEq6 = new DateTime(1966, 12, 22);

            EquipoFutbol eqFut1 = new EquipoFutbol("Boca", fechaEq1);
            EquipoFutbol eqFut2 = new EquipoFutbol("River", fechaEq2);
            EquipoFutbol eqFut3 = new EquipoFutbol("Independiente", fechaEq3);
            EquipoBasquet eqBas1 = new EquipoBasquet("Lakers", fechaEq4);
            EquipoBasquet eqBas2 = new EquipoBasquet("Bulls", fechaEq5);
            EquipoBasquet eqBas3 = new EquipoBasquet("Spurs", fechaEq6);

            torneo1 += eqFut1;
            torneo1 += eqFut2;
            torneo1 += eqFut3;

            torneo2 += eqBas1;
            torneo2 += eqBas2;
            torneo2 += eqBas3;

            Console.WriteLine(torneo1.Mostrar());
            Console.WriteLine(torneo2.Mostrar());

            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo1.JugarPartido);

            Console.WriteLine(torneo2.JugarPartido);
            Console.WriteLine(torneo2.JugarPartido);
            Console.WriteLine(torneo2.JugarPartido);
            Console.ReadKey();
        }
    }
}
