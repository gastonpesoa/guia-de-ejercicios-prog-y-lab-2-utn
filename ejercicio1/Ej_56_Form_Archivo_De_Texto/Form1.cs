using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string filePath = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "C:\\Users\\alumno\\Desktop";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                richTextBox1.Text = Acciones.Leer(filePath);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object obj = null;
            EventArgs args = null;
            if (richTextBox1.Text == "")
            {
                this.guardarComoToolStripMenuItem_Click(obj, args);
            }
            else
            {
                //this.streamWriter.Write(richTextBox1.Text);
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = "C:\\Users\\alumno\\Desktop";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Acciones.Guardar(saveFileDialog.FileName, richTextBox1.Text);
            }
        }
    }
}
