using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_13";

            string numeroDecimalStr, numeroBinarioStr;
            double numeroDecimal;

            Console.Write("Ingrese un numero: ");
            numeroDecimalStr = Console.ReadLine();

            if(double.TryParse(numeroDecimalStr, out numeroDecimal))
            {
                numeroBinarioStr = Conversor.DecimalBinario(numeroDecimal);
                Console.WriteLine("{0} base diez = {1} base dos", numeroDecimal, numeroBinarioStr);
            }

            Console.Write("Ingrese un numero binario: ");
            numeroBinarioStr = Console.ReadLine();

            numeroDecimal = Conversor.BinarioDecimal(numeroBinarioStr);
            Console.WriteLine("{0} base dos = {1} base diez", numeroBinarioStr, numeroDecimal);

            Console.ReadKey();
        }
    }
}
