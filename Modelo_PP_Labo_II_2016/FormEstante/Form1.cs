using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using TestEstante;

namespace FormEstante
{
    public partial class Form1 : Form
    {
        private static int OrdenarProductosPorMarca(Producto prodUno, Producto prodDos)
        {
            return prodUno.Marca.CompareTo(prodDos.Marca);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
