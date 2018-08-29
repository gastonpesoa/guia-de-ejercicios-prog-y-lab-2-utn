using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_07_Dias_Vividos";

            int diaNacimiento, mesNacimiento, anioNacimiento;
            int diaActual, mesActual, anioActual;
            int diasVividos, mesesVividos, aniosVividos;
            int diasBisiesto;
            string diaStr, mesStr, anioStr;
            DateTime fechaActual = DateTime.Now;

            anioActual = fechaActual.Year;
            mesActual = fechaActual.Month;
            diaActual = fechaActual.Day;

            Console.WriteLine("Fecha de nacimiento");
            Console.Write("Ingrese dia: ");
            diaStr = Console.ReadLine();
            Console.Write("Ingrese mes: ");
            mesStr = Console.ReadLine();
            Console.Write("Ingrese anio: ");
            anioStr = Console.ReadLine();

            Console.WriteLine(fechaActual);
            Console.WriteLine("Fecha de Nacimiento: {0}/{1}/{2}", diaStr, mesStr, anioStr);

            if((int.TryParse(diaStr, out diaNacimiento)) && (int.TryParse(mesStr, out mesNacimiento)) && (int.TryParse(anioStr, out anioNacimiento)))
            {
                aniosVividos = anioActual - anioNacimiento;
                diasBisiesto = (aniosVividos / 4);
                mesesVividos = mesActual - mesNacimiento;

                diasVividos = (aniosVividos * 365) + ((mesesVividos * 30) - diaNacimiento) + diasBisiesto + diaActual;

                Console.WriteLine("Dias vividos a la fecha actual: {0}", diasVividos);
            }
            Console.ReadKey();
        }
    }
}
