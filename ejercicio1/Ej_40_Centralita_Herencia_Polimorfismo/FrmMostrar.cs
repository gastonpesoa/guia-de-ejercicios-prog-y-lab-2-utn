using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_40_Centralita_Herencia_Polimorfismo
{
    public partial class FrmMostrar : Form
    {
        #region Atributo

        Centralita centralita = new Centralita("Central Telefonica");
        #endregion
        public FrmMostrar()
        {
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
