using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : Corredor
    {
        public delegate void CorrenCallbak(int avance, Corredor corredor);
        public static event CorrenCallbak Corriendo;

        private string nombre;

        public Persona(string nombre, short velocidadMaxi, Carril carril)
            :base(velocidadMaxi, carril)
        {
            this.nombre = nombre;
        }

        public override void Correr()
        {
            while (true)
            {
                if (!(Corriendo is null))
                {
                    Persona.Corriendo(Corredor.avance.Next(1, 10), this);
                    Thread.Sleep(300);
                }
            }
        }

        public override void Guardar(string path)
        {
            StreamWriter sW = null;
            try
            {
                sW = new StreamWriter(path, true);
                sW.WriteLine(this.ToString());
            }
            catch (Exception ex)
            {
                throw new NoSeGuardoException(ex);
            }
            finally
            {
                if (!(sW is null))
                {
                    sW.Close();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} en carril {1} a una velocidad máxima de 9", this.nombre, base.CarrilElegido);
            return s.ToString(); 
        }
    }
}
