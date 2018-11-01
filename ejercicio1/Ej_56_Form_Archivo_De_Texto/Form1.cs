using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_56_Form_Archivo_De_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = richTextBox1.Text.Length + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.InitialDirectory = "c:\\";
            oFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if (oFD.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
