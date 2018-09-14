using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        private static int[] OrdenarArray(int [] arrayNumerosAleatorios)
        {
            for (int i = 0; i < arrayNumerosAleatorios.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayNumerosAleatorios.Length; j++)
                {
                    if (arrayNumerosAleatorios[i] > 0 && arrayNumerosAleatorios[i] < arrayNumerosAleatorios[j])
                    {
                        int aux = arrayNumerosAleatorios[i];
                        arrayNumerosAleatorios[i] = arrayNumerosAleatorios[j];
                        arrayNumerosAleatorios[j] = aux;
                    }
                    if (arrayNumerosAleatorios[i] < 0 && arrayNumerosAleatorios[i] > arrayNumerosAleatorios[j])
                    {
                        int aux = arrayNumerosAleatorios[i];
                        arrayNumerosAleatorios[i] = arrayNumerosAleatorios[j];
                        arrayNumerosAleatorios[j] = aux;
                    }
                }
            }
            return arrayNumerosAleatorios;
        }

        static void Main(string[] args)
        {
            Console.Title = "Ej_26_Carga_Aleatoria_de_Array";
            int[] arrayNumerosAleatorios;
            arrayNumerosAleatorios = new int[20];

            Random random = new Random();

            for(int i = 0; i< arrayNumerosAleatorios.Length; i++)
            {
                arrayNumerosAleatorios[i] = random.Next(-200, 200);
            }

            Console.WriteLine("Array generado: ");
            foreach (int item in arrayNumerosAleatorios)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ordenando Array");
            Program.OrdenarArray(arrayNumerosAleatorios);

            Console.WriteLine("Positivos en forma decreciente: ");
            foreach (int item in arrayNumerosAleatorios)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Negativos en forma creciente: ");
            foreach (int item in arrayNumerosAleatorios)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
