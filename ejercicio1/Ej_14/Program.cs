using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_14";

            double ladoCuadrado, baseTriangulo, alturaTriangulo, radioCirculo;
            string ladoCuadradoStr, baseTrianguloStr, alturaTrianguloStr, radioCirculoStr;
            double areaCuadrado, areaTriangulo, areaCirculo;

            Console.WriteLine("AREA CUADRADO\n");
            Console.Write("Ingrese lado del cuadrado: ");
            ladoCuadradoStr = Console.ReadLine();

            if(double.TryParse(ladoCuadradoStr, out ladoCuadrado))
            {
                areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                Console.WriteLine("Area del cuadrado: {0}", areaCuadrado);
            }

            Console.WriteLine("\nAREA TRIANGULO\n");
            Console.Write("Ingrese base del triangulo: ");
            baseTrianguloStr = Console.ReadLine();
            Console.Write("Ingrese altura del triangulo: ");
            alturaTrianguloStr = Console.ReadLine();

            if (double.TryParse(baseTrianguloStr, out baseTriangulo) && double.TryParse(alturaTrianguloStr, out alturaTriangulo))
            {
                areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                Console.WriteLine("Area del triangulo: {0}", areaTriangulo);
            }

            Console.WriteLine("\nAREA CIRCULO\n");
            Console.Write("Ingrese el radio circulo: ");
            radioCirculoStr = Console.ReadLine();

            if (double.TryParse(radioCirculoStr, out radioCirculo))
            {
                areaCirculo = CalculoDeArea.CalcularCirculo(radioCirculo);
                Console.WriteLine("Area del circulo: {0}", areaCirculo);
            }

            Console.ReadKey();
        }
    }
}
