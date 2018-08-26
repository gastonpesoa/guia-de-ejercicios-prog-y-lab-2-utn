using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_2";

            string numStr;
            int num;
            double numCuadrado, numCubo;

            do
            {
                Console.Write("Ingrese un numero: ");
                numStr = Console.ReadLine();

                if (int.TryParse(numStr, out num))
                {
                    if (num >= 0)
                    {
                        numCuadrado = Math.Pow(num, 2);
                        numCubo = Math.Pow(num, 3);
                        Console.WriteLine("Numero ingresado: {0}\nCuadrado: {1}\nCubo: {2}", num, numCuadrado, numCubo);
                    }
                    else
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!");
                    }

                }
                else
                {
                    Console.WriteLine("ERROR. ¡El valor ingresado debe ser numerico!");
                }
            } while (num < 0);

            
            
            Console.ReadKey();
        }
    }
}
