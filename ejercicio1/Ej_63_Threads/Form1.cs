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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AsignarHora();
            Thread.Sleep(1000);
        }

        private bool AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyyy hh:mm:ss");
            return true;
        }
    }
}
