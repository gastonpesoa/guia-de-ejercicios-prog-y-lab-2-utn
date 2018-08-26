using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_3";

            string numeroStr;
            int numero, i, aux;
            int contadorDivisores = 0;

            Console.Write("Ingrese un numero: ");
            numeroStr = Console.ReadLine();

            if(int.TryParse(numeroStr, out numero))
            {
                for (i = 2; i <= numero; i++)
                {
                    for(aux = 1; aux <= numero; aux++)
                    {
                        if(i % aux == 0)
                        {
                            //Console.WriteLine("{0} es divisor de {1}",aux,i);
                            contadorDivisores++;
                        }
                        if (aux == i/2)
                        {
                            break;
                        }
                    }

                    if(contadorDivisores < 2)
                    {
                        Console.WriteLine("{0} es numero primo",i);
                    }
                    contadorDivisores = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
