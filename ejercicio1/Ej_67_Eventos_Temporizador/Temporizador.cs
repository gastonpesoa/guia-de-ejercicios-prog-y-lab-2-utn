using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej_67_Eventos_Temporizador
{
    public delegate void encargadoTiempo();

    public class Temporizador
    {
        public event encargadoTiempo EventoTiempo;
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get { return this.hilo.IsAlive; }
            set
            {
                if (value == true && !this.hilo.IsAlive)
                {
                    hilo = new Thread(Corriendo);
                    this.hilo.Start();
                }
                else
                {
                    if (value == false && this.hilo.IsAlive)
                    {
                        this.hilo.Abort();
                    }
                }
            }
        }

        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        private void Corriendo()
        {
            while (true)
            {
                EventoTiempo();
                Thread.Sleep(this.Intervalo);
            }
        }
    }
}
