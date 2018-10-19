using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesContabilidad;

namespace Ej_48_Contabilidad_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Recibo r1 = new Recibo(5000);
            Recibo r2 = new Recibo(250);
            Factura f1 = new Factura(15442);
            Factura f2 = new Factura(6548);

            c += r1;
            c += r2;
            c += f1;
            c += f2;

            Console.WriteLine("EGRESOS:");
            foreach (Factura r in c.Egresos)
            {
                Console.WriteLine(r.Numero);
            }
            Console.WriteLine("\nINGRESOS:");
            foreach (Recibo r in c.Ingresos)
            {
                Console.WriteLine(r.Numero);
            }
            Console.ReadKey();
        }
    }
}
