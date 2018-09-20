using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33_Libro_Indexador
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();
            l[0] = "Pagina 1";
            l[1] = "Pagina 2";
            l[1] = "Pagina 2.1";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(l[i]);
            }
        }
    }
}
