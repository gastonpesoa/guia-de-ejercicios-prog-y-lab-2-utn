using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_5";

            string numeroStr;
            int numero, i, aux = 0;
            int acum = 1, suma = 0;

            Console.Write("Ingrese un numero: ");
            numeroStr = Console.ReadLine();

            if (int.TryParse(numeroStr, out numero))
            {
                for(i = 2; i < numero; i++)
                {
                    acum = acum + (i - 1);
                    suma = i + 1;

                    while(acum <= suma)
                    {
                        suma = suma + aux;
                        aux++;
                        if (suma == acum)
                        {
                            Console.WriteLine("{0} es centro numerico", i);
                        }
                    }
                    
                }   
            }
            Console.ReadKey();
        }
    }
}
