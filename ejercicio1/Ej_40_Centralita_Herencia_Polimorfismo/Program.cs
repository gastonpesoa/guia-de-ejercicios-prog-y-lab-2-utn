using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centralita_Biblioteca;

namespace Ej_40_Centralita_Herencia_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            Console.WriteLine(l4.ToString());
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c = c + l1;
            c = c + l2;
            c = c + l3;
            try
            {
                c = c + l4;
            }
            catch (CentralitaException cEx)
            {
                Console.WriteLine("\n\n{0}\nExcepcion lanzada dentro del metodo -> {1}\nDe la clase -> {2}\n\n", cEx.Message, cEx.NombreMetodo, cEx.NombreClase);
            }
            
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
