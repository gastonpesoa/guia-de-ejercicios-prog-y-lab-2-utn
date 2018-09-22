using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29_Jugador_Equipo
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            bool entro;

=======
>>>>>>> 6d8acc7d93531a7ff47f2d13abfb2b1c1abf0f05
            Equipo e1 = new Equipo(11, "La Sub 21");

            Jugador j1 = new Jugador(30456987, "Juan Cholo", 54, 154);
            Jugador j2 = new Jugador(35498765, "Emilio Pome", 23, 104);
            Jugador j3 = new Jugador(23457878, "Facundo Yusta", 5, 65);
            Jugador j4 = new Jugador(12654789, "Roman Soto", 3, 56);
            Jugador j5 = new Jugador(32564648, "Ramiro Carrio", 78, 164);
            Jugador j6 = new Jugador(24654987, "Roberto Moncho", 45, 98);
            Jugador j7 = new Jugador(12454587, "Turco Marche", 65, 201);
            Jugador j8 = new Jugador(865454, "Mario Vinuca", 8, 20);
            Jugador j9 = new Jugador(545456, "Matias Olreto", 62, 233);
            Jugador j10 = new Jugador(6542287, "Estanislao Kiko", 3, 98);
            Jugador j11 = new Jugador(3356548, "Jessica Orto", 54, 54);
            Jugador j12 = new Jugador(554321, "Noentro Nunca", 0, 32);

            if (e1 + j1)
            {
                Console.WriteLine("Se agrego: " + j1.MostrarDatos() + " al equipo");
            }

            if (e1 + j2)
            {
                Console.WriteLine("Se agrego: " + j2.MostrarDatos() + " al equipo");
            }

            if (e1 + j3)
            {
                Console.WriteLine("Se agrego: " + j3.MostrarDatos() + " al equipo");
            }

            if (e1 + j4)
            {
                Console.WriteLine("Se agrego: " + j4.MostrarDatos() + " al equipo");
            }

            if (e1 + j5)
            {
                Console.WriteLine("Se agrego: " + j5.MostrarDatos() + " al equipo");
            }

            if (e1 + j6)
            {
                Console.WriteLine("Se agrego: " + j6.MostrarDatos() + " al equipo");
            }

            if (e1 + j7)
            {
                Console.WriteLine("Se agrego: " + j7.MostrarDatos() + " al equipo");
            }

            if (e1 + j8)
            {
                Console.WriteLine("Se agrego: " + j8.MostrarDatos() + " al equipo");
            }

            if (e1 + j9)
            {
                Console.WriteLine("Se agrego: " + j9.MostrarDatos() + " al equipo");
            }

            if (e1 + j10)
            {
                Console.WriteLine("Se agrego: " + j10.MostrarDatos() + " al equipo");
            }

            if (e1 + j11)
            {
                Console.WriteLine("Se agrego: " + j11.MostrarDatos() + " al equipo");
            }

            if (!(e1 + j12))
            {
                Console.WriteLine("No quedan lugares para agregar a: " + j12.MostrarDatos() + " al equipo");
            }

            if (!(e1 + j11))
            {
                Console.WriteLine(j11.MostrarDatos() + " ya esta en el equipo");
            }

            Console.ReadKey();
        }
    }
}
