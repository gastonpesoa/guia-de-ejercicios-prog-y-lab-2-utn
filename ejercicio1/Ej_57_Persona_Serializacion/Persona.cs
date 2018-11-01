using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Ej_57_Persona_Serializacion
{
    public class Persona
    {
        #region "Atributos"
        private string nombre;
        private string apellido;
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        #endregion

        #region "Constructor"
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region "Metodos"
        public static bool Guardar(Persona p)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            bool guardado = false;
            try
            {
                writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Persona.xml", Encoding.UTF8);
                ser.Serialize(writer, p);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intanciar writer", ex);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                    guardado = true;
                }
            }
            return guardado;
        }

        public static Persona Leer()
        {
            Persona p = null;
            XmlTextReader reader = null;
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            try
            {
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Persona.xml");
                p = (Persona)ser.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar", ex);
            }
            finally
            {
                if (!(reader is null))
                {
                    reader.Close();
                }
            }
            return p;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}, {1}", this.nombre, this.apellido);
            return s.ToString();
        }
        #endregion
    }
}
