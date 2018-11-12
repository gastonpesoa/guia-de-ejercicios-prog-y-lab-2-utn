using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_69_MDI_eventos
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string nombre)
        {
            lblNombre.Text = nombre;
        }

        public void ActualizarFoto(string nombre)
        {
            pictureBox1.ImageLocation = nombre;
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
