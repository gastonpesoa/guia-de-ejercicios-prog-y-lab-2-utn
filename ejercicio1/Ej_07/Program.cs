using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_07_Dias_Vividos";

            int dia, mes, anio;
            int diasVividos = 0;
            string diaStr, mesStr, anioStr;
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine("Fecha de nacimiento");
            Console.Write("Ingrese dia: ");
            diaStr = Console.ReadLine();
            Console.Write("Ingrese mes: ");
            mesStr = Console.ReadLine();
            Console.Write("Ingrese anio: ");
            anioStr = Console.ReadLine();

            if((int.TryParse(diaStr, out dia)) && (int.TryParse(mesStr, out mes)) && (int.TryParse(anioStr, out anio)))
            {
                //for () { }
            }

        }
    }
}
