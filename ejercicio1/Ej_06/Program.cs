using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_06_Anio_Bisiesto";

            int anioInicio, anioFinal, anioAnalizar;
            string anioInicioStr, anioFinalStr;

            Console.Write("Ingrese anio de inicio: ");
            anioInicioStr = Console.ReadLine();
            Console.Write("Ingrese anio final: ");
            anioFinalStr = Console.ReadLine();

            if((int.TryParse(anioInicioStr, out anioInicio)) && (int.TryParse(anioFinalStr, out anioFinal)))
            {
                for(anioAnalizar = anioInicio; anioAnalizar <= anioFinal; anioAnalizar++)
                {
                    if(anioAnalizar % 100 == 0 && anioAnalizar % 400 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (anioAnalizar % 4 == 0)
                        {
                            Console.WriteLine("El anio {0} es bisiesto.", anioAnalizar);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
