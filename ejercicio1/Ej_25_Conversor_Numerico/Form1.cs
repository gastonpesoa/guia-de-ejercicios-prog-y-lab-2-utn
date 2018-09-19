using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numero;

namespace Ej_25_Conversor_Numerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtBinario.Text, out long binParsed))
            {
                return;
            }
            else
            {
                txtResultadoDec.Text = Conversor.BinarioDecimal(txtBinario.Text).ToString();
            }
            
        }

        private void btbDecToBin_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDecimal.Text, out double numeroDecimal))
            {
                return;
            }
            else
            {
                txtResultadoBin.Text = Conversor.DecimalBinario(numeroDecimal).ToString();
            }
        }
    }
}
