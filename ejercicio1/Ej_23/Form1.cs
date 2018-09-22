using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ej_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(txtEuro.Text, out cantidad);
            if (cantidad <= 0)
            {
                return;
            }
            Euro euro = new Euro(cantidad);
            txtEuroAPesos.Text = ((Pesos)euro).GetCantidad().ToString();
            txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
            
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(txtDolar.Text, out cantidad);
            if (cantidad <= 0)
            {
                return;
            }
            Dolar dolar = new Dolar(cantidad);
            txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            txtDolarAPesos.Text = ((Pesos)dolar).GetCantidad().ToString();
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double cantidad;
            double.TryParse(txtPesos.Text, out cantidad);
            if (cantidad <= 0)
            {
                return;
            }
            Pesos pesos = new Pesos(cantidad);
            txtPesosAEuro.Text = ((Euro)pesos).GetCantidad().ToString();
            txtPesosADolar.Text = ((Dolar)pesos).GetCantidad().ToString();
        }
    }
}
