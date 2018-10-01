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
            switch (this.tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    richTxtBox.Text = "Ganancias por llamadas locales: " + this.centralita.GananciasPorLocal.ToString();
                    break;
                case Llamada.TipoLlamada.Provincial:
                    richTxtBox.Text = "Ganancias por llamadas provinciales: " + this.centralita.GananciasPorProvincial.ToString();
                    break;
                case Llamada.TipoLlamada.Todas:
                    richTxtBox.Text = "Ganancias por total de llamadas: " + this.centralita.GananciasPorTotal.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
