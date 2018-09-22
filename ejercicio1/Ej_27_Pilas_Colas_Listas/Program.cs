using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_27_Pilas_Colas_Listas
{
    class Program
    {
        private static int OrdenarDecreciente(int num1, int num2)
        {       
            return -num1.CompareTo(num2);
        }

        static void Main(string[] args)
        {
            //-----------------------LISTA-----------------------------//
            List<int> numeros;
            numeros = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros.Add(random.Next(-200, 200));
            }

            Console.WriteLine("Lista generada: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Sort(Program.OrdenarDecreciente);
            Console.WriteLine("Positivos ordenados decreciente");
            foreach (int numero in numeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }

            numeros.Sort();
            Console.WriteLine("Negativos ordenados creciente");
            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadKey();
            Console.Clear();
            //-----------------COLAS----------------------------//
            Console.WriteLine("Cola");
            Queue<int> numerosCola = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                numerosCola.Enqueue(random.Next(-200, 200));
            }

            Console.WriteLine("Lista generada: ");
            foreach (int numero in numerosCola)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            Console.Clear();

            //---------------------------PILA----------------------------//
            Console.WriteLine("PILA");
            Stack<int> numerosPila = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                numerosPila.Push(random.Next(-200, 200));
            }

            Console.WriteLine("Lista generada");
            do
            {
                int num = (int)numerosPila.Pop();
                Console.WriteLine(num);
            } while (numerosPila.Count > 0);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
