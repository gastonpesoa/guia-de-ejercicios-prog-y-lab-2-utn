using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numero;

namespace Ej_22_OperacionesBinarioDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = "1011010110";
            NumeroDecimal numeroDecimal = 700;

            Console.WriteLine("numeroBinario: {0} = {1} decimal", (string)numeroBinario, Conversor.BinarioDecimal((string)numeroBinario));
            Console.WriteLine("numeroDecimal: {0} = {1} binario", (double)numeroDecimal, Conversor.DecimalBinario((double)numeroDecimal));

            Console.WriteLine("numeroBinario {0} + numeroDecimal {1} = {2}", (string)numeroBinario, (double)numeroDecimal, numeroBinario + numeroDecimal);
            Console.WriteLine("numeroBinario {0} - numeroDecimal {1} = {2}", (string)numeroBinario, (double)numeroDecimal, numeroBinario - numeroDecimal);

            Console.WriteLine("numeroDecimal {0} + numeroBinario {1} = {2}", (double)numeroDecimal, (string)numeroBinario, numeroDecimal + numeroBinario );
            Console.WriteLine("numeroDecimal {0} - numeroBinario {1} = {2}", (double)numeroDecimal, (string)numeroBinario, numeroDecimal - numeroBinario );

            numeroBinario = "1011010110";
            numeroDecimal = 726;

            Console.WriteLine("Ahora numeroBinario: {0} = {1} decimal", (string)numeroBinario, Conversor.BinarioDecimal((string)numeroBinario));
            Console.WriteLine("Ahora numeroDecimal: {0} = {1} binario", (double)numeroDecimal, Conversor.DecimalBinario((double)numeroDecimal));

            Console.WriteLine("numeroBinario = numeroDeciaml ?: {0}", numeroBinario == numeroDecimal);
            Console.WriteLine("numeroBinario != numeroDeciaml ?: {0}", numeroBinario != numeroDecimal);
            Console.WriteLine("numeroDeciaml = numeroBinario?: {0}", numeroDecimal == numeroBinario);
            Console.WriteLine("numeroDeciaml != numeroBinario?: {0}", numeroDecimal != numeroBinario);

            Console.ReadKey();
        }
    }
}
