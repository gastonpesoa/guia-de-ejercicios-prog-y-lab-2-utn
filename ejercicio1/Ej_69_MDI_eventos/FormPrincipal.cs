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
    public partial class FormPrincipal : Form
    {
        public FrmTestDelegados fTD;
        public FormDatos fD;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTD = new FrmTestDelegados();
            fTD.Owner = this;
            fTD.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fD = new FormDatos();
            fD.Owner = this;
            try
            {
                fTD.CambiaNombre += fD.ActualizarNombre;
                fTD.CambiaFoto += fD.ActualizarFoto;
                fD.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe selccionar Test delegado primero\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
