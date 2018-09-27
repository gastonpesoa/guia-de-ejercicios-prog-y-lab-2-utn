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
        private Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;
        #endregion

        #region "Constructor"
        public FrmMostrar(Centralita centralita,Llamada.TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.TipoLlamada = tipoLlamada;
        }
        #endregion

        #region "Propiedades"
        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
            {
                this.centralita.OrdenarLlamadas();
                richTxtBox.Text = this.centralita.ToString();
            }
        }
    }
}
