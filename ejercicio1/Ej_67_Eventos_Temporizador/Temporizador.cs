using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_67_Eventos_Temporizador
{
    public delegate void encargadoTiempo();
    public class Temporizador
    {
        public event encargadoTiempo EventoTiempo;
        private System.Threading.Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get { return this.hilo.IsAlive; }
            set
            {
                if (value == true && !this.hilo.IsAlive)
                {
                    hilo = new System.Threading.Thread(Corriendo);
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

        private void Corriendo() { }
    }
}
