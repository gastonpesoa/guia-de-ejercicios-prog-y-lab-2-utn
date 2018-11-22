using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        
        public void IniciarAtencion(Paciente p)
        {
            Thread t = new Thread(this.Atender);
            base.AtenderA = p;
            t.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(1500,2200));
            base.FinalizarAtencion();
        }

        public MGeneral(string nombre, string apellido)
            : base(nombre, apellido) { }
    }
}
