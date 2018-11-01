using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_57_Persona_Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Gaston", "Pesoa");
            Persona p2 = null;
            bool guardado = false;
            try
            {
                guardado = Persona.Guardar(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Exception aux = ex.InnerException;
                while (!(aux is null))
                {
                    Console.WriteLine(aux.Message);
                    aux = aux.InnerException;
                }
            }

            try
            {
                p2 = Persona.Leer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Exception aux = ex.InnerException;
                while (!(aux is null))
                {
                    Console.WriteLine(aux.Message);
                    aux = aux.InnerException;
                }
            }
            finally
            {
                if (!(p2 is null))
                {
                    Console.WriteLine(p2.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
