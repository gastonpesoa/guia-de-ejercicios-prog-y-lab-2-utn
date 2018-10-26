using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ej_42_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFile = null;
            try
            {
                ClaseExceptionDos c = new ClaseExceptionDos(false);
                c.MetodoExceptionDos();
            }
            catch(MiException m)
            {
                nameFile = DateTime.Now.ToString("yyyyMMdd-HHmm");
                Exception aux = m.InnerException;
                //Console.WriteLine(m.Message);
                try
                {
                    ArchivoTexto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + nameFile + ".txt", m.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                while (aux != null)
                {
                    //Console.WriteLine(aux.Message);
                    try
                    {
                        ArchivoTexto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + nameFile + ".txt", aux.Message);
                        aux = aux.InnerException;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(aux.Message);
                    }
                }
            }
            //Console.WriteLine(ArchivoTexto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + nameFile + ".txt", aux.Message));
            Console.ReadKey();
        }
    }
}
