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
 
namespace Ej_67_Eventos_Temporizador
{
    public partial class Form1 : Form
    {
        Temporizador reloj;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloj = new Temporizador(1000);
            reloj.EventoTiempo += Reloj_EventoTiempo;
            reloj.Activo = true;

        }

        private void Reloj_EventoTiempo()
        {
            this.ActualizarHora(reloj.Intervalo);
        }

        private void ActualizarHora(object o)
        {
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke((MethodInvoker)delegate 
                {
                    this.AsignarHora();
                });
            }
            else
            {
                this.AsignarHora();
            }
        }

        private bool AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyyy hh:mm:ss");
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reloj.Activo = false;
        }
    }
}
