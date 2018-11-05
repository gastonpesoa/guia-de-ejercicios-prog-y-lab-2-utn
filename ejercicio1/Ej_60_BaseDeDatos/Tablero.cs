using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_60_BaseDeDatos
{
    public partial class Tablero : Form
    {
        List<Product> products = new List<Product>();

        public Tablero()
        {
            InitializeComponent();

            this.ActualizarListBox();
        }

        private void ActualizarListBox()
        {
            productFoundListbox.DataSource = products;
            productFoundListbox.DisplayMember = "MostrarDatos";
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();
            products = db.GetProducts(productNameText.Text);

            this.ActualizarListBox();
        }
    }
}
