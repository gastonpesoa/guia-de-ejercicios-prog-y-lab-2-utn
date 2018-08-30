using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = Math.Pow(lado, 2);
            return area;
        }

        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double area = (baseTriangulo * altura) / 2;
            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area = Math.Pow(radio,2) * Math.PI;
            return area;
        }
    }
}
