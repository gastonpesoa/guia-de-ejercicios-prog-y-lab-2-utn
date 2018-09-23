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
    public partial class FrmLlamador : FrmMenu
    {
        #region Propiedades

        public Centralita GetCentralita
        {
            get { return base.centralita; }
        }
        #endregion

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            base.centralita = centralita;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }
    }
}
