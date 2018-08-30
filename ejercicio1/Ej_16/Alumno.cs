using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            notaFinal = (nota1 + nota2) / 2;
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            Console.Write("Ingrese nota1: ");
            nota1 = Convert.T Console.ReadLine();
        }
    }
}
