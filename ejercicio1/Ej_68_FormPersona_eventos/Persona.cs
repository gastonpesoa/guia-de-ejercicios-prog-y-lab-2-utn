using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_68_FormPersona_eventos
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}, {1}", this.Apellido, this.Nombre);
            return s.ToString();
        }
    }
}
