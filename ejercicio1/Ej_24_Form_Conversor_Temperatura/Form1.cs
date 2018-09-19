using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedidasTemperatura;

namespace Ej_24_Form_Conversor_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFahrenheit.Text, out double gradosFahrenhiet))
            {
                return;
            }
            else
            {
                Fahrenheit f = new Fahrenheit(gradosFahrenhiet);
                txtFahrenheitAFahrenheit.Text = f.GetTemperatura().ToString();
                txtFahrenheitACelsius.Text = ((Celsius)f).GetTemperatura().ToString();
                txtFahrenheitAKelvin.Text = ((Kelvin)f).GetTemperatura().ToString();
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCelsius.Text, out double gradosCelsius))
            {
                return;
            }
            else
            {
                Celsius c = new Celsius(gradosCelsius);
                txtCelsiusAFahrenheit.Text = ((Fahrenheit)c).GetTemperatura().ToString();
                txtCelsiusACelsius.Text = c.GetTemperatura().ToString();
                txtCelsiusAKelvin.Text = ((Kelvin)c).GetTemperatura().ToString();
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtKelvin.Text, out double gradosKelvin)) 
            {
                return;
            }
            else
            {
                Kelvin k = new Kelvin(gradosKelvin);
                txtKelvinAFahrenheit.Text = ((Fahrenheit)k).GetTemperatura().ToString();
                txtKelvinACelsius.Text = ((Celsius)k).GetTemperatura().ToString();
                txtKelvinAKelvin.Text = k.GetTemperatura().ToString();
            }
        }
    }
}
