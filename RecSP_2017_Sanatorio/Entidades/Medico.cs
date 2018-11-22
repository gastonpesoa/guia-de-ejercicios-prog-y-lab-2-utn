using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Medico : Persona
    {
        public delegate void FinAtencionPaciente(Paciente p, Medico m);
        public event FinAtencionPaciente AtencionFinalizada;

        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;
        
        public virtual string EstaAtendidoA
        {
            get { return this.pacienteActual.ToString(); }
        }

        public Paciente AtenderA
        {
            set { this.pacienteActual = value; }
        }

        static Medico()
        {
            Medico.tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            :base(nombre, apellido) { }

        protected abstract void Atender();

        protected void FinalizarAtencion()
        {
            if (AtencionFinalizada != null)
            {
                AtencionFinalizada(this.pacienteActual, this);
                this.pacienteActual = null;
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}, {1}", base.apellido, base.nombre);
            return s.ToString(); 
        }
    }
}
