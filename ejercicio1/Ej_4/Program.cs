using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_4";

            int aux, numero = 6;
            int suma = 0, numerosPerfectos = 0;
          
            while (numerosPerfectos < 4)
            {
                for(aux = 1; aux <= numero; aux++)
                {
                    if(numero % aux == 0)
                    {
                        suma = suma + aux;
                    }
                    if(aux == numero / 2)
                    {
                        break;
                    }
                }
                if(suma == numero)
                {
                    numerosPerfectos++;
                    Console.WriteLine("Numero perfecto {0}: {1}", numerosPerfectos, numero);
                }
                numero++;
                suma = 0;
            }
            Console.ReadKey();
        }
    }
}
