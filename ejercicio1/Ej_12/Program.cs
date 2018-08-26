using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            string numStr;
            string continuarStr = "N";
            char continuar;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numStr = Console.ReadLine();

                if (int.TryParse(numStr, out number))
                {
                    sum = sum + number;
                }

                Console.WriteLine("¿Continuar? (S/N)");
                continuarStr = Console.ReadLine();
                continuar = char.Parse(continuarStr);

            } while (ValidarRespuesta.ValidaS_N(continuar));
            
            Console.ReadKey();
        }
    }
}
