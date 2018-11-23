using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<Queue<T>>
    {
        public void Guardar(string archivo, Queue<T> datos)
        {

            XmlTextWriter writer = null;
            XmlSerializer ser = null;
            try
            {
                ser = new XmlSerializer(typeof(T));
                writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                    "\\" + archivo, Encoding.UTF8);
                foreach (T t in datos)
                {
                    ser.Serialize(writer, t);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo serializar\n" + ex.Message, ex);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                }
            }
        }

        public void Leer(string archivo, out Queue<T> datos)
        {
            datos = new Queue<T>();
            XmlTextReader reader = null;
            XmlSerializer ser;

            try
            {
                ser = new XmlSerializer(typeof(T));
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                    "\\" + archivo);
                while (reader != null)
                {
                    datos.Enqueue((T)ser.Deserialize(reader));
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo\n" + ex.Message, ex);
            }
            finally
            {
                if (!(reader is null))
                {
                    reader.Close();
                }
            }
        }
    }
}
