using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_35_Persona_DirectorTecnico_Jugador
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nacimientoDt = new DateTime(1954, 9, 5);
            DirectorTecnico dt1 = new DirectorTecnico("Alejandro Sabella", nacimientoDt);
            Console.WriteLine(dt1.MostrarDatos());

            Console.WriteLine("-------------");

            Jugador j1 = new Jugador(33594157, "Lionel Messi",624,771);
            Console.WriteLine(j1.MostrarDatos());

            Console.WriteLine("-------------");
            
            Persona p = new Jugador(564321, "Diego Maradona", 312, 588);
            Console.WriteLine(((Jugador)p).MostrarDatos());

            Console.WriteLine("-------------");

            Console.ReadKey();
        }
    }
}
