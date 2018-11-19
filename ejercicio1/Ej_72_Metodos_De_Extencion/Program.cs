using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodo_De_Extencion;

namespace Ej_72_Metodos_De_Extencion
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            long numero;

            while (continuar == "s")
            {
                do
                {
                    Console.Write("Ingrese un numero: ");
                } while (!long.TryParse(Console.ReadLine(), out numero));
                
                Console.WriteLine("Numero de\t" +
                    numero.CantidadDeDigitos() + " digitos");

                Console.Write("\nContinuar?: [s|n] ");
                continuar = Console.ReadLine();
            }
        }
    }
}
