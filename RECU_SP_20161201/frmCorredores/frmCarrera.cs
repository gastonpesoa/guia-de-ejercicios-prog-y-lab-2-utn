using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace frmCorredores
{
    public partial class frmCarrera : Form
    {
        public delegate void CorrenCallback(int avance, Corredor corredor);

        private List<Persona> corredores;
        private List<Thread> corredoresActivos;
        private bool hayGanador;

        public frmCarrera()
        {
            InitializeComponent();
            this.corredores = new List<Persona>();
            this.corredoresActivos = new List<Thread>();
            this.corredores.Add(new Persona("Fernando", 9, Corredor.Carril.Carril_1));
            this.corredores.Add(new Persona("Carlos", 15, Corredor.Carril.Carril_2));
            this.hayGanador = false;
        }

        private void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                // Aquí irá el código del alumno
                this.AnalizarCarrera(pgbCarril1, avance, corredor);
                this.AnalizarCarrera(pgbCarril2, avance, corredor);
            }
        }

        private void LimpiarCarriles()
        {
            pgbCarril1.Value = 0;
            pgbCarril2.Value = 0;
        }

        private void HayGanador(Corredor corredor)
        {
            this.hayGanador = true;

            foreach (Thread thread in this.corredoresActivos)
            {
                if (thread.IsAlive && thread != null)
                {
                    thread.Abort();
                }
            }

            corredor.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ganadores.txt");
            MessageBox.Show(corredor.ToString(), "Ganador!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            //int nuevoValor = carril.Value + avance;
            //if (nuevoValor < 100 && this.hayGanador == false)
            //{
            //    carril.Value = nuevoValor;
            //}
            //else if (this.hayGanador == false)
            //{
            //    carril.Value = 100;
            //    this.hayGanador = true;
            //    this.HayGanador(corredor);
            //}
            switch (corredor.CarrilElegido)
            {
                case Corredor.Carril.Carril_1:
                    if (carril == pgbCarril1)
                    {
                        if (pgbCarril1.Value <= pgbCarril1.Maximum)
                        {
                            carril.Increment(avance);
                        }
                        if (pgbCarril1.Value == 100)
                        {
                            this.HayGanador(corredor);
                        }
                    }

                    break;

                case Corredor.Carril.Carril_2:
                    if (carril == pgbCarril2)
                    {
                        if (pgbCarril2.Value <= pgbCarril2.Maximum)
                        {
                            carril.Increment(avance);
                        }
                        if (pgbCarril2.Value == 100)
                        {
                            this.HayGanador(corredor);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            this.LimpiarCarriles();

            Persona.Corriendo += this.PersonaCorriendo;

            foreach (Persona persona in this.corredores)
            {
                Thread t = new Thread(persona.Correr);
                this.corredoresActivos.Add(t);
                t.Start();
            }
        }
    }
}
