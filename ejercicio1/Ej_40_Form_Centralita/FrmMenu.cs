using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita_Biblioteca;

namespace Ej_40_Form_Centralita
{
    public partial class FrmMenu : Form
    {
        #region Atributo
        
        public Centralita centralita;

        #endregion

        public FrmMenu()
        {
            InitializeComponent();
            Centralita centralita = new Centralita("UTN-Centralita");
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
