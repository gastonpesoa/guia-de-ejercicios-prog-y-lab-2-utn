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
    public partial class FrmLlamador : Form
    {
        #region "Atributos"
        private Centralita centralita;
        #endregion

        #region "Propiedades"
        public Centralita GetCentralita
        {
            get { return this.centralita; }
        }
        #endregion

        #region "Constructor"
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }
        #endregion

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPanel1_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "1";
        }

        private void btnPanel2_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "2";
        }

        private void btnPanel3_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "3";
        }

        private void btnPanel4_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "4";
        }

        private void btnPanel5_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "5";
        }

        private void btnPanel6_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "6";
        }

        private void btnPanel7_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "7";
        }

        private void btnPanel8_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "8";
        }

        private void btnPanel9_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "9";
        }

        private void btnPanelAsterisco_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "*";
        }

        private void btnPanel0_Click(object sender, EventArgs e)
        {
            this.ChangeCmbFrajaIfIsProvincial();
            txtNumeroDestino.Text += "0";
        }

        private void btnPanelNumeral_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbFranja.Enabled = true;
            txtNumeroDestino.Text = "";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            Random random = new Random();
            float duracion = random.Next(1, 50);
            float costo = random.Next((int)0.5, (int)5.6);
            int origen;

            if (!int.TryParse(txtNumeroOrigen.Text, out origen))
            {
                MessageBox.Show("El numero origen debe ser numerico!","Error numero de origen",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNumeroOrigen.Text = "";
            }
            if (txtNumeroDestino.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de destino!", "Error numero de destino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNumeroDestino.Text[0] == '#')
                {
                    Provincial provincial = new Provincial(origen.ToString(), franjas, duracion, txtNumeroDestino.Text);
                    this.centralita += provincial;
                }
                else
                {
                    Local local = new Local(txtNumeroDestino.Text, duracion, origen.ToString(), costo);
                    this.centralita += local;
                }
            }
        }

        private void ChangeCmbFrajaIfIsProvincial()
        {
            if (txtNumeroDestino.Text == "" && cmbFranja.Enabled == true)
            {
                cmbFranja.Enabled = false;
            }
        }
    }
}
