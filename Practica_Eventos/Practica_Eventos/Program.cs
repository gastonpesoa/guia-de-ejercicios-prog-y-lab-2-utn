using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Eventos
{
    class Program
    {
        public delegate void GenerandoNumeroManejadorDeEvento(Generador sender);

        public class Generador
        {
            public event GenerandoNumeroManejadorDeEvento GenerandoNumero;
            private string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public Generador(string name)
            {
                this.Nombre = name;
            }

            public static void G_GenerandoNumero(Generador sender)
            {
                Console.WriteLine(sender.Nombre + " generará un número");
            }
        }

        static void Main(string[] args)
        {
            Generador g = new Generador("GENERADOREITOR");
            g.GenerandoNumero += G_GenerandoNumero;

        }

        private static void G_GenerandoNumero(Generador sender)
        {
            //if (G_GenerandoNumero != null)
            //{

            //}
        }
    }
}
