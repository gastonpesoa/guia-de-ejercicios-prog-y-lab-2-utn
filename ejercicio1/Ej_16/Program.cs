using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej_16_Class_Alumno";

            Alumno alumno1 = new Alumno("Juan", "Roca", 00001);
            Alumno alumno2 = new Alumno("Sergio", "Montes", 00002);
            Alumno alumno3 = new Alumno("Raul", "Viana", 00003);

            alumno1.Estudiar(4, 6);
            alumno2.Estudiar(8, 9);
            alumno3.Estudiar(2, 7);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
