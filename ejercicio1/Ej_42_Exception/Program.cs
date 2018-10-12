using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClaseExceptionDos c = new ClaseExceptionDos(false);
                c.MetodoExceptionDos();
            }
            catch(MiException m)
            {
                Exception aux = m.InnerException;
                Console.WriteLine(m.Message);
                while (aux != null)
                {
                    Console.WriteLine(aux.Message);
                    aux = aux.InnerException;
                }
            }
            Console.ReadKey();
        }
    }
}
