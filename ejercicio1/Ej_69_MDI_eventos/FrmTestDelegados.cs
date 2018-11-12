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
    public partial class FrmTestDelegados : Form
    {
        public delegate void CambiaNombreDelegate(string nombre);
        public event CambiaNombreDelegate CambiaNombre;
        public event CambiaNombreDelegate CambiaFoto;

        private string rutaFoto = null;

        public FrmTestDelegados()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiaNombre(txtActualizar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar Mostrar primero\n" + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            try
            {
                this.CambiaFoto(this.rutaFoto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe buscar una foto primero\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = openFileDialog1.FileName;
            }
        }
    }
}
