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

namespace Ej_63_Threads
{
    public partial class Form1 : Form
    {
        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.timer1.Interval = 1000;
            //this.timer1.Start();
            thread = new Thread(new ParameterizedThreadStart(this.ActualizarHora));
            thread.Start(1000);

            
        }

        private void ActualizarHora(object o)
        {
            while (true)
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.AsignarHora();
                    });
                }
                Thread.Sleep((int)o);
            }
        }

        private bool AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyyy hh:mm:ss");
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    this.AsignarHora();
        //}
    }
}
