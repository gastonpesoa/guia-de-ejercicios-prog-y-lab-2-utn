using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        public enum Especialidad { Traumatologo, Odontologo }

        private Especialidad especialidad;

        public void IniciarAtencion(Paciente p)
        {
            Thread t = new Thread(this.Atender);
            base.AtenderA = p;
            t.Start();
        }
        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(5000, 10000));
            base.FinalizarAtencion();
        }

        public MEspecialista(string nombre, string apellido, Especialidad e)
            : base(nombre, apellido)
        {
            this.especialidad = e;
        }

    }
}
