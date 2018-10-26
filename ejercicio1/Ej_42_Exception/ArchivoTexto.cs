using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ej_42_Exception
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path, string value)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(path);
                streamWriter.Write(value);
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException("No se encontro el archivo", ex);
            }
            finally
            {
                if (!(streamWriter is null))
                {
                    streamWriter.Close();
                }
            }
        }

        public static string Leer(string path)
        {
            StreamReader streamReader = null;
            string value;
            try
            {
                streamReader = new StreamReader(path);
                value = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException("No se encontro el archivo", ex);
            }
            finally
            {
                if (!(streamReader is null))
                {
                    streamReader.Close();
                }
            }
            return value;
        }
    }
}
