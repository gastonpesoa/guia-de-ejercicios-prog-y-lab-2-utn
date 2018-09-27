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
    public partial class FrmMostrar : Form
    {
        #region "Atributos"
        Centralita centralita;
        #endregion

        #region "Constructor"
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
