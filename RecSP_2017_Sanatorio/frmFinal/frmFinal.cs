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

namespace frmFinal
{
    public partial class frmFinal : Form
    {
        private MEspecialista mEspecialista;
        private MGeneral mGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEspera;    

        public frmFinal()
        {
            InitializeComponent();
            this.pacientesEspera = new Queue<Paciente>();
            this.mGeneral = new MGeneral("Luis", "Salinas");
            this.mEspecialista = new MEspecialista("Jorge", "Iglesias",
            MEspecialista.Especialidad.Traumatologo);
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            this.mocker = new Thread(this.MockPacientes);
            mocker.Start();
        }

        private void MockPacientes()
        {
            this.pacientesEspera.Enqueue(new Paciente("Sancho", "Panza"));
            Thread.Sleep(5000);
        }
         
        private void AtenderPaciente(IMedico iMedico)
        {
            if (!(this.pacientesEspera is null))
            {
                iMedico.IniciarAtencion(pacientesEspera.Dequeue());
            }
        }

        private void FinAtencion(Paciente p, Medico m)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    StringBuilder s = new StringBuilder();
                    s.AppendFormat("Finalizó la atención de {0} por {1}!", p.ToString(), m.ToString());
                    MessageBox.Show(s.ToString(), "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            mGeneral.AtencionFinalizada += FinAtencion;
            //mGeneral.AtenderA = this.pacientesEspera.Dequeue();
            this.AtenderPaciente(this.mGeneral);
        }

        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            mEspecialista.AtencionFinalizada += FinAtencion;
            this.AtenderPaciente(this.mEspecialista);
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.mocker.IsAlive && this.mocker != null)
            {
                this.mocker.Abort();
            }
        }
    }
}
